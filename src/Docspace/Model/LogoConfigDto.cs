/*
 * Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The logo config parameters.
    /// </summary>
    [DataContract(Name = "LogoConfigDto")]
    public partial class LogoConfigDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoConfigDto" /> class.
        /// </summary>
        /// <param name="image">The image of the logo..</param>
        /// <param name="imageDark">The dark image of the logo..</param>
        /// <param name="imageEmbedded">The embedded image of the logo..</param>
        /// <param name="url">The url link of the logo..</param>
        /// <param name="visible">Specifies if the logo is visible..</param>
        public LogoConfigDto(string image = default(string), string imageDark = default(string), string imageEmbedded = default(string), string url = default(string), bool visible = default(bool))
        {
            this.Image = image;
            this.ImageDark = imageDark;
            this.ImageEmbedded = imageEmbedded;
            this.Url = url;
            this.Visible = visible;
        }

        /// <summary>
        /// The image of the logo.
        /// </summary>
        /// <value>The image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The dark image of the logo.
        /// </summary>
        /// <value>The dark image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageDark", EmitDefaultValue = true)]
        public string ImageDark { get; set; }

        /// <summary>
        /// The embedded image of the logo.
        /// </summary>
        /// <value>The embedded image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageEmbedded", EmitDefaultValue = true)]
        public string ImageEmbedded { get; set; }

        /// <summary>
        /// The url link of the logo.
        /// </summary>
        /// <value>The url link of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Specifies if the logo is visible.
        /// </summary>
        /// <value>Specifies if the logo is visible.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogoConfigDto {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImageDark: ").Append(ImageDark).Append("\n");
            sb.Append("  ImageEmbedded: ").Append(ImageEmbedded).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
