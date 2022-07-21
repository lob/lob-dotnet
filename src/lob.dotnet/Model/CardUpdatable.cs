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
    /// CardUpdatable
    /// </summary>
    [DataContract(Name = "card_updatable")]
    public partial class CardUpdatable : IEquatable<CardUpdatable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardUpdatable" /> class.
        /// </summary>
        /// <param name="description">Description of the card..</param>
        /// <param name="autoReorder">Allows for auto reordering.</param>
        /// <param name="reorderQuantity">The quantity of items to be reordered (only required when auto_reorder is true)..</param>
        public CardUpdatable(string description = default(string), bool autoReorder = default(bool), decimal reorderQuantity = default(decimal))
        {
            this.Description = description;
            this.AutoReorder = autoReorder;
            this.ReorderQuantity = reorderQuantity;
        }

        /// <summary>
        /// Description of the card.
        /// </summary>
        /// <value>Description of the card.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Allows for auto reordering
        /// </summary>
        /// <value>Allows for auto reordering</value>
        [DataMember(Name = "auto_reorder", EmitDefaultValue = true)]
        public bool AutoReorder { get; set; }

        /// <summary>
        /// The quantity of items to be reordered (only required when auto_reorder is true).
        /// </summary>
        /// <value>The quantity of items to be reordered (only required when auto_reorder is true).</value>
        [DataMember(Name = "reorder_quantity", EmitDefaultValue = false)]
        public decimal ReorderQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardUpdatable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AutoReorder: ").Append(AutoReorder).Append("\n");
            sb.Append("  ReorderQuantity: ").Append(ReorderQuantity).Append("\n");
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
            return this.Equals(input as CardUpdatable);
        }

        /// <summary>
        /// Returns true if CardUpdatable instances are equal
        /// </summary>
        /// <param name="input">Instance of CardUpdatable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardUpdatable input)
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
                    this.AutoReorder == input.AutoReorder ||
                    this.AutoReorder.Equals(input.AutoReorder)
                ) && 
                (
                    this.ReorderQuantity == input.ReorderQuantity ||
                    this.ReorderQuantity.Equals(input.ReorderQuantity)
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
                hashCode = (hashCode * 59) + this.AutoReorder.GetHashCode();
                hashCode = (hashCode * 59) + this.ReorderQuantity.GetHashCode();
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

            // ReorderQuantity (decimal) maximum
            if (this.ReorderQuantity > (decimal)10000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReorderQuantity, must be a value less than or equal to 10000000.", new [] { "ReorderQuantity" });
            }

            // ReorderQuantity (decimal) minimum
            if (this.ReorderQuantity < (decimal)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReorderQuantity, must be a value greater than or equal to 10000.", new [] { "ReorderQuantity" });
            }

            yield break;
        }
    }

}
