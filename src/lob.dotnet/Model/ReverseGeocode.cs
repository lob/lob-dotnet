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
    /// ReverseGeocode
    /// </summary>
    [DataContract(Name = "reverse_geocode")]
    public partial class ReverseGeocode : IEquatable<ReverseGeocode>, IValidatableObject
    {
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum UsReverseGeocodeLookup for value: us_reverse_geocode_lookup
            /// </summary>
            [EnumMember(Value = "us_reverse_geocode_lookup")]
            UsReverseGeocodeLookup = 1
            

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocode" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;us_reverse_geocode_&#x60;..</param>
        /// <param name="addresses">list of addresses .</param>
        /// <param name="_object">Value is resource type. (default to ObjectEnum.UsReverseGeocodeLookup).</param>
        public ReverseGeocode(string id = default(string), List<GeocodeAddresses> addresses = default(List<GeocodeAddresses>), ObjectEnum? _object = ObjectEnum.UsReverseGeocodeLookup)
        {
            this.Id = id;
            this.Addresses = addresses;
            this.Object = _object;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;us_reverse_geocode_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;us_reverse_geocode_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// list of addresses 
        /// </summary>
        /// <value>list of addresses </value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<GeocodeAddresses> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseGeocode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
            return this.Equals(input as ReverseGeocode);
        }

        /// <summary>
        /// Returns true if ReverseGeocode instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseGeocode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseGeocode input)
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
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
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
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^us_reverse_geocode_[a-zA-Z0-9_]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
