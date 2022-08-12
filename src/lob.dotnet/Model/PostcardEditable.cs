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
    /// PostcardEditable
    /// </summary>
    [DataContract(Name = "postcard_editable")]
    public partial class PostcardEditable : IEquatable<PostcardEditable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostcardEditable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostcardEditable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostcardEditable" /> class.
        /// </summary>
        /// <param name="to">Must either be an address ID or an inline object with correct address parameters. (required).</param>
        /// <param name="from">Required if &#x60;to&#x60; address is international. Must either be an address ID or an inline object with correct address parameters..</param>
        /// <param name="size">size.</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="mailType">mailType.</param>
        /// <param name="mergeVariables">You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string..</param>
        /// <param name="sendDate">A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC..</param>
        /// <param name="front">The artwork to use as the front of your postcard.  (required).</param>
        /// <param name="back">The artwork to use as the back of your postcard.  (required).</param>
        /// <param name="billingGroupId">An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information..</param>
        public interface ToInterface {}

        public class stringTo : ToInterface {
            private string To;

            public stringTo(string To) {
                this.To = To;
            }

            public string get() {
                return To;
            }
        }
        public class AddressEditableTo : ToInterface {
            private AddressEditable To;

            public AddressEditableTo(AddressEditable To) {
                this.To = To;
            }

            public string get() {
                return To.ToJson();
            }
        }
        public interface FromInterface {}

        public class stringFrom : FromInterface {
            private string From;

            public stringFrom(string From) {
                this.From = From;
            }

            public string get() {
                return From;
            }
        }
        public class AddressEditableFrom : FromInterface {
            private AddressEditable From;

            public AddressEditableFrom(AddressEditable From) {
                this.From = From;
            }

            public string get() {
                return From.ToJson();
            }
        }
        public PostcardEditable(ToInterface to = default(ToInterface), FromInterface from = default(FromInterface), PostcardSize size = default(PostcardSize), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), MailType mailType = default(MailType), Object mergeVariables = default(Object), DateTime sendDate = default(DateTime), string front = default(string), string back = default(string), string billingGroupId = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for PostcardEditable and cannot be null");
            }
            else if (to.GetType() == typeof(stringTo)) {
                stringTo blah = (stringTo)to;
                this.To = blah.get();
            }
            else if (to.GetType() == typeof(AddressEditableTo)) {
                AddressEditableTo blah = (AddressEditableTo)to;
                this.To = blah.get();
            }
            // to ensure "front" is required (not null)
            if (front == null)
            {
                throw new ArgumentNullException("front is a required property for PostcardEditable and cannot be null");
            }
            this.Front = front;
            // to ensure "back" is required (not null)
            if (back == null)
            {
                throw new ArgumentNullException("back is a required property for PostcardEditable and cannot be null");
            }
            this.Back = back;
            if (from.GetType() == typeof(stringFrom)) {
                stringFrom blah = (stringFrom)from;
                this.From = blah.get();
            }
            if (from.GetType() == typeof(AddressEditableFrom)) {
                AddressEditableFrom blah = (AddressEditableFrom)from;
                this.From = blah.get();
            }
            this.Size = size;
            this.Description = description;
            this.Metadata = metadata;
            this.MailType = mailType;
            this.MergeVariables = mergeVariables;
            this.SendDate = sendDate;
            this.BillingGroupId = billingGroupId;
        }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Required if &#x60;to&#x60; address is international. Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Required if &#x60;to&#x60; address is international. Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public PostcardSize Size { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MailType
        /// </summary>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailType MailType { get; set; }

        /// <summary>
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// </summary>
        /// <value>You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.</value>
        [DataMember(Name = "merge_variables", EmitDefaultValue = true)]
        public Object MergeVariables { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.</value>
        [DataMember(Name = "send_date", EmitDefaultValue = false)]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// The artwork to use as the front of your postcard. 
        /// </summary>
        /// <value>The artwork to use as the front of your postcard. </value>
        [DataMember(Name = "front", IsRequired = true, EmitDefaultValue = false)]
        public string Front { get; set; }

        /// <summary>
        /// The artwork to use as the back of your postcard. 
        /// </summary>
        /// <value>The artwork to use as the back of your postcard. </value>
        [DataMember(Name = "back", IsRequired = true, EmitDefaultValue = false)]
        public string Back { get; set; }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.
        /// </summary>
        /// <value>An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.</value>
        [DataMember(Name = "billing_group_id", EmitDefaultValue = false)]
        public string BillingGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostcardEditable {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
            sb.Append("  MergeVariables: ").Append(MergeVariables).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  Front: ").Append(Front).Append("\n");
            sb.Append("  Back: ").Append(Back).Append("\n");
            sb.Append("  BillingGroupId: ").Append(BillingGroupId).Append("\n");
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
            return this.Equals(input as PostcardEditable);
        }

        /// <summary>
        /// Returns true if PostcardEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of PostcardEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostcardEditable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MailType == input.MailType ||
                    (this.MailType != null &&
                    this.MailType.Equals(input.MailType))
                ) && 
                (
                    this.MergeVariables == input.MergeVariables ||
                    (this.MergeVariables != null &&
                    this.MergeVariables.Equals(input.MergeVariables))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.Front == input.Front ||
                    (this.Front != null &&
                    this.Front.Equals(input.Front))
                ) && 
                (
                    this.Back == input.Back ||
                    (this.Back != null &&
                    this.Back.Equals(input.Back))
                ) && 
                (
                    this.BillingGroupId == input.BillingGroupId ||
                    (this.BillingGroupId != null &&
                    this.BillingGroupId.Equals(input.BillingGroupId))
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MailType != null)
                {
                    hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                }
                if (this.MergeVariables != null)
                {
                    hashCode = (hashCode * 59) + this.MergeVariables.GetHashCode();
                }
                if (this.SendDate != null)
                {
                    hashCode = (hashCode * 59) + this.SendDate.GetHashCode();
                }
                if (this.Front != null)
                {
                    hashCode = (hashCode * 59) + this.Front.GetHashCode();
                }
                if (this.Back != null)
                {
                    hashCode = (hashCode * 59) + this.Back.GetHashCode();
                }
                if (this.BillingGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.BillingGroupId.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            yield break;
        }
    }

}
