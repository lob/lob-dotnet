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
    /// A nested custom envelope object containing more information about the custom envelope used or &#x60;null&#x60; if a custom envelope was not used.  Accepts an envelope ID for any customized envelope with available inventory. If no inventory is available for the specified ID, the letter will not be sent, and an error will be returned. If the letter has more than 6 sheets, it will be sent in a blank flat envelope. Custom envelopes may be created and ordered from the dashboard. This feature is exclusive to certain customers. Upgrade to the appropriate [Print &amp; Mail Edition](https://dashboard.lob.com/#/settings/editions) to gain access.
    /// </summary>
    [DataContract(Name = "letter_editable_custom_envelope")]
    public partial class LetterEditableCustomEnvelope : IEquatable<LetterEditableCustomEnvelope>, IValidatableObject
    {
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Envelope for value: envelope
            /// </summary>
            [EnumMember(Value = "envelope")]
            Envelope = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public ObjectEnum Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterEditableCustomEnvelope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LetterEditableCustomEnvelope() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterEditableCustomEnvelope" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the custom envelope used. (required).</param>
        /// <param name="url">The url of the envelope asset used. (required).</param>
        /// <param name="_object">_object (required) (default to ObjectEnum.Envelope).</param>
        public LetterEditableCustomEnvelope(string id = default(string), string url = default(string), ObjectEnum _object = ObjectEnum.Envelope)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LetterEditableCustomEnvelope and cannot be null");
            }
            this.Id = id;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for LetterEditableCustomEnvelope and cannot be null");
            }
            this.Url = url;
            this.Object = _object;
        }

        /// <summary>
        /// The unique identifier of the custom envelope used.
        /// </summary>
        /// <value>The unique identifier of the custom envelope used.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The url of the envelope asset used.
        /// </summary>
        /// <value>The url of the envelope asset used.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LetterEditableCustomEnvelope {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as LetterEditableCustomEnvelope);
        }

        /// <summary>
        /// Returns true if LetterEditableCustomEnvelope instances are equal
        /// </summary>
        /// <param name="input">Instance of LetterEditableCustomEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LetterEditableCustomEnvelope input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 40.", new [] { "Id" });
            }

            yield break;
        }
    }

}
