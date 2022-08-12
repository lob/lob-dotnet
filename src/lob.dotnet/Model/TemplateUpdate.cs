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
    /// TemplateUpdate
    /// </summary>
    [DataContract(Name = "template_update")]
    public partial class TemplateUpdate : IEquatable<TemplateUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdate" /> class.
        /// </summary>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="publishedVersion">Unique identifier prefixed with &#x60;vrsn_&#x60;..</param>
        public TemplateUpdate(string description = default(string), string publishedVersion = default(string))
        {
            this.Description = description;
            this.PublishedVersion = publishedVersion;
        }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier prefixed with &#x60;vrsn_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;vrsn_&#x60;.</value>
        [DataMember(Name = "published_version", EmitDefaultValue = false)]
        public string PublishedVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
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
            return this.Equals(input as TemplateUpdate);
        }

        /// <summary>
        /// Returns true if TemplateUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PublishedVersion == input.PublishedVersion ||
                    (this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(input.PublishedVersion))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PublishedVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedVersion.GetHashCode();
                }
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // PublishedVersion (string) pattern
            Regex regexPublishedVersion = new Regex(@"^vrsn_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexPublishedVersion.Match(this.PublishedVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublishedVersion, must match a pattern of " + regexPublishedVersion, new [] { "PublishedVersion" });
            }

            yield break;
        }
    }

}
