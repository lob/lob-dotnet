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
    /// Card
    /// </summary>
    [DataContract(Name = "card")]
    public partial class Card : IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 1,

            /// <summary>
            /// Enum Rendered for value: rendered
            /// </summary>
            [EnumMember(Value = "rendered")]
            Rendered = 2

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The orientation of the card.
        /// </summary>
        /// <value>The orientation of the card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            /// <summary>
            /// Enum Horizontal for value: horizontal
            /// </summary>
            [EnumMember(Value = "horizontal")]
            Horizontal = 1,

            /// <summary>
            /// Enum Vertical for value: vertical
            /// </summary>
            [EnumMember(Value = "vertical")]
            Vertical = 2

        }


        /// <summary>
        /// The orientation of the card.
        /// </summary>
        /// <value>The orientation of the card.</value>
        [DataMember(Name = "orientation", EmitDefaultValue = false)]
        public OrientationEnum? Orientation { get; set; }
        /// <summary>
        /// object
        /// </summary>
        /// <value>object</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 1

        }


        /// <summary>
        /// object
        /// </summary>
        /// <value>object</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// The size of the card
        /// </summary>
        /// <value>The size of the card</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
        {
            /// <summary>
            /// Enum _3375x2125 for value: 3.375x2.125
            /// </summary>
            [EnumMember(Value = "3.375x2.125")]
            _3375x2125 = 1,

            /// <summary>
            /// Enum _2125x3375 for value: 2.125x3.375
            /// </summary>
            [EnumMember(Value = "2.125x3.375")]
            _2125x3375 = 2

        }


        /// <summary>
        /// The size of the card
        /// </summary>
        /// <value>The size of the card</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;card_&#x60;..</param>
        /// <param name="url">The signed link for the card..</param>
        /// <param name="autoReorder">True if the cards should be auto-reordered. (default to false).</param>
        /// <param name="reorderQuantity">The number of cards to be reordered..</param>
        /// <param name="rawUrl">The raw URL of the card..</param>
        /// <param name="frontOriginalUrl">The original URL of the front template..</param>
        /// <param name="backOriginalUrl">The original URL of the back template..</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="availableQuantity">The available quantity of cards. (default to 0).</param>
        /// <param name="pendingQuantity">The pending quantity of cards. (default to 0).</param>
        /// <param name="status">status.</param>
        /// <param name="orientation">The orientation of the card. (default to OrientationEnum.Horizontal).</param>
        /// <param name="thresholdAmount">The threshold amount of the card (default to 0).</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created..</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified..</param>
        /// <param name="deleted">Only returned if the resource has been successfully deleted..</param>
        /// <param name="_object">object (default to ObjectEnum.Card).</param>
        /// <param name="description">Description of the card..</param>
        /// <param name="size">The size of the card (default to SizeEnum._2125x3375).</param>
        public Card(string id = default(string), string url = default(string), bool autoReorder = false, int? reorderQuantity = default(int?), string rawUrl = default(string), string frontOriginalUrl = default(string), string backOriginalUrl = default(string), List<Thumbnail> thumbnails = default(List<Thumbnail>), int availableQuantity = 0, int pendingQuantity = 0, StatusEnum? status = default(StatusEnum?), OrientationEnum? orientation = OrientationEnum.Horizontal, int thresholdAmount = 0, DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), bool deleted = default(bool), ObjectEnum? _object = ObjectEnum.Card, string description = default(string), SizeEnum? size = SizeEnum._2125x3375)
        {
            this.Id = id;
            this.Url = url;
            this.AutoReorder = autoReorder;
            this.ReorderQuantity = reorderQuantity;
            this.RawUrl = rawUrl;
            this.FrontOriginalUrl = frontOriginalUrl;
            this.BackOriginalUrl = backOriginalUrl;
            this.Thumbnails = thumbnails;
            this.AvailableQuantity = availableQuantity;
            this.PendingQuantity = pendingQuantity;
            this.Status = status;
            this.Orientation = orientation;
            this.ThresholdAmount = thresholdAmount;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.Object = _object;
            this.Description = description;
            this.Size = size;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;card_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;card_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The signed link for the card.
        /// </summary>
        /// <value>The signed link for the card.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// True if the cards should be auto-reordered.
        /// </summary>
        /// <value>True if the cards should be auto-reordered.</value>
        [DataMember(Name = "auto_reorder", EmitDefaultValue = true)]
        public bool AutoReorder { get; set; }

        /// <summary>
        /// The number of cards to be reordered.
        /// </summary>
        /// <value>The number of cards to be reordered.</value>
        [DataMember(Name = "reorder_quantity", EmitDefaultValue = true)]
        public int? ReorderQuantity { get; set; }

        /// <summary>
        /// The raw URL of the card.
        /// </summary>
        /// <value>The raw URL of the card.</value>
        [DataMember(Name = "raw_url", EmitDefaultValue = false)]
        public string RawUrl { get; set; }

        /// <summary>
        /// The original URL of the front template.
        /// </summary>
        /// <value>The original URL of the front template.</value>
        [DataMember(Name = "front_original_url", EmitDefaultValue = false)]
        public string FrontOriginalUrl { get; set; }

        /// <summary>
        /// The original URL of the back template.
        /// </summary>
        /// <value>The original URL of the back template.</value>
        [DataMember(Name = "back_original_url", EmitDefaultValue = false)]
        public string BackOriginalUrl { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnails
        /// </summary>
        [DataMember(Name = "thumbnails", EmitDefaultValue = false)]
        public List<Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// The available quantity of cards.
        /// </summary>
        /// <value>The available quantity of cards.</value>
        [DataMember(Name = "available_quantity", EmitDefaultValue = false)]
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// The pending quantity of cards.
        /// </summary>
        /// <value>The pending quantity of cards.</value>
        [DataMember(Name = "pending_quantity", EmitDefaultValue = false)]
        public int PendingQuantity { get; set; }

        /// <summary>
        /// The threshold amount of the card
        /// </summary>
        /// <value>The threshold amount of the card</value>
        [DataMember(Name = "threshold_amount", EmitDefaultValue = false)]
        public int ThresholdAmount { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was created.</value>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was last modified.</value>
        [DataMember(Name = "date_modified", EmitDefaultValue = false)]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        /// <value>Only returned if the resource has been successfully deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Description of the card.
        /// </summary>
        /// <value>Description of the card.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AutoReorder: ").Append(AutoReorder).Append("\n");
            sb.Append("  ReorderQuantity: ").Append(ReorderQuantity).Append("\n");
            sb.Append("  RawUrl: ").Append(RawUrl).Append("\n");
            sb.Append("  FrontOriginalUrl: ").Append(FrontOriginalUrl).Append("\n");
            sb.Append("  BackOriginalUrl: ").Append(BackOriginalUrl).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  PendingQuantity: ").Append(PendingQuantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  ThresholdAmount: ").Append(ThresholdAmount).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="input">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AutoReorder == input.AutoReorder ||
                    this.AutoReorder.Equals(input.AutoReorder)
                ) && 
                (
                    this.ReorderQuantity == input.ReorderQuantity ||
                    (this.ReorderQuantity != null &&
                    this.ReorderQuantity.Equals(input.ReorderQuantity))
                ) && 
                (
                    this.RawUrl == input.RawUrl ||
                    (this.RawUrl != null &&
                    this.RawUrl.Equals(input.RawUrl))
                ) && 
                (
                    this.FrontOriginalUrl == input.FrontOriginalUrl ||
                    (this.FrontOriginalUrl != null &&
                    this.FrontOriginalUrl.Equals(input.FrontOriginalUrl))
                ) && 
                (
                    this.BackOriginalUrl == input.BackOriginalUrl ||
                    (this.BackOriginalUrl != null &&
                    this.BackOriginalUrl.Equals(input.BackOriginalUrl))
                ) && 
                (
                    this.Thumbnails == input.Thumbnails ||
                    this.Thumbnails != null &&
                    input.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(input.Thumbnails)
                ) && 
                (
                    this.AvailableQuantity == input.AvailableQuantity ||
                    this.AvailableQuantity.Equals(input.AvailableQuantity)
                ) && 
                (
                    this.PendingQuantity == input.PendingQuantity ||
                    this.PendingQuantity.Equals(input.PendingQuantity)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    this.Orientation.Equals(input.Orientation)
                ) && 
                (
                    this.ThresholdAmount == input.ThresholdAmount ||
                    this.ThresholdAmount.Equals(input.ThresholdAmount)
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
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoReorder.GetHashCode();
                if (this.ReorderQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.ReorderQuantity.GetHashCode();
                }
                if (this.RawUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RawUrl.GetHashCode();
                }
                if (this.FrontOriginalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FrontOriginalUrl.GetHashCode();
                }
                if (this.BackOriginalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BackOriginalUrl.GetHashCode();
                }
                if (this.Thumbnails != null)
                {
                    hashCode = (hashCode * 59) + this.Thumbnails.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AvailableQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.PendingQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Orientation.GetHashCode();
                hashCode = (hashCode * 59) + this.ThresholdAmount.GetHashCode();
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateModified != null)
                {
                    hashCode = (hashCode * 59) + this.DateModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
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
            Regex regexId = new Regex(@"^card_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 2083.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            // RawUrl (string) maxLength
            if (this.RawUrl != null && this.RawUrl.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RawUrl, length must be less than 2083.", new [] { "RawUrl" });
            }

            // RawUrl (string) minLength
            if (this.RawUrl != null && this.RawUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RawUrl, length must be greater than 1.", new [] { "RawUrl" });
            }

            // FrontOriginalUrl (string) maxLength
            if (this.FrontOriginalUrl != null && this.FrontOriginalUrl.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontOriginalUrl, length must be less than 2083.", new [] { "FrontOriginalUrl" });
            }

            // FrontOriginalUrl (string) minLength
            if (this.FrontOriginalUrl != null && this.FrontOriginalUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontOriginalUrl, length must be greater than 1.", new [] { "FrontOriginalUrl" });
            }

            // BackOriginalUrl (string) maxLength
            if (this.BackOriginalUrl != null && this.BackOriginalUrl.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackOriginalUrl, length must be less than 2083.", new [] { "BackOriginalUrl" });
            }

            // BackOriginalUrl (string) minLength
            if (this.BackOriginalUrl != null && this.BackOriginalUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackOriginalUrl, length must be greater than 1.", new [] { "BackOriginalUrl" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            yield break;
        }
    }

}