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
    /// The list of column headers in your file as an array that you want as metadata associated with each mailpiece. See our &lt;a href&#x3D;\&quot;https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#required-columns-2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Campaign Audience Guide&lt;/a&gt; for additional details.
    /// </summary>
    [DataContract(Name = "uploads_metadata")]
    public partial class UploadsMetadata : IEquatable<UploadsMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadsMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsMetadata" /> class.
        /// </summary>
        /// <param name="columns">The list of column names from the csv file which you want associated with each of your mailpieces (required).</param>
        public UploadsMetadata(List<string> columns = default(List<string>))
        {
            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new ArgumentNullException("columns is a required property for UploadsMetadata and cannot be null");
            }
            this.Columns = columns;
        }

        /// <summary>
        /// The list of column names from the csv file which you want associated with each of your mailpieces
        /// </summary>
        /// <value>The list of column names from the csv file which you want associated with each of your mailpieces</value>
        [DataMember(Name = "columns", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Columns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadsMetadata {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadsMetadata);
        }

        /// <summary>
        /// Returns true if UploadsMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadsMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadsMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
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
                if (this.Columns != null)
                {
                    hashCode = (hashCode * 59) + this.Columns.GetHashCode();
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
            yield break;
        }
    }

}
