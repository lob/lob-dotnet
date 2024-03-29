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
    /// A description of the ZIP code type. For more detailed information about each ZIP code type, see [US Verification Details](#tag/US-Verification-Types). 
    /// </summary>
    /// <value>A description of the ZIP code type. For more detailed information about each ZIP code type, see [US Verification Details](#tag/US-Verification-Types). </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ZipCodeType
    {
        /// <summary>
        /// Enum Standard for value: standard
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard = 1,

        /// <summary>
        /// Enum PoBox for value: po_box
        /// </summary>
        [EnumMember(Value = "po_box")]
        PoBox = 2,

        /// <summary>
        /// Enum Unique for value: unique
        /// </summary>
        [EnumMember(Value = "unique")]
        Unique = 3,

        /// <summary>
        /// Enum Military for value: military
        /// </summary>
        [EnumMember(Value = "military")]
        Military = 4,

        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        [EnumMember(Value = "")]
        Empty = 5

    }

}
