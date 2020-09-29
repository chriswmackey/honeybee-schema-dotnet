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
    
    public enum ResidentialEquipmentType
    {
        /// <summary>
        /// Enum ACwithbaseboardelectric for value: Residential AC with baseboard electric
        /// </summary>
        [EnumMember(Value = "Residential AC with baseboard electric")]
        ACwithbaseboardelectric = 1,

        /// <summary>
        /// Enum ACwithbaseboardgasboiler for value: Residential AC with baseboard gas boiler
        /// </summary>
        [EnumMember(Value = "Residential AC with baseboard gas boiler")]
        ACwithbaseboardgasboiler = 2,

        /// <summary>
        /// Enum ACwithbaseboardcentralairsourceheatpump for value: Residential AC with baseboard central air source heat pump
        /// </summary>
        [EnumMember(Value = "Residential AC with baseboard central air source heat pump")]
        ACwithbaseboardcentralairsourceheatpump = 3,

        /// <summary>
        /// Enum ACwithbaseboarddistricthotwater for value: Residential AC with baseboard district hot water
        /// </summary>
        [EnumMember(Value = "Residential AC with baseboard district hot water")]
        ACwithbaseboarddistricthotwater = 4,

        /// <summary>
        /// Enum ACwithresidentialforcedairfurnace for value: Residential AC with residential forced air furnace
        /// </summary>
        [EnumMember(Value = "Residential AC with residential forced air furnace")]
        ACwithresidentialforcedairfurnace = 5,

        /// <summary>
        /// Enum ACwithnoheat for value: Residential AC with no heat
        /// </summary>
        [EnumMember(Value = "Residential AC with no heat")]
        ACwithnoheat = 6,

        /// <summary>
        /// Enum Heatpump for value: Residential heat pump
        /// </summary>
        [EnumMember(Value = "Residential heat pump")]
        Heatpump = 7,

        /// <summary>
        /// Enum Heatpumpwithnocooling for value: Residential heat pump with no cooling
        /// </summary>
        [EnumMember(Value = "Residential heat pump with no cooling")]
        Heatpumpwithnocooling = 8,

        /// <summary>
        /// Enum Forcedairfurnace for value: Residential forced air furnace
        /// </summary>
        [EnumMember(Value = "Residential forced air furnace")]
        Forcedairfurnace = 9

    }

}
