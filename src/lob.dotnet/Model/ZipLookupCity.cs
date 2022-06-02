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
    /// ZipLookupCity
    /// </summary>
    [DataContract(Name = "zip_lookup_city")]
    public partial class ZipLookupCity : IEquatable<ZipLookupCity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipLookupCity" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="state">The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. .</param>
        /// <param name="county">County name of the address city..</param>
        /// <param name="countyFips">A 5-digit [FIPS county code](https://en.wikipedia.org/wiki/FIPS_county_code) which uniquely identifies &#x60;components[county]&#x60;. It consists of a 2-digit state code and a 3-digit county code. .</param>
        /// <param name="preferred">Indicates whether or not the city is the [USPS default city](https://en.wikipedia.org/wiki/ZIP_Code#ZIP_Codes_and_previous_zoning_lines) (preferred city) of a ZIP code. There is only one preferred city per ZIP code, which will always be in position 0 in the array of cities. .</param>
        public ZipLookupCity(string city = default(string), string state = default(string), string county = default(string), string countyFips = default(string), bool preferred = default(bool))
        {
            this.City = city;
            this.State = state;
            this.County = county;
            this.CountyFips = countyFips;
            this.Preferred = preferred;
        }

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
        /// County name of the address city.
        /// </summary>
        /// <value>County name of the address city.</value>
        [DataMember(Name = "county", EmitDefaultValue = false)]
        public string County { get; set; }

        /// <summary>
        /// A 5-digit [FIPS county code](https://en.wikipedia.org/wiki/FIPS_county_code) which uniquely identifies &#x60;components[county]&#x60;. It consists of a 2-digit state code and a 3-digit county code. 
        /// </summary>
        /// <value>A 5-digit [FIPS county code](https://en.wikipedia.org/wiki/FIPS_county_code) which uniquely identifies &#x60;components[county]&#x60;. It consists of a 2-digit state code and a 3-digit county code. </value>
        [DataMember(Name = "county_fips", EmitDefaultValue = false)]
        public string CountyFips { get; set; }

        /// <summary>
        /// Indicates whether or not the city is the [USPS default city](https://en.wikipedia.org/wiki/ZIP_Code#ZIP_Codes_and_previous_zoning_lines) (preferred city) of a ZIP code. There is only one preferred city per ZIP code, which will always be in position 0 in the array of cities. 
        /// </summary>
        /// <value>Indicates whether or not the city is the [USPS default city](https://en.wikipedia.org/wiki/ZIP_Code#ZIP_Codes_and_previous_zoning_lines) (preferred city) of a ZIP code. There is only one preferred city per ZIP code, which will always be in position 0 in the array of cities. </value>
        [DataMember(Name = "preferred", EmitDefaultValue = true)]
        public bool Preferred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZipLookupCity {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  CountyFips: ").Append(CountyFips).Append("\n");
            sb.Append("  Preferred: ").Append(Preferred).Append("\n");
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
            return this.Equals(input as ZipLookupCity);
        }

        /// <summary>
        /// Returns true if ZipLookupCity instances are equal
        /// </summary>
        /// <param name="input">Instance of ZipLookupCity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipLookupCity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.CountyFips == input.CountyFips ||
                    (this.CountyFips != null &&
                    this.CountyFips.Equals(input.CountyFips))
                ) && 
                (
                    this.Preferred == input.Preferred ||
                    this.Preferred.Equals(input.Preferred)
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.County != null)
                {
                    hashCode = (hashCode * 59) + this.County.GetHashCode();
                }
                if (this.CountyFips != null)
                {
                    hashCode = (hashCode * 59) + this.CountyFips.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Preferred.GetHashCode();
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

            // CountyFips (string) pattern
            Regex regexCountyFips = new Regex(@"\\d{5}", RegexOptions.CultureInvariant);
            if (false == regexCountyFips.Match(this.CountyFips).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountyFips, must match a pattern of " + regexCountyFips, new [] { "CountyFips" });
            }

            yield break;
        }
    }

}
