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
    /// EventType
    /// </summary>
    [DataContract(Name = "event_type")]
    public partial class EventType : IEquatable<EventType>, IValidatableObject
    {
        /// <summary>
        /// Defines Resource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceEnum
        {
            /// <summary>
            /// Enum Postcards for value: postcards
            /// </summary>
            [EnumMember(Value = "postcards")]
            Postcards = 1,

            /// <summary>
            /// Enum SelfMailers for value: self mailers
            /// </summary>
            [EnumMember(Value = "self mailers")]
            SelfMailers = 2,

            /// <summary>
            /// Enum Letters for value: letters
            /// </summary>
            [EnumMember(Value = "letters")]
            Letters = 3,

            /// <summary>
            /// Enum Checks for value: checks
            /// </summary>
            [EnumMember(Value = "checks")]
            Checks = 4,

            /// <summary>
            /// Enum Addresses for value: addresses
            /// </summary>
            [EnumMember(Value = "addresses")]
            Addresses = 5,

            /// <summary>
            /// Enum BankAccounts for value: bank accounts
            /// </summary>
            [EnumMember(Value = "bank accounts")]
            BankAccounts = 6

        }


        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public ResourceEnum? Resource { get; set; }
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum EventType for value: event_type
            /// </summary>
            [EnumMember(Value = "event_type")]
            EventType = 1

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="enabledForTest">Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments..</param>
        /// <param name="resource">resource.</param>
        /// <param name="_object">Value is resource type. (default to ObjectEnum.EventType).</param>
        public EventType(string id = default(string), bool enabledForTest = default(bool), ResourceEnum? resource = default(ResourceEnum?), ObjectEnum? _object = ObjectEnum.EventType)
        {
            this.Id = id;
            this.EnabledForTest = enabledForTest;
            this.Resource = resource;
            this.Object = _object;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments.
        /// </summary>
        /// <value>Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments.</value>
        [DataMember(Name = "enabled_for_test", EmitDefaultValue = true)]
        public bool EnabledForTest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EnabledForTest: ").Append(EnabledForTest).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as EventType);
        }

        /// <summary>
        /// Returns true if EventType instances are equal
        /// </summary>
        /// <param name="input">Instance of EventType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventType input)
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
                    this.EnabledForTest == input.EnabledForTest ||
                    this.EnabledForTest.Equals(input.EnabledForTest)
                ) && 
                (
                    this.Resource == input.Resource ||
                    this.Resource.Equals(input.Resource)
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
                hashCode = (hashCode * 59) + this.EnabledForTest.GetHashCode();
                hashCode = (hashCode * 59) + this.Resource.GetHashCode();
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
            yield break;
        }
    }

}
