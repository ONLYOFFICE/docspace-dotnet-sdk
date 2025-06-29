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
    /// The parameters of the file editing history.
    /// </summary>
    [DataContract(Name = "EditHistoryChangesWrapper")]
    public partial class EditHistoryChangesWrapper : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryChangesWrapper" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="created">created.</param>
        /// <param name="documentSha256">The document hash generated by the SHA-256 algorithm..</param>
        public EditHistoryChangesWrapper(EditHistoryAuthor user = default(EditHistoryAuthor), ApiDateTime created = default(ApiDateTime), string documentSha256 = default(string))
        {
            this.User = user;
            this.Created = created;
            this.DocumentSha256 = documentSha256;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EditHistoryAuthor User { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// The document hash generated by the SHA-256 algorithm.
        /// </summary>
        /// <value>The document hash generated by the SHA-256 algorithm.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "documentSha256", EmitDefaultValue = true)]
        public string DocumentSha256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditHistoryChangesWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DocumentSha256: ").Append(DocumentSha256).Append("\n");
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
