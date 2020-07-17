/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.35.1
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
    
    public enum DesignDayTypes
    {
        /// <summary>
        /// Enum SummerDesignDay for value: SummerDesignDay
        /// </summary>
        [EnumMember(Value = "SummerDesignDay")]
        SummerDesignDay = 1,

        /// <summary>
        /// Enum WinterDesignDay for value: WinterDesignDay
        /// </summary>
        [EnumMember(Value = "WinterDesignDay")]
        WinterDesignDay = 2,

        /// <summary>
        /// Enum Sunday for value: Sunday
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday = 3,

        /// <summary>
        /// Enum Monday for value: Monday
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday = 4,

        /// <summary>
        /// Enum Tuesday for value: Tuesday
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday = 5,

        /// <summary>
        /// Enum Wednesday for value: Wednesday
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday = 6,

        /// <summary>
        /// Enum Thursday for value: Thursday
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday = 7,

        /// <summary>
        /// Enum Friday for value: Friday
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday = 8,

        /// <summary>
        /// Enum Holiday for value: Holiday
        /// </summary>
        [EnumMember(Value = "Holiday")]
        Holiday = 9,

        /// <summary>
        /// Enum CustomDay1 for value: CustomDay1
        /// </summary>
        [EnumMember(Value = "CustomDay1")]
        CustomDay1 = 10,

        /// <summary>
        /// Enum CustomDay2 for value: CustomDay2
        /// </summary>
        [EnumMember(Value = "CustomDay2")]
        CustomDay2 = 11

    }

}
