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
    /// TrackingEventCertified
    /// </summary>
    [DataContract(Name = "tracking_event_certified")]
    public partial class TrackingEventCertified : IEquatable<TrackingEventCertified>, IValidatableObject
    {
        /// <summary>
        /// a Certified letter tracking event
        /// </summary>
        /// <value>a Certified letter tracking event</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Certified for value: certified
            /// </summary>
            [EnumMember(Value = "certified")]
            Certified = 1
            

        }


        /// <summary>
        /// a Certified letter tracking event
        /// </summary>
        /// <value>a Certified letter tracking event</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Name of tracking event for Certified letters. Letters sent with USPS Certified Mail are fully tracked by USPS, therefore their tracking events have an additional details object with more detailed information about the tracking event. Some certified tracking event names have multiple meanings, noted in the list here. See the description of the details object for the full set of combined certified tracking event name meanings.    * &#x60;Mailed&#x60; - Package has been accepted into the carrier network for delivery.    * &#x60;In Transit&#x60; - Maps to four distinct stages of transit.    * &#x60;In Local Area&#x60; - Package is at a location near the end destination.    * &#x60;Processed for Delivery&#x60; - Maps to two distinct stages of delivery.    * &#x60;Pickup Available&#x60; - Package is available for pickup at carrier location.    * &#x60;Delivered&#x60; - Package has been delivered.    * &#x60;Re-Routed&#x60; - Package has been forwarded.    * &#x60;Returned to Sender&#x60; - Package is to be returned to sender.    * &#x60;Issue&#x60; - Maps to (at least) 15 possible issues, some of which are actionable. 
        /// </summary>
        /// <value>Name of tracking event for Certified letters. Letters sent with USPS Certified Mail are fully tracked by USPS, therefore their tracking events have an additional details object with more detailed information about the tracking event. Some certified tracking event names have multiple meanings, noted in the list here. See the description of the details object for the full set of combined certified tracking event name meanings.    * &#x60;Mailed&#x60; - Package has been accepted into the carrier network for delivery.    * &#x60;In Transit&#x60; - Maps to four distinct stages of transit.    * &#x60;In Local Area&#x60; - Package is at a location near the end destination.    * &#x60;Processed for Delivery&#x60; - Maps to two distinct stages of delivery.    * &#x60;Pickup Available&#x60; - Package is available for pickup at carrier location.    * &#x60;Delivered&#x60; - Package has been delivered.    * &#x60;Re-Routed&#x60; - Package has been forwarded.    * &#x60;Returned to Sender&#x60; - Package is to be returned to sender.    * &#x60;Issue&#x60; - Maps to (at least) 15 possible issues, some of which are actionable. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Mailed for value: Mailed
            /// </summary>
            [EnumMember(Value = "Mailed")]
            Mailed = 1,
            

            /// <summary>
            /// Enum InTransit for value: In Transit
            /// </summary>
            [EnumMember(Value = "In Transit")]
            InTransit = 2,
            

            /// <summary>
            /// Enum InLocalArea for value: In Local Area
            /// </summary>
            [EnumMember(Value = "In Local Area")]
            InLocalArea = 3,
            

            /// <summary>
            /// Enum ProcessedForDelivery for value: Processed for Delivery
            /// </summary>
            [EnumMember(Value = "Processed for Delivery")]
            ProcessedForDelivery = 4,
            

            /// <summary>
            /// Enum PickupAvailable for value: Pickup Available
            /// </summary>
            [EnumMember(Value = "Pickup Available")]
            PickupAvailable = 5,
            

            /// <summary>
            /// Enum Delivered for value: Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered = 6,
            

            /// <summary>
            /// Enum ReRouted for value: Re-Routed
            /// </summary>
            [EnumMember(Value = "Re-Routed")]
            ReRouted = 7,
            

            /// <summary>
            /// Enum ReturnedToSender for value: Returned to Sender
            /// </summary>
            [EnumMember(Value = "Returned to Sender")]
            ReturnedToSender = 8,
            

            /// <summary>
            /// Enum Issue for value: Issue
            /// </summary>
            [EnumMember(Value = "Issue")]
            Issue = 9
            

        }


        /// <summary>
        /// Name of tracking event for Certified letters. Letters sent with USPS Certified Mail are fully tracked by USPS, therefore their tracking events have an additional details object with more detailed information about the tracking event. Some certified tracking event names have multiple meanings, noted in the list here. See the description of the details object for the full set of combined certified tracking event name meanings.    * &#x60;Mailed&#x60; - Package has been accepted into the carrier network for delivery.    * &#x60;In Transit&#x60; - Maps to four distinct stages of transit.    * &#x60;In Local Area&#x60; - Package is at a location near the end destination.    * &#x60;Processed for Delivery&#x60; - Maps to two distinct stages of delivery.    * &#x60;Pickup Available&#x60; - Package is available for pickup at carrier location.    * &#x60;Delivered&#x60; - Package has been delivered.    * &#x60;Re-Routed&#x60; - Package has been forwarded.    * &#x60;Returned to Sender&#x60; - Package is to be returned to sender.    * &#x60;Issue&#x60; - Maps to (at least) 15 possible issues, some of which are actionable. 
        /// </summary>
        /// <value>Name of tracking event for Certified letters. Letters sent with USPS Certified Mail are fully tracked by USPS, therefore their tracking events have an additional details object with more detailed information about the tracking event. Some certified tracking event names have multiple meanings, noted in the list here. See the description of the details object for the full set of combined certified tracking event name meanings.    * &#x60;Mailed&#x60; - Package has been accepted into the carrier network for delivery.    * &#x60;In Transit&#x60; - Maps to four distinct stages of transit.    * &#x60;In Local Area&#x60; - Package is at a location near the end destination.    * &#x60;Processed for Delivery&#x60; - Maps to two distinct stages of delivery.    * &#x60;Pickup Available&#x60; - Package is available for pickup at carrier location.    * &#x60;Delivered&#x60; - Package has been delivered.    * &#x60;Re-Routed&#x60; - Package has been forwarded.    * &#x60;Returned to Sender&#x60; - Package is to be returned to sender.    * &#x60;Issue&#x60; - Maps to (at least) 15 possible issues, some of which are actionable. </value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum TrackingEvent for value: tracking_event
            /// </summary>
            [EnumMember(Value = "tracking_event")]
            TrackingEvent = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public ObjectEnum Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventCertified" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingEventCertified() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventCertified" /> class.
        /// </summary>
        /// <param name="type">a Certified letter tracking event (required).</param>
        /// <param name="name">Name of tracking event for Certified letters. Letters sent with USPS Certified Mail are fully tracked by USPS, therefore their tracking events have an additional details object with more detailed information about the tracking event. Some certified tracking event names have multiple meanings, noted in the list here. See the description of the details object for the full set of combined certified tracking event name meanings.    * &#x60;Mailed&#x60; - Package has been accepted into the carrier network for delivery.    * &#x60;In Transit&#x60; - Maps to four distinct stages of transit.    * &#x60;In Local Area&#x60; - Package is at a location near the end destination.    * &#x60;Processed for Delivery&#x60; - Maps to two distinct stages of delivery.    * &#x60;Pickup Available&#x60; - Package is available for pickup at carrier location.    * &#x60;Delivered&#x60; - Package has been delivered.    * &#x60;Re-Routed&#x60; - Package has been forwarded.    * &#x60;Returned to Sender&#x60; - Package is to be returned to sender.    * &#x60;Issue&#x60; - Maps to (at least) 15 possible issues, some of which are actionable.  (required).</param>
        /// <param name="details">details.</param>
        /// <param name="location">The zip code in which the event occurred if it exists, otherwise will be the name of a Regional Distribution Center if it exists, otherwise will be null. .</param>
        /// <param name="id">Unique identifier prefixed with &#x60;evnt_&#x60;. (required).</param>
        /// <param name="time">A timestamp in ISO 8601 format of the date USPS registered the event..</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created. (required).</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified. (required).</param>
        /// <param name="_object">_object (required) (default to ObjectEnum.TrackingEvent).</param>
        public TrackingEventCertified(TypeEnum type = default(TypeEnum), NameEnum name = default(NameEnum), TrackingEventDetails details = default(TrackingEventDetails), string location = default(string), string id = default(string), DateTime time = default(DateTime), DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), ObjectEnum _object = ObjectEnum.TrackingEvent)
        {
            this.Type = type;
            this.Name = name;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TrackingEventCertified and cannot be null");
            }
            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Object = _object;
            this.Details = details;
            this.Location = location;
            this.Time = time;
        }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public TrackingEventDetails Details { get; set; }

        /// <summary>
        /// The zip code in which the event occurred if it exists, otherwise will be the name of a Regional Distribution Center if it exists, otherwise will be null. 
        /// </summary>
        /// <value>The zip code in which the event occurred if it exists, otherwise will be the name of a Regional Distribution Center if it exists, otherwise will be null. </value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Unique identifier prefixed with &#x60;evnt_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;evnt_&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date USPS registered the event.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date USPS registered the event.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

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
            sb.Append("class TrackingEventCertified {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as TrackingEventCertified);
        }

        /// <summary>
        /// Returns true if TrackingEventCertified instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingEventCertified to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingEventCertified input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
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
            Regex regexId = new Regex(@"^evnt_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
