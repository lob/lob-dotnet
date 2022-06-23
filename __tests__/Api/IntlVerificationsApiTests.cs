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
using NUnit.Framework;

using lob.dotnet.Client;
using lob.dotnet.Api;
// uncomment below to import models
//using lob.dotnet.Model;

namespace __tests__.Api
{
    /// <summary>
    ///  Class for testing IntlVerificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IntlVerificationsApiTests : IDisposable
    {
        private IntlVerificationsApi instance;

        public IntlVerificationsApiTests()
        {
            instance = new IntlVerificationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IntlVerificationsApi
        /// </summary>
        [Ignore("TODO")]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IntlVerificationsApi
            //Assert.IsType<IntlVerificationsApi>(instance);
        }

        /// <summary>
        /// Test BulkIntlVerifications
        /// </summary>
        [Ignore("TODO")]
        public void BulkIntlVerificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IntlVerificationsPayload intlVerificationsPayload = null;
            //var response = instance.BulkIntlVerifications(intlVerificationsPayload);
            //Assert.IsType<IntlVerifications>(response);
        }

        /// <summary>
        /// Test IntlVerification
        /// </summary>
        [Ignore("TODO")]
        public void IntlVerificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IntlVerificationWritable intlVerificationWritable = null;
            //string xLangOutput = null;
            //var response = instance.IntlVerification(intlVerificationWritable, xLangOutput);
            //Assert.IsType<IntlVerification>(response);
        }
    }
}