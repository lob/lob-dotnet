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
    /// BillingGroupList
    /// </summary>
    [DataContract(Name = "billing_group_list")]
    public partial class BillingGroupList : IEquatable<BillingGroupList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingGroupList" /> class.
        /// </summary>
        /// <param name="data">list of billing groups.</param>
        /// <param name="_object">Value is type of resource..</param>
        /// <param name="nextUrl">url of next page of items in list..</param>
        /// <param name="previousUrl">url of previous page of items in list..</param>
        /// <param name="count">number of resources in a set.</param>
        public BillingGroupList(List<BillingGroup> data = default(List<BillingGroup>), string _object = default(string), string nextUrl = default(string), string previousUrl = default(string), int count = default(int))
        {
            this.Data = data;
            this.Object = _object;
            this.NextUrl = nextUrl;
            this.PreviousUrl = previousUrl;
            this.Count = count;
        }

        /// <summary>
        /// list of billing groups
        /// </summary>
        /// <value>list of billing groups</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<BillingGroup> Data { get; set; }

        /// <summary>
        /// Value is type of resource.
        /// </summary>
        /// <value>Value is type of resource.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// url of next page of items in list.
        /// </summary>
        /// <value>url of next page of items in list.</value>
        [DataMember(Name = "next_url", EmitDefaultValue = false)]
        public string NextUrl { get; set; }

        /// <summary>
        /// url of previous page of items in list.
        /// </summary>
        /// <value>url of previous page of items in list.</value>
        [DataMember(Name = "previous_url", EmitDefaultValue = false)]
        public string PreviousUrl { get; set; }

        /// <summary>
        /// number of resources in a set
        /// </summary>
        /// <value>number of resources in a set</value>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingGroupList {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  NextUrl: ").Append(NextUrl).Append("\n");
            sb.Append("  PreviousUrl: ").Append(PreviousUrl).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as BillingGroupList);
        }

        /// <summary>
        /// Returns true if BillingGroupList instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingGroupList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingGroupList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.NextUrl == input.NextUrl ||
                    (this.NextUrl != null &&
                    this.NextUrl.Equals(input.NextUrl))
                ) && 
                (
                    this.PreviousUrl == input.PreviousUrl ||
                    (this.PreviousUrl != null &&
                    this.PreviousUrl.Equals(input.PreviousUrl))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.NextUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NextUrl.GetHashCode();
                }
                if (this.PreviousUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
            yield break;
        }
    }

}
