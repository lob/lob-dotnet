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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lob.dotnet.Client.OpenAPIDateConverter;

namespace lob.dotnet.Model
{
    /// <summary>
    /// The &#x60;state&#x60; property on the &#x60;upload&#x60; object. As the file is processed, the &#x60;state&#x60; will change from &#x60;Ready for Validation&#x60; to &#x60;Validating&#x60; and then will be either &#x60;Scheduled&#x60; (successfully processed) or &#x60;Errored&#x60; (Unsuccessfully processed).
    /// </summary>
    /// <value>The &#x60;state&#x60; property on the &#x60;upload&#x60; object. As the file is processed, the &#x60;state&#x60; will change from &#x60;Ready for Validation&#x60; to &#x60;Validating&#x60; and then will be either &#x60;Scheduled&#x60; (successfully processed) or &#x60;Errored&#x60; (Unsuccessfully processed).</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UploadState
    {
        /// <summary>
        /// Enum Preprocessing for value: Preprocessing
        /// </summary>
        [EnumMember(Value = "Preprocessing")]
        Preprocessing = 1,

        /// <summary>
        /// Enum Draft for value: Draft
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft = 2,

        /// <summary>
        /// Enum ReadyForValidation for value: Ready for Validation
        /// </summary>
        [EnumMember(Value = "Ready for Validation")]
        ReadyForValidation = 3,

        /// <summary>
        /// Enum Validating for value: Validating
        /// </summary>
        [EnumMember(Value = "Validating")]
        Validating = 4,

        /// <summary>
        /// Enum Scheduled for value: Scheduled
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled = 5,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 6,

        /// <summary>
        /// Enum Errored for value: Errored
        /// </summary>
        [EnumMember(Value = "Errored")]
        Errored = 7

    }

}