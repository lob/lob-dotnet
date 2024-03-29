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
    /// Customize and place a QR code on the creative at the required position.
    /// </summary>
    [DataContract(Name = "qr_code")]
    public partial class QrCode : IEquatable<QrCode>, IValidatableObject
    {
        /// <summary>
        /// Sets how a QR code is being positioned in the document.
        /// </summary>
        /// <value>Sets how a QR code is being positioned in the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionEnum
        {
            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 1,
            

            /// <summary>
            /// Enum Relative for value: relative
            /// </summary>
            [EnumMember(Value = "relative")]
            Relative = 2
            

        }


        /// <summary>
        /// Sets how a QR code is being positioned in the document.
        /// </summary>
        /// <value>Sets how a QR code is being positioned in the document.</value>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = false)]
        public PositionEnum Position { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QrCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCode" /> class.
        /// </summary>
        /// <param name="position">Sets how a QR code is being positioned in the document. (required).</param>
        /// <param name="top">Vertical distance(in inches) to place QR code from the top..</param>
        /// <param name="right">Horizonal distance(in inches) to place QR code from the right..</param>
        /// <param name="left">Horizonal distance(in inches) to place QR code from the left..</param>
        /// <param name="bottom">Vertical distance(in inches) to place QR code from the bottom..</param>
        /// <param name="redirectUrl">The url to redirect the user when a QR code is scanned. The url must start with &#x60;https://&#x60; (required).</param>
        /// <param name="width">The size(in inches) of the QR code. All QR codes are generated as a square. (required).</param>
        public QrCode(PositionEnum position = default(PositionEnum), string top = default(string), string right = default(string), string left = default(string), string bottom = default(string), string redirectUrl = default(string), string width = default(string))
        {
            this.Position = position;
            // to ensure "redirectUrl" is required (not null)
            if (redirectUrl == null)
            {
                throw new ArgumentNullException("redirectUrl is a required property for QrCode and cannot be null");
            }
            this.RedirectUrl = redirectUrl;
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new ArgumentNullException("width is a required property for QrCode and cannot be null");
            }
            this.Width = width;
            this.Top = top;
            this.Right = right;
            this.Left = left;
            this.Bottom = bottom;
        }

        /// <summary>
        /// Vertical distance(in inches) to place QR code from the top.
        /// </summary>
        /// <value>Vertical distance(in inches) to place QR code from the top.</value>
        [DataMember(Name = "top", EmitDefaultValue = false)]
        public string Top { get; set; }

        /// <summary>
        /// Horizonal distance(in inches) to place QR code from the right.
        /// </summary>
        /// <value>Horizonal distance(in inches) to place QR code from the right.</value>
        [DataMember(Name = "right", EmitDefaultValue = false)]
        public string Right { get; set; }

        /// <summary>
        /// Horizonal distance(in inches) to place QR code from the left.
        /// </summary>
        /// <value>Horizonal distance(in inches) to place QR code from the left.</value>
        [DataMember(Name = "left", EmitDefaultValue = false)]
        public string Left { get; set; }

        /// <summary>
        /// Vertical distance(in inches) to place QR code from the bottom.
        /// </summary>
        /// <value>Vertical distance(in inches) to place QR code from the bottom.</value>
        [DataMember(Name = "bottom", EmitDefaultValue = false)]
        public string Bottom { get; set; }

        /// <summary>
        /// The url to redirect the user when a QR code is scanned. The url must start with &#x60;https://&#x60;
        /// </summary>
        /// <value>The url to redirect the user when a QR code is scanned. The url must start with &#x60;https://&#x60;</value>
        [DataMember(Name = "redirect_url", IsRequired = true, EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The size(in inches) of the QR code. All QR codes are generated as a square.
        /// </summary>
        /// <value>The size(in inches) of the QR code. All QR codes are generated as a square.</value>
        [DataMember(Name = "width", IsRequired = true, EmitDefaultValue = false)]
        public string Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QrCode {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as QrCode);
        }

        /// <summary>
        /// Returns true if QrCode instances are equal
        /// </summary>
        /// <param name="input">Instance of QrCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QrCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Bottom == input.Bottom ||
                    (this.Bottom != null &&
                    this.Bottom.Equals(input.Bottom))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.Top != null)
                {
                    hashCode = (hashCode * 59) + this.Top.GetHashCode();
                }
                if (this.Right != null)
                {
                    hashCode = (hashCode * 59) + this.Right.GetHashCode();
                }
                if (this.Left != null)
                {
                    hashCode = (hashCode * 59) + this.Left.GetHashCode();
                }
                if (this.Bottom != null)
                {
                    hashCode = (hashCode * 59) + this.Bottom.GetHashCode();
                }
                if (this.RedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUrl.GetHashCode();
                }
                if (this.Width != null)
                {
                    hashCode = (hashCode * 59) + this.Width.GetHashCode();
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
