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
    public class TemplatesApiTests : IDisposable
    {
        private TemplatesApi validApi;
        private TemplatesApi invalidApi;
        private TemplateWritable templateWritable;
        private List<string> idsToDelete;

        public TemplatesApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new TemplatesApi(config);
            invalidApi = new TemplatesApi(invalidConfig);

            templateWritable = new TemplateWritable(
                "C# integration test description", // description
                "<html>Template to be updated with {{name}}</html>", // html
                new Dictionary<string, string>(), // metadata
                EngineHtml.Legacy // engine
            );

            templateWritable.Metadata.Add("name", "Harry");

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            idsToDelete.ForEach(id => validApi.TemplateDelete(id));
        }

        [Test]
        public void CreateTemplateTest() {
            Template response = validApi.CreateTemplate(templateWritable);

            Assert.NotNull(response.Id);
            idsToDelete.Add(response.Id);
            Assert.AreEqual(response.Description, templateWritable.Description);
        }

        [Test]
        public void CreateTemplateTestBadParameter() {
            try {
                Template response = validApi.CreateTemplate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'templateWritable'"));
            }
        }

        [Test]
        public void CreateTemplateTestBadUsername() {
            try {
                Template response = invalidApi.CreateTemplate(templateWritable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateUpdateTest() {
            Template ogTemplate = validApi.CreateTemplate(templateWritable);
            idsToDelete.Add(ogTemplate.Id);

            TemplateUpdate updatedTmpl = new TemplateUpdate("C# integration test Updated template description", ogTemplate.PublishedVersion.Id);
            Template response = validApi.TemplateUpdate(ogTemplate.Id, updatedTmpl);

            Assert.NotNull(response);
            Assert.AreEqual(updatedTmpl.Description, response.Description);
        }

        [Test]
        public void TemplateUpdateTestBadParameter() {
            try {
                Template response = validApi.TemplateUpdate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateUpdateTestBadUsername() {
            Template ogTemplate = validApi.CreateTemplate(templateWritable);
            idsToDelete.Add(ogTemplate.Id);

            TemplateUpdate updatedTmpl = new TemplateUpdate("C# integration test Updated template description", ogTemplate.PublishedVersion.Id);

            try {
                Template response = invalidApi.TemplateUpdate(ogTemplate.Id, updatedTmpl);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateRetrieveTest() {
            Template template = validApi.CreateTemplate(templateWritable);
            idsToDelete.Add(template.Id);

            Template response = validApi.TemplateRetrieve(template.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, template.Id);
        }

        [Test]
        public void TemplateRetrieveTestBadParameter() {
            try {
                Template response = validApi.TemplateRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateRetrieveTestBadUsername() {
            Template template = validApi.CreateTemplate(templateWritable);
            idsToDelete.Add(template.Id);

            try {
                Template response = invalidApi.TemplateRetrieve(template.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateListTest() {
            TemplateList response = validApi.TemplatesList(null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void TemplateListTestWithLimitParameter() {
            int limit = 2;
            TemplateList response = validApi.TemplatesList(limit, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void TemplateListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            TemplateList response = validApi.TemplatesList(null, null, null, includeList, null, null);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        /* TODO: fix unpacking dictionaries into query params
        [Test]
        public void TemplateListTestWithDateCreatedParameter() {
            Dictionary<String, String> dateCreated = new Dictionary<String, String>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            TemplateList response = validApi.TemplatesList(null, null, null, null, dateCreated, null);
            Console.WriteLine(response);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void TemplateListTestWithMetadataParameter() {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            TemplateList response = validApi.TemplatesList(null, null, null, null, null, metadata);
            Console.WriteLine(response);
            Assert.Greater(response.Count, 0);
        }
        */
    }
}