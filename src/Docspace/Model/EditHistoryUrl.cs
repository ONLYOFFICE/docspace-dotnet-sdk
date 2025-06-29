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
    /// The file editing history URL parameters.
    /// </summary>
    [DataContract(Name = "EditHistoryUrl")]
    public partial class EditHistoryUrl : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryUrl" /> class.
        /// </summary>
        /// <param name="key">The document identifier of the previous version of the document..</param>
        /// <param name="url">The url address of the previous version of the document..</param>
        /// <param name="fileType">The document extension..</param>
        public EditHistoryUrl(string key = default(string), string url = default(string), string fileType = default(string))
        {
            this.Key = key;
            this.Url = url;
            this.FileType = fileType;
        }

        /// <summary>
        /// The document identifier of the previous version of the document.
        /// </summary>
        /// <value>The document identifier of the previous version of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The url address of the previous version of the document.
        /// </summary>
        /// <value>The url address of the previous version of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The document extension.
        /// </summary>
        /// <value>The document extension.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditHistoryUrl {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
