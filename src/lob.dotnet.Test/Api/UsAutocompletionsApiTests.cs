/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using lob.dotnet.Client;
using lob.dotnet.Api;
// uncomment below to import models
//using lob.dotnet.Model;

namespace lob.dotnet.Test.Api
{
    /// <summary>
    ///  Class for testing UsAutocompletionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsAutocompletionsApiTests : IDisposable
    {
        private UsAutocompletionsApi instance;

        public UsAutocompletionsApiTests()
        {
            instance = new UsAutocompletionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsAutocompletionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsAutocompletionsApi
            //Assert.IsType<UsAutocompletionsApi>(instance);
        }

        /// <summary>
        /// Test UsAutocompletion
        /// </summary>
        [Fact]
        public void UsAutocompletionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UsAutocompletionsWritable usAutocompletionsWritable = null;
            //var response = instance.UsAutocompletion(usAutocompletionsWritable);
            //Assert.IsType<UsAutocompletions>(response);
        }
    }
}
