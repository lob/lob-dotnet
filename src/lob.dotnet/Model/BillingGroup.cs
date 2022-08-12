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
    /// BillingGroup
    /// </summary>
    [DataContract(Name = "billing_group")]
    public partial class BillingGroup : IEquatable<BillingGroup>, IValidatableObject
    {
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum BillingGroup for value: billing_group
            /// </summary>
            [EnumMember(Value = "billing_group")]
            BillingGroup = 1
            

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public ObjectEnum Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingGroup" /> class.
        /// </summary>
        /// <param name="description">Description of the billing group..</param>
        /// <param name="name">Name of the billing group. (required).</param>
        /// <param name="id">Unique identifier prefixed with &#x60;bg_&#x60;. (required).</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created. (required).</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified. (required).</param>
        /// <param name="_object">Value is resource type. (required) (default to ObjectEnum.BillingGroup).</param>
        public BillingGroup(string description = default(string), string name = default(string), string id = default(string), DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), ObjectEnum _object = ObjectEnum.BillingGroup)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for BillingGroup and cannot be null");
            }
            this.Name = name;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for BillingGroup and cannot be null");
            }
            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Object = _object;
            this.Description = description;
        }

        /// <summary>
        /// Description of the billing group.
        /// </summary>
        /// <value>Description of the billing group.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the billing group.
        /// </summary>
        /// <value>Name of the billing group.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier prefixed with &#x60;bg_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;bg_&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was created.</value>
        [DataMember(Name = "date_created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was last modified.</value>
        [DataMember(Name = "date_modified", IsRequired = true, EmitDefaultValue = false)]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingGroup {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingGroup);
        }

        /// <summary>
        /// Returns true if BillingGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingGroup input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateModified == input.DateModified ||
                    (this.DateModified != null &&
                    this.DateModified.Equals(input.DateModified))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateModified != null)
                {
                    hashCode = (hashCode * 59) + this.DateModified.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^bg_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
