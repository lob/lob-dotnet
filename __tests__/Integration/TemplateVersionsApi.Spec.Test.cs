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
    public class TemplateVersionsApiTests : IDisposable
    {
        private TemplateVersionsApi validApi;
        private TemplateVersionsApi invalidApi;
        private TemplatesApi templatesApi;
        private TemplateVersionWritable templateVersionWritable;
        private Template template;

        public TemplateVersionsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new TemplateVersionsApi(config);
            invalidApi = new TemplateVersionsApi(invalidConfig);

            templateVersionWritable = new TemplateVersionWritable(
                "C# templateVersions integration test description", // description
                "<html>Template Versions HTML</html>", // html
                EngineHtml.Legacy // engine
            );

            TemplateWritable templateWritable = new TemplateWritable(
                "C# templateVersions integration test description", // description
                "<html>{{name}}'s Template</html>", // html
                new Dictionary<string, string>(), // metadata
                EngineHtml.Legacy // engine
            );

            templateWritable.Metadata.Add("name", "Harry");
            templatesApi = new TemplatesApi(config);
            template = templatesApi.CreateTemplate(templateWritable);
        }

        public void Dispose()
        {
            templatesApi.TemplateDelete(template.Id);
        }

        [Test]
        public void CreateTemplateVersionTest() {
            TemplateVersion response = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Description, templateVersionWritable.Description);
        }

        [Test]
        public void CreateTemplateVersionTestBadParameter() {
            try {
                TemplateVersion response = validApi.CreateTemplateVersion(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void CreateTemplateVersionTestBadUsername() {
            try {
                TemplateVersion response = invalidApi.CreateTemplateVersion(template.Id, templateVersionWritable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateVersionUpdateTest() {
            TemplateVersion ogTemplateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);
            TemplateVersionUpdatable updatedTmplVrsn = new TemplateVersionUpdatable("C# integration test Updated templateVersion description", EngineHtml.Handlebars);

            TemplateVersion response = validApi.TemplateVersionUpdate(template.Id, ogTemplateVersion.Id, updatedTmplVrsn);

            Assert.NotNull(response);
            Assert.AreEqual(updatedTmplVrsn.Description, response.Description);
        }

        [Test]
        public void TemplateVersionUpdateTestBadParameter() {
            try {
                TemplateVersion response = validApi.TemplateVersionUpdate(null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateVersionUpdateTestBadUsername() {
            TemplateVersion ogTemplateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            TemplateVersionUpdatable updatedTmplVrsn = new TemplateVersionUpdatable("C# integration test Updated templateVersion description", EngineHtml.Handlebars);

            try {
                TemplateVersion response = invalidApi.TemplateVersionUpdate(template.Id, ogTemplateVersion.Id, updatedTmplVrsn);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateVersionRetrieveTest() {
            TemplateVersion templateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            TemplateVersion response = validApi.TemplateVersionRetrieve(template.Id, templateVersion.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, templateVersion.Id);
        }

        [Test]
        public void TemplateVersionRetrieveTestBadParameter() {
            try {
                TemplateVersion response = validApi.TemplateVersionRetrieve(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateVersionRetrieveTestBadUsername() {
            TemplateVersion templateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            try {
                TemplateVersion response = invalidApi.TemplateVersionRetrieve(template.Id, templateVersion.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateVersionListTest() {
            TemplateVersionList response = validApi.TemplateVersionsList(template.Id, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void TemplateVersionListTestWithLimitParameter() {
            int limit = 2;
            TemplateVersionList response = validApi.TemplateVersionsList(template.Id, limit, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void TemplateVersionListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            TemplateVersionList response = validApi.TemplateVersionsList(template.Id, null, null, null, includeList, null);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        // /* TODO: fix unpacking dictionaries into query params
        // [Test]
        // public void TemplateVersionListTestWithDateCreatedParameter() {
        //     Dictionary<String, String> dateCreated = new Dictionary<String, String>();
        //     dateCreated.Add("gt", "2020-01-01");
        //     dateCreated.Add("lt", "2020-01-31T12");

        //     TemplateVersionList response = validApi.TemplateVersionsList(template.Id, null, null, null, null, dateCreated);
        //     Console.WriteLine(response);
        //     Assert.Greater(response.Count, 0);
        // } */

        [Test]
        public void TemplateVersionListTestBadParameter() {
            try {
                TemplateVersionList response = validApi.TemplateVersionsList(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateVersionListTestBadUsername() {
            TemplateVersion templateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            try {
                TemplateVersionList response = invalidApi.TemplateVersionsList(template.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void TemplateVersionDeleteTest() {
            TemplateVersion templateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);
            TemplateVersionDeletion response = validApi.TemplateVersionDelete(template.Id, templateVersion.Id);

            Assert.NotNull(response);
            Assert.True(response.Deleted);
        }

        [Test]
        public void TemplateVersionDeleteTestBadParameter() {
            try {
                TemplateVersionDeletion response = validApi.TemplateVersionDelete(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'tmplId'"));
            }
        }

        [Test]
        public void TemplateVersionDeleteTestBadUsername() {
            TemplateVersion templateVersion = validApi.CreateTemplateVersion(template.Id, templateVersionWritable);

            try {
                TemplateVersionDeletion response = invalidApi.TemplateVersionDelete(template.Id, templateVersion.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }
    }
}