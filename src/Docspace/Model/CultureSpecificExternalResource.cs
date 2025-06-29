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
    /// The external resource parameters.
    /// </summary>
    [DataContract(Name = "CultureSpecificExternalResource")]
    public partial class CultureSpecificExternalResource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CultureSpecificExternalResource" /> class.
        /// </summary>
        /// <param name="domain">The external resource domain..</param>
        /// <param name="entries">The external resource entries..</param>
        public CultureSpecificExternalResource(string domain = default(string), Dictionary<string, string> entries = default(Dictionary<string, string>))
        {
            this.Domain = domain;
            this.Entries = entries;
        }

        /// <summary>
        /// The external resource domain.
        /// </summary>
        /// <value>The external resource domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "domain", EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// The external resource entries.
        /// </summary>
        /// <value>The external resource entries.</value>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:&quot;some text&quot;}]</example>
        */
        [DataMember(Name = "entries", EmitDefaultValue = true)]
        public Dictionary<string, string> Entries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CultureSpecificExternalResource {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
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
