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
    /// A model used to represent an entry in a result list where the entry can either be a intl_verification or an Error. The SDK will perform necessary casting into the correct corresponding type. 
    /// </summary>
    [DataContract(Name = "intl_verification_or_error")]
    public partial class IntlVerificationOrError : IEquatable<IntlVerificationOrError>, IValidatableObject
    {
        /// <summary>
        /// Defines Coverage
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CoverageEnum
        {
            /// <summary>
            /// Enum SUBBUILDING for value: SUBBUILDING
            /// </summary>
            [EnumMember(Value = "SUBBUILDING")]
            SUBBUILDING = 1,
            

            /// <summary>
            /// Enum HOUSENUMBERBUILDING for value: HOUSENUMBER/BUILDING
            /// </summary>
            [EnumMember(Value = "HOUSENUMBER/BUILDING")]
            HOUSENUMBERBUILDING = 2,
            

            /// <summary>
            /// Enum STREET for value: STREET
            /// </summary>
            [EnumMember(Value = "STREET")]
            STREET = 3,
            

            /// <summary>
            /// Enum LOCALITY for value: LOCALITY
            /// </summary>
            [EnumMember(Value = "LOCALITY")]
            LOCALITY = 4,
            

            /// <summary>
            /// Enum SPARSE for value: SPARSE
            /// </summary>
            [EnumMember(Value = "SPARSE")]
            SPARSE = 5
            

        }


        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [DataMember(Name = "coverage", EmitDefaultValue = false)]
        public CoverageEnum? Coverage { get; set; }
        /// <summary>
        /// Defines Deliverability
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliverabilityEnum
        {
            /// <summary>
            /// Enum Deliverable for value: deliverable
            /// </summary>
            [EnumMember(Value = "deliverable")]
            Deliverable = 1,
            

            /// <summary>
            /// Enum DeliverableMissingInfo for value: deliverable_missing_info
            /// </summary>
            [EnumMember(Value = "deliverable_missing_info")]
            DeliverableMissingInfo = 2,
            

            /// <summary>
            /// Enum Undeliverable for value: undeliverable
            /// </summary>
            [EnumMember(Value = "undeliverable")]
            Undeliverable = 3,
            

            /// <summary>
            /// Enum NoMatch for value: no_match
            /// </summary>
            [EnumMember(Value = "no_match")]
            NoMatch = 4
            

        }


        /// <summary>
        /// Gets or Sets Deliverability
        /// </summary>
        [DataMember(Name = "deliverability", EmitDefaultValue = false)]
        public DeliverabilityEnum? Deliverability { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum LV4 for value: LV4
            /// </summary>
            [EnumMember(Value = "LV4")]
            LV4 = 1,
            

            /// <summary>
            /// Enum LV3 for value: LV3
            /// </summary>
            [EnumMember(Value = "LV3")]
            LV3 = 2,
            

            /// <summary>
            /// Enum LV2 for value: LV2
            /// </summary>
            [EnumMember(Value = "LV2")]
            LV2 = 3,
            

            /// <summary>
            /// Enum LV1 for value: LV1
            /// </summary>
            [EnumMember(Value = "LV1")]
            LV1 = 4,
            

            /// <summary>
            /// Enum LF4 for value: LF4
            /// </summary>
            [EnumMember(Value = "LF4")]
            LF4 = 5,
            

            /// <summary>
            /// Enum LF3 for value: LF3
            /// </summary>
            [EnumMember(Value = "LF3")]
            LF3 = 6,
            

            /// <summary>
            /// Enum LF2 for value: LF2
            /// </summary>
            [EnumMember(Value = "LF2")]
            LF2 = 7,
            

            /// <summary>
            /// Enum LF1 for value: LF1
            /// </summary>
            [EnumMember(Value = "LF1")]
            LF1 = 8,
            

            /// <summary>
            /// Enum LM4 for value: LM4
            /// </summary>
            [EnumMember(Value = "LM4")]
            LM4 = 9,
            

            /// <summary>
            /// Enum LM3 for value: LM3
            /// </summary>
            [EnumMember(Value = "LM3")]
            LM3 = 10,
            

            /// <summary>
            /// Enum LM2 for value: LM2
            /// </summary>
            [EnumMember(Value = "LM2")]
            LM2 = 11,
            

            /// <summary>
            /// Enum LU1 for value: LU1
            /// </summary>
            [EnumMember(Value = "LU1")]
            LU1 = 12
            

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum IntlVerification for value: intl_verification
            /// </summary>
            [EnumMember(Value = "intl_verification")]
            IntlVerification = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerificationOrError" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;intl_ver_&#x60;..</param>
        /// <param name="recipient">The intended recipient, typically a person&#39;s or firm&#39;s name..</param>
        /// <param name="primaryLine">primaryLine.</param>
        /// <param name="secondaryLine">The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. .</param>
        /// <param name="lastLine">lastLine.</param>
        /// <param name="country">country.</param>
        /// <param name="coverage">coverage.</param>
        /// <param name="deliverability">deliverability.</param>
        /// <param name="status">status.</param>
        /// <param name="components">components.</param>
        /// <param name="_object">_object (default to ObjectEnum.IntlVerification).</param>
        /// <param name="error">error.</param>
        public IntlVerificationOrError(string id = default(string), string recipient = default(string), string primaryLine = default(string), string secondaryLine = default(string), string lastLine = default(string), string country = default(string), CoverageEnum? coverage = default(CoverageEnum?), DeliverabilityEnum? deliverability = default(DeliverabilityEnum?), StatusEnum? status = default(StatusEnum?), IntlComponents components = default(IntlComponents), ObjectEnum? _object = ObjectEnum.IntlVerification, BulkError error = default(BulkError))
        {
            this.Id = id;
            this.Recipient = recipient;
            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.LastLine = lastLine;
            this.Country = country;
            this.Coverage = coverage;
            this.Deliverability = deliverability;
            this.Status = status;
            this.Components = components;
            this.Object = _object;
            this.Error = error;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;intl_ver_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;intl_ver_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The intended recipient, typically a person&#39;s or firm&#39;s name.
        /// </summary>
        /// <value>The intended recipient, typically a person&#39;s or firm&#39;s name.</value>
        [DataMember(Name = "recipient", EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryLine
        /// </summary>
        [DataMember(Name = "primary_line", EmitDefaultValue = false)]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. 
        /// </summary>
        /// <value>The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. </value>
        [DataMember(Name = "secondary_line", EmitDefaultValue = false)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// Gets or Sets LastLine
        /// </summary>
        [DataMember(Name = "last_line", EmitDefaultValue = false)]
        public string LastLine { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        public IntlComponents Components { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public BulkError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntlVerificationOrError {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  PrimaryLine: ").Append(PrimaryLine).Append("\n");
            sb.Append("  SecondaryLine: ").Append(SecondaryLine).Append("\n");
            sb.Append("  LastLine: ").Append(LastLine).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  Deliverability: ").Append(Deliverability).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as IntlVerificationOrError);
        }

        /// <summary>
        /// Returns true if IntlVerificationOrError instances are equal
        /// </summary>
        /// <param name="input">Instance of IntlVerificationOrError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntlVerificationOrError input)
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
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.PrimaryLine == input.PrimaryLine ||
                    (this.PrimaryLine != null &&
                    this.PrimaryLine.Equals(input.PrimaryLine))
                ) && 
                (
                    this.SecondaryLine == input.SecondaryLine ||
                    (this.SecondaryLine != null &&
                    this.SecondaryLine.Equals(input.SecondaryLine))
                ) && 
                (
                    this.LastLine == input.LastLine ||
                    (this.LastLine != null &&
                    this.LastLine.Equals(input.LastLine))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Coverage == input.Coverage ||
                    this.Coverage.Equals(input.Coverage)
                ) && 
                (
                    this.Deliverability == input.Deliverability ||
                    this.Deliverability.Equals(input.Deliverability)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Components == input.Components ||
                    (this.Components != null &&
                    this.Components.Equals(input.Components))
                ) && 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.PrimaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryLine.GetHashCode();
                }
                if (this.SecondaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryLine.GetHashCode();
                }
                if (this.LastLine != null)
                {
                    hashCode = (hashCode * 59) + this.LastLine.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Coverage.GetHashCode();
                hashCode = (hashCode * 59) + this.Deliverability.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^intl_ver_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // Recipient (string) maxLength
            if (this.Recipient != null && this.Recipient.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be less than 500.", new [] { "Recipient" });
            }

            // PrimaryLine (string) maxLength
            if (this.PrimaryLine != null && this.PrimaryLine.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrimaryLine, length must be less than 200.", new [] { "PrimaryLine" });
            }

            // SecondaryLine (string) maxLength
            if (this.SecondaryLine != null && this.SecondaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondaryLine, length must be less than 500.", new [] { "SecondaryLine" });
            }

            yield break;
        }
    }

}
