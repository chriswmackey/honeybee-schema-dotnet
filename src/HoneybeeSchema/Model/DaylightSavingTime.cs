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
    /// Used to describe the daylight savings time for the simulation.
    /// </summary>
    [DataContract]
    public partial class DaylightSavingTime : DatedBaseModel, IEquatable<DaylightSavingTime>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DaylightSavingTime" /> class.
        /// </summary>
        /// <param name="startDate">A list of two integers for [month, day], representing the date for the start of daylight savings time. Default: 12 Mar (daylight savings in the US in 2017)..</param>
        /// <param name="endDate">A list of two integers for [month, day], representing the date for the end of daylight savings time. Default: 5 Nov (daylight savings in the US in 2017)..</param>
        public DaylightSavingTime
        (
             // Required parameters
            List<int> startDate= default, List<int> endDate= default// Optional parameters
        ) : base()// BaseClass
        {
            this.StartDate = startDate;
            this.EndDate = endDate;

            // Set non-required readonly properties with defaultValue
            this.Type = "DaylightSavingTime";
        }
        
        /// <summary>
        /// A list of two integers for [month, day], representing the date for the start of daylight savings time. Default: 12 Mar (daylight savings in the US in 2017).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the start of daylight savings time. Default: 12 Mar (daylight savings in the US in 2017).</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonProperty("start_date")]
        public List<int> StartDate { get; set; } 
        /// <summary>
        /// A list of two integers for [month, day], representing the date for the end of daylight savings time. Default: 5 Nov (daylight savings in the US in 2017).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the end of daylight savings time. Default: 5 Nov (daylight savings in the US in 2017).</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonProperty("end_date")]
        public List<int> EndDate { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DaylightSavingTime {iDd.Identifier}";
       
            return "DaylightSavingTime";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("DaylightSavingTime:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DaylightSavingTime object</returns>
        public static DaylightSavingTime FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DaylightSavingTime>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DaylightSavingTime object</returns>
        public DaylightSavingTime DuplicateDaylightSavingTime()
        {
            return Duplicate() as DaylightSavingTime;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DaylightSavingTime);
        }

        /// <summary>
        /// Returns true if DaylightSavingTime instances are equal
        /// </summary>
        /// <param name="input">Instance of DaylightSavingTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DaylightSavingTime input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate != null &&
                    input.StartDate != null &&
                    this.StartDate.SequenceEqual(input.StartDate)
                ) && base.Equals(input) && 
                (
                    this.EndDate == input.EndDate ||
                    this.EndDate != null &&
                    input.EndDate != null &&
                    this.EndDate.SequenceEqual(input.EndDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^DaylightSavingTime$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
