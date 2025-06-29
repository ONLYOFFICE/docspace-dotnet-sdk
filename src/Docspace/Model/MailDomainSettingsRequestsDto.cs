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
    /// The request parameters for configuring trusted mail domains and visitor invitation settings.
    /// </summary>
    [DataContract(Name = "MailDomainSettingsRequestsDto")]
    public partial class MailDomainSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TenantTrustedDomainsType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailDomainSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailDomainSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailDomainSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="domains">The list of authorized email domains that are considered trusted. (required).</param>
        /// <param name="inviteUsersAsVisitors">Specifies the default permission level for the invited users (visitors or not)..</param>
        public MailDomainSettingsRequestsDto(TenantTrustedDomainsType type = default(TenantTrustedDomainsType), List<string> domains = default(List<string>), bool inviteUsersAsVisitors = default(bool))
        {
            this.Type = type;
            // to ensure "domains" is required (not null)
            if (domains == null)
            {
                throw new ArgumentNullException("domains is a required property for MailDomainSettingsRequestsDto and cannot be null");
            }
            this.Domains = domains;
            this.InviteUsersAsVisitors = inviteUsersAsVisitors;
        }

        /// <summary>
        /// The list of authorized email domains that are considered trusted.
        /// </summary>
        /// <value>The list of authorized email domains that are considered trusted.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Specifies the default permission level for the invited users (visitors or not).
        /// </summary>
        /// <value>Specifies the default permission level for the invited users (visitors or not).</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "inviteUsersAsVisitors", EmitDefaultValue = true)]
        public bool InviteUsersAsVisitors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MailDomainSettingsRequestsDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  InviteUsersAsVisitors: ").Append(InviteUsersAsVisitors).Append("\n");
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
