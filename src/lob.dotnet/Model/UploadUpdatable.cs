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
    /// UploadUpdatable
    /// </summary>
    [DataContract(Name = "upload_updatable")]
    public partial class UploadUpdatable : IEquatable<UploadUpdatable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUpdatable" /> class.
        /// </summary>
        /// <param name="originalFilename">Original filename provided when the upload is created..</param>
        /// <param name="requiredAddressColumnMapping">requiredAddressColumnMapping.</param>
        /// <param name="optionalAddressColumnMapping">optionalAddressColumnMapping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mergeVariableColumnMapping">The mapping of column headers in your file to the merge variables present in your creative. See our &lt;a href&#x3D;\&quot;https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Campaign Audience Guide&lt;/a&gt; for additional details. &lt;br /&gt;If a merge variable has the same \&quot;name\&quot; as a \&quot;key\&quot; in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects..</param>
        public UploadUpdatable(string originalFilename = default(string), RequiredAddressColumnMapping requiredAddressColumnMapping = default(RequiredAddressColumnMapping), OptionalAddressColumnMapping optionalAddressColumnMapping = default(OptionalAddressColumnMapping), UploadsMetadata metadata = default(UploadsMetadata), Object mergeVariableColumnMapping = default(Object))
        {
            this.OriginalFilename = originalFilename;
            this.RequiredAddressColumnMapping = requiredAddressColumnMapping;
            this.OptionalAddressColumnMapping = optionalAddressColumnMapping;
            this.Metadata = metadata;
            this.MergeVariableColumnMapping = mergeVariableColumnMapping;
        }

        /// <summary>
        /// Original filename provided when the upload is created.
        /// </summary>
        /// <value>Original filename provided when the upload is created.</value>
        [DataMember(Name = "originalFilename", EmitDefaultValue = false)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or Sets RequiredAddressColumnMapping
        /// </summary>
        [DataMember(Name = "requiredAddressColumnMapping", EmitDefaultValue = false)]
        public RequiredAddressColumnMapping RequiredAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or Sets OptionalAddressColumnMapping
        /// </summary>
        [DataMember(Name = "optionalAddressColumnMapping", EmitDefaultValue = false)]
        public OptionalAddressColumnMapping OptionalAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public UploadsMetadata Metadata { get; set; }

        /// <summary>
        /// The mapping of column headers in your file to the merge variables present in your creative. See our &lt;a href&#x3D;\&quot;https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Campaign Audience Guide&lt;/a&gt; for additional details. &lt;br /&gt;If a merge variable has the same \&quot;name\&quot; as a \&quot;key\&quot; in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects.
        /// </summary>
        /// <value>The mapping of column headers in your file to the merge variables present in your creative. See our &lt;a href&#x3D;\&quot;https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Campaign Audience Guide&lt;/a&gt; for additional details. &lt;br /&gt;If a merge variable has the same \&quot;name\&quot; as a \&quot;key\&quot; in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects.</value>
        [DataMember(Name = "mergeVariableColumnMapping", EmitDefaultValue = false)]
        public Object MergeVariableColumnMapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadUpdatable {\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  RequiredAddressColumnMapping: ").Append(RequiredAddressColumnMapping).Append("\n");
            sb.Append("  OptionalAddressColumnMapping: ").Append(OptionalAddressColumnMapping).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MergeVariableColumnMapping: ").Append(MergeVariableColumnMapping).Append("\n");
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
            return this.Equals(input as UploadUpdatable);
        }

        /// <summary>
        /// Returns true if UploadUpdatable instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadUpdatable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadUpdatable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginalFilename == input.OriginalFilename ||
                    (this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(input.OriginalFilename))
                ) && 
                (
                    this.RequiredAddressColumnMapping == input.RequiredAddressColumnMapping ||
                    (this.RequiredAddressColumnMapping != null &&
                    this.RequiredAddressColumnMapping.Equals(input.RequiredAddressColumnMapping))
                ) && 
                (
                    this.OptionalAddressColumnMapping == input.OptionalAddressColumnMapping ||
                    (this.OptionalAddressColumnMapping != null &&
                    this.OptionalAddressColumnMapping.Equals(input.OptionalAddressColumnMapping))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.MergeVariableColumnMapping == input.MergeVariableColumnMapping ||
                    (this.MergeVariableColumnMapping != null &&
                    this.MergeVariableColumnMapping.Equals(input.MergeVariableColumnMapping))
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
                if (this.OriginalFilename != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalFilename.GetHashCode();
                }
                if (this.RequiredAddressColumnMapping != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredAddressColumnMapping.GetHashCode();
                }
                if (this.OptionalAddressColumnMapping != null)
                {
                    hashCode = (hashCode * 59) + this.OptionalAddressColumnMapping.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MergeVariableColumnMapping != null)
                {
                    hashCode = (hashCode * 59) + this.MergeVariableColumnMapping.GetHashCode();
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
            yield break;
        }
    }

}
