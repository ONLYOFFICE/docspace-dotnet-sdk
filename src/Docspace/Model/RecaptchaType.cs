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
    /// The type of CAPTCHA validation used.
    /// </summary>
    /// <value>The type of CAPTCHA validation used.</value>
    public enum RecaptchaType
    {
        /// <summary>
        /// Enum Default for value: 0
        /// </summary>
        Default = 0,

        /// <summary>
        /// Enum AndroidV2 for value: 1
        /// </summary>
        AndroidV2 = 1,

        /// <summary>
        /// Enum iOSV2 for value: 2
        /// </summary>
        iOSV2 = 2,

        /// <summary>
        /// Enum hCaptcha for value: 3
        /// </summary>
        hCaptcha = 3
    }

}
