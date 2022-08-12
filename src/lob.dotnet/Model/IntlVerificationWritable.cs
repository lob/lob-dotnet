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
    /// IntlVerificationWritable
    /// </summary>
    [DataContract(Name = "intl_verification_writable")]
    public partial class IntlVerificationWritable : IEquatable<IntlVerificationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerificationWritable" /> class.
        /// </summary>
        /// <param name="recipient">The intended recipient, typically a person&#39;s or firm&#39;s name..</param>
        /// <param name="primaryLine">The primary delivery line (usually the street address) of the address. .</param>
        /// <param name="secondaryLine">The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. .</param>
        /// <param name="city">city.</param>
        /// <param name="state">The name of the state..</param>
        /// <param name="postalCode">The postal code..</param>
        /// <param name="country">country.</param>
        /// <param name="address">The entire address in one string (e.g., \&quot;370 Water St C1N 1C4\&quot;). .</param>
        public IntlVerificationWritable(string recipient = default(string), string primaryLine = default(string), string secondaryLine = default(string), string city = default(string), string state = default(string), string postalCode = default(string), CountryExtended country = default(CountryExtended), string address = default(string))
        {
            this.Recipient = recipient;
            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Address = address;
        }

        /// <summary>
        /// The intended recipient, typically a person&#39;s or firm&#39;s name.
        /// </summary>
        /// <value>The intended recipient, typically a person&#39;s or firm&#39;s name.</value>
        [DataMember(Name = "recipient", EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address. 
        /// </summary>
        /// <value>The primary delivery line (usually the street address) of the address. </value>
        [DataMember(Name = "primary_line", EmitDefaultValue = false)]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. 
        /// </summary>
        /// <value>The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. </value>
        [DataMember(Name = "secondary_line", EmitDefaultValue = false)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The name of the state.
        /// </summary>
        /// <value>The name of the state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public CountryExtended Country { get; set; }

        /// <summary>
        /// The entire address in one string (e.g., \&quot;370 Water St C1N 1C4\&quot;). 
        /// </summary>
        /// <value>The entire address in one string (e.g., \&quot;370 Water St C1N 1C4\&quot;). </value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntlVerificationWritable {\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  PrimaryLine: ").Append(PrimaryLine).Append("\n");
            sb.Append("  SecondaryLine: ").Append(SecondaryLine).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as IntlVerificationWritable);
        }

        /// <summary>
        /// Returns true if IntlVerificationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of IntlVerificationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntlVerificationWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
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

            // City (string) maxLength
            if (this.City != null && this.City.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 200.", new [] { "City" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 12.", new [] { "PostalCode" });
            }

            // Address (string) maxLength
            if (this.Address != null && this.Address.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 500.", new [] { "Address" });
            }

            yield break;
        }
    }

}
