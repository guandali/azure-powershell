﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.ServiceManagemenet.Common;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.WindowsAzure.Commands.Common;

namespace Microsoft.WindowsAzure.Commands.Test.Utilities.Common
{
    /// <summary>
    /// Base class for Microsoft Azure PowerShell Service Management unit tests.
    /// </summary>
    public abstract class SMTestBase
    {
        protected AzureSMProfile currentProfile;

        public SMTestBase()
        {
            AzureSessionInitializer.InitializeAzureSession();
            ServiceManagementProfileProvider.InitializeServiceManagementProfile();
            System.Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            BaseSetup();
        }

        /// <summary>
        /// Initialize the necessary environment for the tests.
        /// </summary>
        [TestInitialize]
        public void BaseSetup()
        {
            AzureSessionInitializer.InitializeAzureSession();
            ServiceManagementProfileProvider.InitializeServiceManagementProfile();
            if (AzureSession.Instance.DataStore == null || ( AzureSession.Instance.DataStore != null && !(AzureSession.Instance.DataStore is MemoryDataStore)))
            {
                AzureSession.Instance.DataStore = new MemoryDataStore();
            }
            currentProfile = new AzureSMProfile();

            if (currentProfile.Context.Subscription == null)
            {
                var newGuid = Guid.NewGuid();
                var client = new ProfileClient(currentProfile);
                var account = new AzureAccount
                    {
                        Id = "test",
                        Type = AzureAccount.AccountType.User,
                    };
                account.SetSubscriptions(newGuid.ToString());
                client.AddOrSetAccount(account);
                var sub = new AzureSubscription { Id = newGuid.ToString(), Name = "test" };
                sub.SetEnvironment(EnvironmentName.AzureCloud);
                sub.SetAccount("test");
                client.AddOrSetSubscription(sub);
               client.SetSubscriptionAsDefault(newGuid, "test");
           }
            AzureSession.Instance.AuthenticationFactory = new MockTokenAuthenticationFactory();
        }

        /// <summary>
        /// Gets or sets a reference to the TestContext used for interacting
        /// with the test framework.
        /// </summary>
        public TestContext TestContext { get; set; }

        public string FullyQualifiedTestClassName => TestContext?.FullyQualifiedTestClassName;

        public string TestName => TestContext?.TestName;

        /// <summary>
        /// Log a message with the test framework.
        /// </summary>
        /// <param name="format">Format string.</param>
        /// <param name="args">Arguments.</param>
        public void Log(string format, params object[] args)
        {
            if (TestContext != null)
            {
                TestContext.WriteLine(format, args);
            }
        }
    }
}
