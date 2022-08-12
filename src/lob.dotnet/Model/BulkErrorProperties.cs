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
    /// Bulk error properties
    /// </summary>
    [DataContract(Name = "bulk_error_properties")]
    public partial class BulkErrorProperties : IEquatable<BulkErrorProperties>, IValidatableObject
    {
        /// <summary>
        /// A conventional HTTP status code.
        /// </summary>
        /// <value>A conventional HTTP status code.</value>
        public enum StatusCodeEnum
        {
            /// <summary>
            /// Enum NUMBER_401 for value: 401
            /// </summary>
            NUMBER_401 = 401,
            

            /// <summary>
            /// Enum NUMBER_403 for value: 403
            /// </summary>
            NUMBER_403 = 403,
            

            /// <summary>
            /// Enum NUMBER_404 for value: 404
            /// </summary>
            NUMBER_404 = 404,
            

            /// <summary>
            /// Enum NUMBER_413 for value: 413
            /// </summary>
            NUMBER_413 = 413,
            

            /// <summary>
            /// Enum NUMBER_422 for value: 422
            /// </summary>
            NUMBER_422 = 422,
            

            /// <summary>
            /// Enum NUMBER_429 for value: 429
            /// </summary>
            NUMBER_429 = 429,
            

            /// <summary>
            /// Enum NUMBER_500 for value: 500
            /// </summary>
            NUMBER_500 = 500
            

        }


        /// <summary>
        /// A conventional HTTP status code.
        /// </summary>
        /// <value>A conventional HTTP status code.</value>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public StatusCodeEnum? StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkErrorProperties" /> class.
        /// </summary>
        /// <param name="message">A human-readable message with more details about the error.</param>
        /// <param name="statusCode">A conventional HTTP status code..</param>
        public BulkErrorProperties(string message = default(string), StatusCodeEnum? statusCode = default(StatusCodeEnum?))
        {
            this.Message = message;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// A human-readable message with more details about the error
        /// </summary>
        /// <value>A human-readable message with more details about the error</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkErrorProperties {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BulkErrorProperties);
        }

        /// <summary>
        /// Returns true if BulkErrorProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkErrorProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkErrorProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
