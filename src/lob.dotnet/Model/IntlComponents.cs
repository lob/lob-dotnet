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
    /// A nested object containing a breakdown of each component of an address.
    /// </summary>
    [DataContract(Name = "intl_components")]
    public partial class IntlComponents : IEquatable<IntlComponents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlComponents" /> class.
        /// </summary>
        /// <param name="primaryNumber">The numeric or alphanumeric part of an address preceding the street name. Often the house, building, or PO Box number..</param>
        /// <param name="streetName">The name of the street..</param>
        /// <param name="city">city.</param>
        /// <param name="state">The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. .</param>
        /// <param name="postalCode">The postal code..</param>
        public IntlComponents(string primaryNumber = default(string), string streetName = default(string), string city = default(string), string state = default(string), string postalCode = default(string))
        {
            this.PrimaryNumber = primaryNumber;
            this.StreetName = streetName;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// The numeric or alphanumeric part of an address preceding the street name. Often the house, building, or PO Box number.
        /// </summary>
        /// <value>The numeric or alphanumeric part of an address preceding the street name. Often the house, building, or PO Box number.</value>
        [DataMember(Name = "primary_number", EmitDefaultValue = false)]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// The name of the street.
        /// </summary>
        /// <value>The name of the street.</value>
        [DataMember(Name = "street_name", EmitDefaultValue = false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. 
        /// </summary>
        /// <value>The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. </value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntlComponents {\n");
            sb.Append("  PrimaryNumber: ").Append(PrimaryNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as IntlComponents);
        }

        /// <summary>
        /// Returns true if IntlComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of IntlComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntlComponents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryNumber == input.PrimaryNumber ||
                    (this.PrimaryNumber != null &&
                    this.PrimaryNumber.Equals(input.PrimaryNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
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
                if (this.PrimaryNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryNumber.GetHashCode();
                }
                if (this.StreetName != null)
                {
                    hashCode = (hashCode * 59) + this.StreetName.GetHashCode();
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
            // City (string) maxLength
            if (this.City != null && this.City.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 200.", new [] { "City" });
            }

            // State (string) maxLength
            if (this.State != null && this.State.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 2.", new [] { "State" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 12.", new [] { "PostalCode" });
            }

            yield break;
        }
    }

}
