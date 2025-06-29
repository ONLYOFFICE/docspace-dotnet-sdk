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
    /// The response data for the API key operations.
    /// </summary>
    [DataContract(Name = "ApiKeyResponseDto")]
    public partial class ApiKeyResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponseDto" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the API key..</param>
        /// <param name="name">The API key name..</param>
        /// <param name="key">The full API key value (only returned when creating a new key)..</param>
        /// <param name="keyPostfix">The API key postfix (used for identification)..</param>
        /// <param name="permissions">The list of permissions granted to the API key..</param>
        /// <param name="lastUsed">lastUsed.</param>
        /// <param name="createOn">createOn.</param>
        /// <param name="createBy">createBy.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="isActive">Indicates whether the API key is active or not..</param>
        public ApiKeyResponseDto(Guid id = default(Guid), string name = default(string), string key = default(string), string keyPostfix = default(string), List<string> permissions = default(List<string>), ApiDateTime lastUsed = default(ApiDateTime), ApiDateTime createOn = default(ApiDateTime), EmployeeDto createBy = default(EmployeeDto), ApiDateTime expiresAt = default(ApiDateTime), bool isActive = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Key = key;
            this.KeyPostfix = keyPostfix;
            this.Permissions = permissions;
            this.LastUsed = lastUsed;
            this.CreateOn = createOn;
            this.CreateBy = createBy;
            this.ExpiresAt = expiresAt;
            this.IsActive = isActive;
        }

        /// <summary>
        /// The unique identifier of the API key.
        /// </summary>
        /// <value>The unique identifier of the API key.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The API key name.
        /// </summary>
        /// <value>The API key name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The full API key value (only returned when creating a new key).
        /// </summary>
        /// <value>The full API key value (only returned when creating a new key).</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The API key postfix (used for identification).
        /// </summary>
        /// <value>The API key postfix (used for identification).</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "keyPostfix", EmitDefaultValue = true)]
        public string KeyPostfix { get; set; }

        /// <summary>
        /// The list of permissions granted to the API key.
        /// </summary>
        /// <value>The list of permissions granted to the API key.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name = "lastUsed", EmitDefaultValue = false)]
        public ApiDateTime LastUsed { get; set; }

        /// <summary>
        /// Gets or Sets CreateOn
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// Gets or Sets CreateBy
        /// </summary>
        [DataMember(Name = "createBy", EmitDefaultValue = false)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public ApiDateTime ExpiresAt { get; set; }

        /// <summary>
        /// Indicates whether the API key is active or not.
        /// </summary>
        /// <value>Indicates whether the API key is active or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyResponseDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyPostfix: ").Append(KeyPostfix).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  CreateBy: ").Append(CreateBy).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
