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
    /// The room logo information.
    /// </summary>
    [DataContract(Name = "Logo")]
    public partial class Logo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logo" /> class.
        /// </summary>
        /// <param name="original">The original logo..</param>
        /// <param name="large">The large logo..</param>
        /// <param name="medium">The medium logo..</param>
        /// <param name="small">The small logo..</param>
        /// <param name="color">The logo color..</param>
        /// <param name="cover">cover.</param>
        public Logo(string original = default(string), string large = default(string), string medium = default(string), string small = default(string), string color = default(string), LogoCover cover = default(LogoCover))
        {
            this.Original = original;
            this.Large = large;
            this.Medium = medium;
            this.Small = small;
            this.Color = color;
            this.Cover = cover;
        }

        /// <summary>
        /// The original logo.
        /// </summary>
        /// <value>The original logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "original", EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// The large logo.
        /// </summary>
        /// <value>The large logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "large", EmitDefaultValue = true)]
        public string Large { get; set; }

        /// <summary>
        /// The medium logo.
        /// </summary>
        /// <value>The medium logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "medium", EmitDefaultValue = true)]
        public string Medium { get; set; }

        /// <summary>
        /// The small logo.
        /// </summary>
        /// <value>The small logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "small", EmitDefaultValue = true)]
        public string Small { get; set; }

        /// <summary>
        /// The logo color.
        /// </summary>
        /// <value>The logo color.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Cover
        /// </summary>
        [DataMember(Name = "cover", EmitDefaultValue = false)]
        public LogoCover Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Logo {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
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
