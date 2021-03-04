."$PSScriptRoot\testDataGenerator.ps1"
."$PSScriptRoot\virtualNetworkClient.ps1"

$env = @{}
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    Import-Module -Name Az.Resources
    $subscriptionId = (Get-AzContext).Subscription.Id
    $env.SubscriptionId = $subscriptionId
    $env.Tenant = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.

    $rstr1 = RandomString -allChars $false -len 6
    write-host "creating test resource group..."
    #$resourceGroupName = "powershelldnsresolvertestrg" + $rstr1
    $resourceGroupName = "powershell-test-rg"
    New-AzResourceGroup -Name $resourceGroupName -Location eastus
    $env.Add("ResourceGroupName", $resourceGroupName)

    $null = $env.Add("DnsResolverNamePrefix", "psdnsresolvername");
    $null = $env.Add("VirtualNetworkNamePrefix", "psvirtualnetworkname");
    $null = $env.Add("InboundEndpointNamePrefix", "psinboundendpointname");
    $null = $env.Add("SubnetNamePrefix", "pssubnetname");
    $null = $env.Add("InboundEnpointNamePrefix", "psinboundendpointname");


    $null = $env.Add("SuccessProvisioningState", "Succeeded");
    $null = $env.Add("ResourceLocation", "westus2");
    $null = $env.Add("MalformedVirtualNetworkErrorMessage", "Resource ID is not a valid virtual network resource ID");
    $null = $env.Add("AddressPrefix", "40.121.0.0/16");
    $null = $env.Add("LocationForVirtualNetwork", "westus2");
    
    $nrpSimulatorUri = [System.Environment]::GetEnvironmentVariable('NRP_SIMULATOR_URI')

    if($nrpSimulatorUri -ne $null){
        $null = $env.Add("NRP_SIMULATOR_URI", $nrpSimulatorUri);
    }

    # Provison of virtual network and generating DNS Resolver name.
    # New-cmdlet uses 0 - 12
    # Get-cmdlet uses 13 - 21
    # Remove-cmdlet uses 22-32
    # Patch 33 - 38
    # New IE - 38 - 45
    # Patch IE - 46 - 49
    # Get IE 50 - 60
    $dnsResolverNameEnvKeyPrefix = "DnsResolverName"
    $virtualNetworkIdEnvKeyPrefix = "VirtualNetworkId"
    $subnetIdEnvKeyPrefix = "SubnetId"
    $inboundEndpointNameEnvKeyPrefix = "InboundEnpointName" 
    For($i=0; $i -le 50; $i++){
        $dnsResolverNameEnvKey = $dnsResolverNameEnvKeyPrefix + $i
        $dnsResolverName = $env.DnsResolverNamePrefix + $i + (RandomString -allChars $false -len 6)
        $null = $env.Add($dnsResolverNameEnvKey, $dnsResolverName);

        $inboundEndpointNameEnvKey = $inboundEndpointNameEnvKeyPrefix + $i
        $inboundEndpointName = $env.InboundEnpointNamePrefix + $i + (RandomString -allChars $false -len 6)
        $null = $env.Add($inboundEndpointNameEnvKey, $inboundEndpointName);

        $virtualNetworkIdEnvKey = $virtualNetworkIdEnvKeyPrefix + $i
        $virtualNetworkName = $env.VirtualNetworkNamePrefix + $i + (RandomString -allChars $false -len 6)
        $virtualNetworkId = (CreateVirtualNetwork -SubscriptionId  $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -VirtualNetworkName $virtualNetworkName).id
        $null = $env.Add($virtualNetworkIdEnvKey, $virtualNetworkId);

        $subnetIdEnvKey = $subnetIdEnvKeyPrefix + $i
        $subnetName = $env.SubnetNamePrefix + $i + (RandomString -allChars $false -len 6)
        $subnetId = (CreateSubnet -SubscriptionId  $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -VirtualNetworkName $virtualNetworkName -SubnetName $subnetName).id
        $null = $env.Add($subnetIdEnvKey, $subnetId);
    }

    $unpairedVirtualNetworkIdEnvKeyPrefix = "UnpairedVirtualNetwork"
    For($i=0; $i -le 10; $i++){
        $virtualNetworkName = $env.VirtualNetworkNamePrefix + "unpaired"+ $i + (RandomString -allChars $false -len 6)
        $virtualNetworkIdEnvKey = $unpairedVirtualNetworkIdEnvKeyPrefix + $i
        $virtualNetworkId = (CreateVirtualNetwork -SubscriptionId  $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -VirtualNetworkName $virtualNetworkName).id
        $null = $env.Add($virtualNetworkIdEnvKey, $virtualNetworkId)
    }

    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}

function cleanupEnv() {
    # Clean resources you create for testing
    #Remove-AzResourceGroup -Name $env.ResourceGroupName
}

