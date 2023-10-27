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
    /// CreativeResponse
    /// </summary>
    [DataContract(Name = "creative_response")]
    public partial class CreativeResponse : IEquatable<CreativeResponse>, IValidatableObject
    {
        /// <summary>
        /// Mailpiece type for the creative
        /// </summary>
        /// <value>Mailpiece type for the creative</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceTypeEnum
        {
            /// <summary>
            /// Enum Letter for value: letter
            /// </summary>
            [EnumMember(Value = "letter")]
            Letter = 1,
            

            /// <summary>
            /// Enum Postcard for value: postcard
            /// </summary>
            [EnumMember(Value = "postcard")]
            Postcard = 2
            

        }


        /// <summary>
        /// Mailpiece type for the creative
        /// </summary>
        /// <value>Mailpiece type for the creative</value>
        [DataMember(Name = "resource_type", EmitDefaultValue = false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Creative for value: creative
            /// </summary>
            [EnumMember(Value = "creative")]
            Creative = 1
            

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreativeResponse" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;crv_&#x60;..</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="from">Must either be an address ID or an inline object with correct address parameters..</param>
        /// <param name="resourceType">Mailpiece type for the creative.</param>
        /// <param name="details">Either PostcardDetailsReturned or LetterDetailsReturned.</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="templatePreviewUrls">Preview URLs associated with a creative&#39;s artwork asset(s) if the creative uses HTML templates as assets..</param>
        /// <param name="templatePreviews">A list of template preview objects if the creative uses HTML template(s) as artwork asset(s)..</param>
        /// <param name="deleted">Only returned if the resource has been successfully deleted..</param>
        /// <param name="campaigns">Array of campaigns associated with the creative ID.</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created..</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified..</param>
        /// <param name="_object">Value is resource type. (default to ObjectEnum.Creative).</param>
        public CreativeResponse(string id = default(string), string description = default(string), Object from = default(Object), ResourceTypeEnum? resourceType = default(ResourceTypeEnum?), Object details = default(Object), Dictionary<string, string> metadata = default(Dictionary<string, string>), Object templatePreviewUrls = default(Object), List<Object> templatePreviews = default(List<Object>), bool deleted = default(bool), List<Campaign> campaigns = default(List<Campaign>), DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), ObjectEnum? _object = ObjectEnum.Creative)
        {
            this.Id = id;
            this.Description = description;
            this.From = from;
            this.ResourceType = resourceType;
            this.Details = details;
            this.Metadata = metadata;
            this.TemplatePreviewUrls = templatePreviewUrls;
            this.TemplatePreviews = templatePreviews;
            this.Deleted = deleted;
            this.Campaigns = campaigns;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Object = _object;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;crv_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;crv_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public Object From { get; set; }

        /// <summary>
        /// Either PostcardDetailsReturned or LetterDetailsReturned
        /// </summary>
        /// <value>Either PostcardDetailsReturned or LetterDetailsReturned</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Object Details { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Preview URLs associated with a creative&#39;s artwork asset(s) if the creative uses HTML templates as assets.
        /// </summary>
        /// <value>Preview URLs associated with a creative&#39;s artwork asset(s) if the creative uses HTML templates as assets.</value>
        [DataMember(Name = "template_preview_urls", EmitDefaultValue = false)]
        public Object TemplatePreviewUrls { get; set; }

        /// <summary>
        /// A list of template preview objects if the creative uses HTML template(s) as artwork asset(s).
        /// </summary>
        /// <value>A list of template preview objects if the creative uses HTML template(s) as artwork asset(s).</value>
        [DataMember(Name = "template_previews", EmitDefaultValue = false)]
        public List<Object> TemplatePreviews { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        /// <value>Only returned if the resource has been successfully deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Array of campaigns associated with the creative ID
        /// </summary>
        /// <value>Array of campaigns associated with the creative ID</value>
        [DataMember(Name = "campaigns", EmitDefaultValue = false)]
        public List<Campaign> Campaigns { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreativeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TemplatePreviewUrls: ").Append(TemplatePreviewUrls).Append("\n");
            sb.Append("  TemplatePreviews: ").Append(TemplatePreviews).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreativeResponse);
        }

        /// <summary>
        /// Returns true if CreativeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreativeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreativeResponse input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    this.ResourceType.Equals(input.ResourceType)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.TemplatePreviewUrls == input.TemplatePreviewUrls ||
                    (this.TemplatePreviewUrls != null &&
                    this.TemplatePreviewUrls.Equals(input.TemplatePreviewUrls))
                ) && 
                (
                    this.TemplatePreviews == input.TemplatePreviews ||
                    this.TemplatePreviews != null &&
                    input.TemplatePreviews != null &&
                    this.TemplatePreviews.SequenceEqual(input.TemplatePreviews)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Campaigns == input.Campaigns ||
                    this.Campaigns != null &&
                    input.Campaigns != null &&
                    this.Campaigns.SequenceEqual(input.Campaigns)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResourceType.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.TemplatePreviewUrls != null)
                {
                    hashCode = (hashCode * 59) + this.TemplatePreviewUrls.GetHashCode();
                }
                if (this.TemplatePreviews != null)
                {
                    hashCode = (hashCode * 59) + this.TemplatePreviews.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Campaigns != null)
                {
                    hashCode = (hashCode * 59) + this.Campaigns.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^crv_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
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
