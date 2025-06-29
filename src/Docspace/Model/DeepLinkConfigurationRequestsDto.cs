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
    /// The request parameters for managing the deep link configuration.
    /// </summary>
    [DataContract(Name = "DeepLinkConfigurationRequestsDto")]
    public partial class DeepLinkConfigurationRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeepLinkConfigurationRequestsDto" /> class.
        /// </summary>
        /// <param name="deepLinkSettings">deepLinkSettings.</param>
        public DeepLinkConfigurationRequestsDto(TenantDeepLinkSettings deepLinkSettings = default(TenantDeepLinkSettings))
        {
            this.DeepLinkSettings = deepLinkSettings;
        }

        /// <summary>
        /// Gets or Sets DeepLinkSettings
        /// </summary>
        [DataMember(Name = "deepLinkSettings", EmitDefaultValue = false)]
        public TenantDeepLinkSettings DeepLinkSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeepLinkConfigurationRequestsDto {\n");
            sb.Append("  DeepLinkSettings: ").Append(DeepLinkSettings).Append("\n");
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
