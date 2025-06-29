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
    /// The thumbnail request.
    /// </summary>
    [DataContract(Name = "ThumbnailsRequest")]
    public partial class ThumbnailsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailsRequest" /> class.
        /// </summary>
        /// <param name="tmpFile">The path to the temporary thumbnail file..</param>
        /// <param name="x">The thumbnail horizontal coordinate..</param>
        /// <param name="y">The thumbnail vertical coordinate..</param>
        /// <param name="width">The thumbnail width..</param>
        /// <param name="height">The thumbnail height..</param>
        public ThumbnailsRequest(string tmpFile = default(string), int x = default(int), int y = default(int), int width = default(int), int height = default(int))
        {
            this.TmpFile = tmpFile;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// The path to the temporary thumbnail file.
        /// </summary>
        /// <value>The path to the temporary thumbnail file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "tmpFile", EmitDefaultValue = true)]
        public string TmpFile { get; set; }

        /// <summary>
        /// The thumbnail horizontal coordinate.
        /// </summary>
        /// <value>The thumbnail horizontal coordinate.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The thumbnail vertical coordinate.
        /// </summary>
        /// <value>The thumbnail vertical coordinate.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// The thumbnail width.
        /// </summary>
        /// <value>The thumbnail width.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The thumbnail height.
        /// </summary>
        /// <value>The thumbnail height.</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThumbnailsRequest {\n");
            sb.Append("  TmpFile: ").Append(TmpFile).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
