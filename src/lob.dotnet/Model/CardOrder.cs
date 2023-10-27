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
    /// CardOrder
    /// </summary>
    [DataContract(Name = "card_order")]
    public partial class CardOrder : IEquatable<CardOrder>, IValidatableObject
    {
        /// <summary>
        /// The status of the card order.
        /// </summary>
        /// <value>The status of the card order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            

            /// <summary>
            /// Enum Printing for value: printing
            /// </summary>
            [EnumMember(Value = "printing")]
            Printing = 2,
            

            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 3,
            

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 4,
            

            /// <summary>
            /// Enum Depleted for value: depleted
            /// </summary>
            [EnumMember(Value = "depleted")]
            Depleted = 5
            

        }


        /// <summary>
        /// The status of the card order.
        /// </summary>
        /// <value>The status of the card order.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrder" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;co_&#x60;..</param>
        /// <param name="cardId">Unique identifier prefixed with &#x60;card_&#x60;..</param>
        /// <param name="status">The status of the card order..</param>
        /// <param name="inventory">The inventory of the card order. (default to 0M).</param>
        /// <param name="quantityOrdered">The quantity of cards ordered (default to 0M).</param>
        /// <param name="unitPrice">The unit price for the card order. (default to 0M).</param>
        /// <param name="cancelledReason">The reason for cancellation..</param>
        /// <param name="availabilityDate">A timestamp in ISO 8601 format of the date the resource was created..</param>
        /// <param name="expectedAvailabilityDate">The fixed deadline for the cards to be printed..</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created. (required).</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified. (required).</param>
        /// <param name="deleted">Only returned if the resource has been successfully deleted..</param>
        /// <param name="_object">Value is type of resource. (required).</param>
        public CardOrder(string id = default(string), string cardId = default(string), StatusEnum? status = default(StatusEnum?), decimal inventory = 0M, decimal quantityOrdered = 0M, decimal unitPrice = 0M, string cancelledReason = default(string), DateTime availabilityDate = default(DateTime), DateTime expectedAvailabilityDate = default(DateTime), DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), bool deleted = default(bool), string _object = default(string))
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for CardOrder and cannot be null");
            }
            this.Object = _object;
            this.Id = id;
            this.CardId = cardId;
            this.Status = status;
            this.Inventory = inventory;
            this.QuantityOrdered = quantityOrdered;
            this.UnitPrice = unitPrice;
            this.CancelledReason = cancelledReason;
            this.AvailabilityDate = availabilityDate;
            this.ExpectedAvailabilityDate = expectedAvailabilityDate;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;co_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;co_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier prefixed with &#x60;card_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;card_&#x60;.</value>
        [DataMember(Name = "card_id", EmitDefaultValue = false)]
        public string CardId { get; set; }

        /// <summary>
        /// The inventory of the card order.
        /// </summary>
        /// <value>The inventory of the card order.</value>
        [DataMember(Name = "inventory", EmitDefaultValue = false)]
        public decimal Inventory { get; set; }

        /// <summary>
        /// The quantity of cards ordered
        /// </summary>
        /// <value>The quantity of cards ordered</value>
        [DataMember(Name = "quantity_ordered", EmitDefaultValue = false)]
        public decimal QuantityOrdered { get; set; }

        /// <summary>
        /// The unit price for the card order.
        /// </summary>
        /// <value>The unit price for the card order.</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The reason for cancellation.
        /// </summary>
        /// <value>The reason for cancellation.</value>
        [DataMember(Name = "cancelled_reason", EmitDefaultValue = false)]
        public string CancelledReason { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was created.</value>
        [DataMember(Name = "availability_date", EmitDefaultValue = false)]
        public DateTime AvailabilityDate { get; set; }

        /// <summary>
        /// The fixed deadline for the cards to be printed.
        /// </summary>
        /// <value>The fixed deadline for the cards to be printed.</value>
        [DataMember(Name = "expected_availability_date", EmitDefaultValue = false)]
        public DateTime ExpectedAvailabilityDate { get; set; }

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
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        /// <value>Only returned if the resource has been successfully deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Value is type of resource.
        /// </summary>
        /// <value>Value is type of resource.</value>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  CancelledReason: ").Append(CancelledReason).Append("\n");
            sb.Append("  AvailabilityDate: ").Append(AvailabilityDate).Append("\n");
            sb.Append("  ExpectedAvailabilityDate: ").Append(ExpectedAvailabilityDate).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
            return this.Equals(input as CardOrder);
        }

        /// <summary>
        /// Returns true if CardOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CardOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardOrder input)
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
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Inventory == input.Inventory ||
                    this.Inventory.Equals(input.Inventory)
                ) && 
                (
                    this.QuantityOrdered == input.QuantityOrdered ||
                    this.QuantityOrdered.Equals(input.QuantityOrdered)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.CancelledReason == input.CancelledReason ||
                    (this.CancelledReason != null &&
                    this.CancelledReason.Equals(input.CancelledReason))
                ) && 
                (
                    this.AvailabilityDate == input.AvailabilityDate ||
                    (this.AvailabilityDate != null &&
                    this.AvailabilityDate.Equals(input.AvailabilityDate))
                ) && 
                (
                    this.ExpectedAvailabilityDate == input.ExpectedAvailabilityDate ||
                    (this.ExpectedAvailabilityDate != null &&
                    this.ExpectedAvailabilityDate.Equals(input.ExpectedAvailabilityDate))
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
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.CardId != null)
                {
                    hashCode = (hashCode * 59) + this.CardId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Inventory.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityOrdered.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                if (this.CancelledReason != null)
                {
                    hashCode = (hashCode * 59) + this.CancelledReason.GetHashCode();
                }
                if (this.AvailabilityDate != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityDate.GetHashCode();
                }
                if (this.ExpectedAvailabilityDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedAvailabilityDate.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateModified != null)
                {
                    hashCode = (hashCode * 59) + this.DateModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
            Regex regexId = new Regex(@"^co_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // CardId (string) pattern
            Regex regexCardId = new Regex(@"^card_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexCardId.Match(this.CardId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardId, must match a pattern of " + regexCardId, new [] { "CardId" });
            }

            yield break;
        }
    }

}
