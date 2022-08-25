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
    /// Properties that the postcards in your Creative should have.
    /// </summary>
    [DataContract(Name = "postcard_details_writable")]
    public partial class PostcardDetailsWritable : IEquatable<PostcardDetailsWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostcardDetailsWritable" /> class.
        /// </summary>
        /// <param name="mailType">mailType.</param>
        /// <param name="size">size.</param>
        public PostcardDetailsWritable(MailType mailType = default(MailType), PostcardSize size = default(PostcardSize))
        {
            this.MailType = mailType;
            this.Size = size;
        }

        /// <summary>
        /// Gets or Sets MailType
        /// </summary>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailType MailType { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public PostcardSize Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostcardDetailsWritable {\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
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
            return this.Equals(input as PostcardDetailsWritable);
        }

        /// <summary>
        /// Returns true if PostcardDetailsWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of PostcardDetailsWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostcardDetailsWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MailType == input.MailType ||
                    (this.MailType != null &&
                    this.MailType.Equals(input.MailType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.MailType != null)
                {
                    hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
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