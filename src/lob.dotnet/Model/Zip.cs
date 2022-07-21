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
    /// Zip
    /// </summary>
    [DataContract(Name = "zip")]
    public partial class Zip : IEquatable<Zip>, IValidatableObject
    {
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum UsZipLookup for value: us_zip_lookup
            /// </summary>
            [EnumMember(Value = "us_zip_lookup")]
            UsZipLookup = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public ObjectEnum Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Zip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Zip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Zip" /> class.
        /// </summary>
        /// <param name="zipCode">A 5-digit ZIP code..</param>
        /// <param name="id">Unique identifier prefixed with &#x60;us_zip_&#x60;. (required).</param>
        /// <param name="cities">An array of city objects containing valid cities for the &#x60;zip_code&#x60;. Multiple cities will be returned if more than one city is associated with the input ZIP code.  (required).</param>
        /// <param name="zipCodeType">zipCodeType (required).</param>
        /// <param name="_object">_object (required) (default to ObjectEnum.UsZipLookup).</param>
        public Zip(string zipCode = default(string), string id = default(string), List<ZipLookupCity> cities = default(List<ZipLookupCity>), ZipCodeType zipCodeType = default(ZipCodeType), ObjectEnum _object = ObjectEnum.UsZipLookup)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Zip and cannot be null");
            }
            this.Id = id;
            // to ensure "cities" is required (not null)
            if (cities == null)
            {
                throw new ArgumentNullException("cities is a required property for Zip and cannot be null");
            }
            this.Cities = cities;
            // to ensure "zipCodeType" is required (not null)
            if (zipCodeType == null)
            {
                throw new ArgumentNullException("zipCodeType is a required property for Zip and cannot be null");
            }
            this.ZipCodeType = zipCodeType;
            this.Object = _object;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// A 5-digit ZIP code.
        /// </summary>
        /// <value>A 5-digit ZIP code.</value>
        [DataMember(Name = "zip_code", EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Unique identifier prefixed with &#x60;us_zip_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;us_zip_&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An array of city objects containing valid cities for the &#x60;zip_code&#x60;. Multiple cities will be returned if more than one city is associated with the input ZIP code. 
        /// </summary>
        /// <value>An array of city objects containing valid cities for the &#x60;zip_code&#x60;. Multiple cities will be returned if more than one city is associated with the input ZIP code. </value>
        [DataMember(Name = "cities", IsRequired = true, EmitDefaultValue = false)]
        public List<ZipLookupCity> Cities { get; set; }

        /// <summary>
        /// Gets or Sets ZipCodeType
        /// </summary>
        [DataMember(Name = "zip_code_type", IsRequired = true, EmitDefaultValue = false)]
        public ZipCodeType ZipCodeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Zip {\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cities: ").Append(Cities).Append("\n");
            sb.Append("  ZipCodeType: ").Append(ZipCodeType).Append("\n");
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
            return this.Equals(input as Zip);
        }

        /// <summary>
        /// Returns true if Zip instances are equal
        /// </summary>
        /// <param name="input">Instance of Zip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zip input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Cities == input.Cities ||
                    this.Cities != null &&
                    input.Cities != null &&
                    this.Cities.SequenceEqual(input.Cities)
                ) && 
                (
                    this.ZipCodeType == input.ZipCodeType ||
                    (this.ZipCodeType != null &&
                    this.ZipCodeType.Equals(input.ZipCodeType))
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
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Cities != null)
                {
                    hashCode = (hashCode * 59) + this.Cities.GetHashCode();
                }
                if (this.ZipCodeType != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCodeType.GetHashCode();
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
            // ZipCode (string) pattern
            Regex regexZipCode = new Regex(@"^\\d{5}$", RegexOptions.CultureInvariant);
            if (false == regexZipCode.Match(this.ZipCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipCode, must match a pattern of " + regexZipCode, new [] { "ZipCode" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^us_zip_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
