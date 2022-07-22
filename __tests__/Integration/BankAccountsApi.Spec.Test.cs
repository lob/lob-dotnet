/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace __tests__.Integration {
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class BankAccountsApiTests : IDisposable
    {
        private BankAccountsApi validApi;
        private BankAccountsApi invalidApi;
        private BankAccountWritable bankAccountWritable;
        private BankAccountVerify verification;
        private List<string> idsToDelete;

        public BankAccountsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new BankAccountsApi(config);
            invalidApi = new BankAccountsApi(invalidConfig);

            bankAccountWritable = new BankAccountWritable(
                "Test Bank Account", // description
                "322271627", // routingNumber
                "123456789", // accountNumber
                BankTypeEnum.Individual, // accountType
                "Sinead Connor", // signatory
                null // metadata
            );

            List<int> amounts = new List<int>();
            amounts.Add(11);
            amounts.Add(35);

            verification = new BankAccountVerify(amounts);

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            idsToDelete.ForEach(id => validApi.BankAccountDelete(id));
        }

        [Test]
        public void BankAccountCreateTest() {
            BankAccount response = validApi.BankAccountCreate(bankAccountWritable);

            Assert.NotNull(response.Id);
            idsToDelete.Add(response.Id);
            Assert.AreEqual(response.RoutingNumber, bankAccountWritable.RoutingNumber);
        }

        [Test]
        public void BankAccountCreateTestBadParameter() {
            try {
                BankAccount response = validApi.BankAccountCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'bankAccountWritable'"));
            }
        }

        [Test]
        public void BankAccountCreateTestBadUsername() {
            try {
                BankAccount response = invalidApi.BankAccountCreate(bankAccountWritable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BankAccountVerifyTest() {
            BankAccount bankAccount = validApi.BankAccountCreate(bankAccountWritable);
            idsToDelete.Add(bankAccount.Id);
            BankAccount response = validApi.BankAccountVerify(bankAccount.Id, verification);

            Assert.NotNull(response);
            Assert.AreEqual(response.Id, bankAccount.Id);
            Assert.True(response.Verified);
        }

        [Test]
        public void BankAccountVerifyTestBadParameter() {
            try {
                BankAccount response = validApi.BankAccountVerify(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'bankId'"));
            }
        }

        [Test]
        public void BankAccountVerifyTestBadUsername() {
            BankAccount bankAccount = validApi.BankAccountCreate(bankAccountWritable);
            idsToDelete.Add(bankAccount.Id);
            try {
                BankAccount response = invalidApi.BankAccountVerify(bankAccount.Id, verification);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BankAccountRetrieveTest() {
            BankAccount bankAccount = validApi.BankAccountCreate(bankAccountWritable);
            idsToDelete.Add(bankAccount.Id);
            BankAccount response = validApi.BankAccountRetrieve(bankAccount.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, bankAccount.Id);
        }

        [Test]
        public void BankAccountRetrieveTestBadParameter() {
            try {
                BankAccount response = validApi.BankAccountRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'bankId'"));
            }
        }

        [Test]
        public void BankAccountRetrieveTestBadUsername() {
            BankAccount bankAccount = validApi.BankAccountCreate(bankAccountWritable);
            idsToDelete.Add(bankAccount.Id);
            try {
                BankAccount response = invalidApi.BankAccountRetrieve(bankAccount.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BankAccountListTest() {
            BankAccountList response = validApi.BankAccountsList(null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BankAccountListTestWithLimitParameter() {
            int limit = 2;
            BankAccountList response = validApi.BankAccountsList(limit, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void BankAccountListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            BankAccountList response = validApi.BankAccountsList(null, null, null, includeList, null, null);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        [Test]
        public void BankAccountListTestWithDateCreatedParameter() {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            BankAccountList response = validApi.BankAccountsList(null, null, null, null, dateCreated, null);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BankAccountListTestWithMetadataParameter() {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            BankAccountList response = validApi.BankAccountsList(null, null, null, null, null, metadata);
            Assert.Greater(response.Count, 0);
        }
    }
}