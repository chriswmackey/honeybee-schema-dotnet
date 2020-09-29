/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.39.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FaceType
    {
        /// <summary>
        /// Enum Wall for value: Wall
        /// </summary>
        [EnumMember(Value = "Wall")]
        Wall = 1,

        /// <summary>
        /// Enum Floor for value: Floor
        /// </summary>
        [EnumMember(Value = "Floor")]
        Floor = 2,

        /// <summary>
        /// Enum RoofCeiling for value: RoofCeiling
        /// </summary>
        [EnumMember(Value = "RoofCeiling")]
        RoofCeiling = 3,

        /// <summary>
        /// Enum AirBoundary for value: AirBoundary
        /// </summary>
        [EnumMember(Value = "AirBoundary")]
        AirBoundary = 4

    }

}
