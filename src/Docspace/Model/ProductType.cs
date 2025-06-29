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
    /// Defines ProductType
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Documents for value: 2
        /// </summary>
        Documents = 2,

        /// <summary>
        /// Enum Login for value: 3
        /// </summary>
        Login = 3,

        /// <summary>
        /// Enum Others for value: 4
        /// </summary>
        Others = 4,

        /// <summary>
        /// Enum People for value: 5
        /// </summary>
        People = 5,

        /// <summary>
        /// Enum Settings for value: 7
        /// </summary>
        Settings = 7
    }

}
