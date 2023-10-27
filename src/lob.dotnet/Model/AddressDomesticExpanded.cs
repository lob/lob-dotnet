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
    /// AddressDomesticExpanded
    /// </summary>
    [DataContract(Name = "address_domestic_expanded")]
    public partial class AddressDomesticExpanded : IEquatable<AddressDomesticExpanded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDomesticExpanded" /> class.
        /// </summary>
        /// <param name="addressLine1">The building number, street name, street suffix, and any street directionals. For US addresses, the max length is 64 characters..</param>
        /// <param name="addressLine2">The suite or apartment number of the recipient address, if applicable. For US addresses, the max length is 64 characters..</param>
        /// <param name="addressCity">addressCity.</param>
        /// <param name="addressState">addressState.</param>
        /// <param name="addressZip">Optional postal code. For US addresses, must be either 5 or 9 digits..</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="name">Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. Must be no longer than 40 characters. If both &#x60;name&#x60; and &#x60;company&#x60; are provided, they will be printed on two separate lines above the rest of the address. .</param>
        /// <param name="company">Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both..</param>
        /// <param name="phone">Must be no longer than 40 characters..</param>
        /// <param name="email">Must be no longer than 100 characters..</param>
        /// <param name="addressCountry">The country associated with this address..</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        public AddressDomesticExpanded(string addressLine1 = default(string), string addressLine2 = default(string), string addressCity = default(string), string addressState = default(string), string addressZip = default(string), string description = default(string), string name = default(string), string company = default(string), string phone = default(string), string email = default(string), string addressCountry = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressZip = addressZip;
            this.Description = description;
            this.Name = name;
            this.Company = company;
            this.Phone = phone;
            this.Email = email;
            this.AddressCountry = addressCountry;
            this.Metadata = metadata;
        }

        /// <summary>
        /// The building number, street name, street suffix, and any street directionals. For US addresses, the max length is 64 characters.
        /// </summary>
        /// <value>The building number, street name, street suffix, and any street directionals. For US addresses, the max length is 64 characters.</value>
        [DataMember(Name = "address_line1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The suite or apartment number of the recipient address, if applicable. For US addresses, the max length is 64 characters.
        /// </summary>
        /// <value>The suite or apartment number of the recipient address, if applicable. For US addresses, the max length is 64 characters.</value>
        [DataMember(Name = "address_line2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name = "address_city", EmitDefaultValue = false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Gets or Sets AddressState
        /// </summary>
        [DataMember(Name = "address_state", EmitDefaultValue = false)]
        public string AddressState { get; set; }

        /// <summary>
        /// Optional postal code. For US addresses, must be either 5 or 9 digits.
        /// </summary>
        /// <value>Optional postal code. For US addresses, must be either 5 or 9 digits.</value>
        [DataMember(Name = "address_zip", EmitDefaultValue = false)]
        public string AddressZip { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. Must be no longer than 40 characters. If both &#x60;name&#x60; and &#x60;company&#x60; are provided, they will be printed on two separate lines above the rest of the address. 
        /// </summary>
        /// <value>Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. Must be no longer than 40 characters. If both &#x60;name&#x60; and &#x60;company&#x60; are provided, they will be printed on two separate lines above the rest of the address. </value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both.
        /// </summary>
        /// <value>Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both.</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// Must be no longer than 40 characters.
        /// </summary>
        /// <value>Must be no longer than 40 characters.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Must be no longer than 100 characters.
        /// </summary>
        /// <value>Must be no longer than 100 characters.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The country associated with this address.
        /// </summary>
        /// <value>The country associated with this address.</value>
        [DataMember(Name = "address_country", EmitDefaultValue = false)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressDomesticExpanded {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as AddressDomesticExpanded);
        }

        /// <summary>
        /// Returns true if AddressDomesticExpanded instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressDomesticExpanded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressDomesticExpanded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressState == input.AddressState ||
                    (this.AddressState != null &&
                    this.AddressState.Equals(input.AddressState))
                ) && 
                (
                    this.AddressZip == input.AddressZip ||
                    (this.AddressZip != null &&
                    this.AddressZip.Equals(input.AddressZip))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.AddressCountry == input.AddressCountry ||
                    (this.AddressCountry != null &&
                    this.AddressCountry.Equals(input.AddressCountry))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.AddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine1.GetHashCode();
                }
                if (this.AddressLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine2.GetHashCode();
                }
                if (this.AddressCity != null)
                {
                    hashCode = (hashCode * 59) + this.AddressCity.GetHashCode();
                }
                if (this.AddressState != null)
                {
                    hashCode = (hashCode * 59) + this.AddressState.GetHashCode();
                }
                if (this.AddressZip != null)
                {
                    hashCode = (hashCode * 59) + this.AddressZip.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.AddressCountry != null)
                {
                    hashCode = (hashCode * 59) + this.AddressCountry.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
            // AddressLine1 (string) maxLength
            if (this.AddressLine1 != null && this.AddressLine1.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 200.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if (this.AddressLine2 != null && this.AddressLine2.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 200.", new [] { "AddressLine2" });
            }

            // AddressCity (string) maxLength
            if (this.AddressCity != null && this.AddressCity.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressCity, length must be less than 200.", new [] { "AddressCity" });
            }

            // AddressState (string) maxLength
            if (this.AddressState != null && this.AddressState.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressState, length must be less than 200.", new [] { "AddressState" });
            }

            // AddressZip (string) maxLength
            if (this.AddressZip != null && this.AddressZip.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressZip, length must be less than 40.", new [] { "AddressZip" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
            }

            // Company (string) maxLength
            if (this.Company != null && this.Company.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Company, length must be less than 40.", new [] { "Company" });
            }

            // Phone (string) maxLength
            if (this.Phone != null && this.Phone.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 40.", new [] { "Phone" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 100.", new [] { "Email" });
            }

            // AddressCountry (string) pattern
            Regex regexAddressCountry = new Regex(@"UNITED STATES", RegexOptions.CultureInvariant);
            if (false == regexAddressCountry.Match(this.AddressCountry).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressCountry, must match a pattern of " + regexAddressCountry, new [] { "AddressCountry" });
            }

            yield break;
        }
    }

}
