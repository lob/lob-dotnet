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
    ///  Class for testing ChecksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChecksApiTests : IDisposable
    {
        private ChecksApi instance;

        public ChecksApiTests()
        {
            instance = new ChecksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChecksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ChecksApi
            //Assert.IsType<ChecksApi>(instance);
        }

        /// <summary>
        /// Test CheckCancel
        /// </summary>
        [Fact]
        public void CheckCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chkId = null;
            //var response = instance.CheckCancel(chkId);
            //Assert.IsType<CheckDeletion>(response);
        }

        /// <summary>
        /// Test CheckCreate
        /// </summary>
        [Fact]
        public void CheckCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckEditable checkEditable = null;
            //string idempotencyKey = null;
            //var response = instance.CheckCreate(checkEditable, idempotencyKey);
            //Assert.IsType<Check>(response);
        }

        /// <summary>
        /// Test CheckRetrieve
        /// </summary>
        [Fact]
        public void CheckRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chkId = null;
            //var response = instance.CheckRetrieve(chkId);
            //Assert.IsType<Check>(response);
        }

        /// <summary>
        /// Test ChecksList
        /// </summary>
        [Fact]
        public void ChecksListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string before = null;
            //string after = null;
            //List<string> include = null;
            //Dictionary<string, DateTime> dateCreated = null;
            //Dictionary<string, string> metadata = null;
            //bool? scheduled = null;
            //Dictionary<string, string> sendDate = null;
            //MailType? mailType = null;
            //SortBy5 sortBy = null;
            //var response = instance.ChecksList(limit, before, after, include, dateCreated, metadata, scheduled, sendDate, mailType, sortBy);
            //Assert.IsType<CheckList>(response);
        }
    }
}
