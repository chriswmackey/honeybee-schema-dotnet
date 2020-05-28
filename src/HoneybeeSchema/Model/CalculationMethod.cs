/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.33.0
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
    /// Text noting whether CPU-based polygon clipping method orGPU-based pixel counting method should be used. For low numbers of shadingsurfaces (less than ~200), PolygonClipping requires less runtime thanPixelCounting. However, PixelCounting runtime scales significantlybetter at higher numbers of shading surfaces. PixelCounting also hasno limitations related to zone concavity when used with any“FullInterior” solar distribution options.
    /// </summary>
    /// <value>Text noting whether CPU-based polygon clipping method orGPU-based pixel counting method should be used. For low numbers of shadingsurfaces (less than ~200), PolygonClipping requires less runtime thanPixelCounting. However, PixelCounting runtime scales significantlybetter at higher numbers of shading surfaces. PixelCounting also hasno limitations related to zone concavity when used with any“FullInterior” solar distribution options.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CalculationMethod
    {
        /// <summary>
        /// Enum PolygonClipping for value: PolygonClipping
        /// </summary>
        [EnumMember(Value = "PolygonClipping")]
        PolygonClipping = 1,

        /// <summary>
        /// Enum PixelCounting for value: PixelCounting
        /// </summary>
        [EnumMember(Value = "PixelCounting")]
        PixelCounting = 2

    }

}
