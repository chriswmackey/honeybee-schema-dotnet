/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract(Name = "VentilationControlAbridged")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class VentilationControlAbridged : OpenAPIGenBaseModel, IEquatable<VentilationControlAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VentilationControlAbridged" /> class.
        /// </summary>
        /// <param name="minIndoorTemperature">A number for the minimum indoor temperature at which to ventilate in Celsius. Typically, this variable is used to initiate ventilation. (default to -100D).</param>
        /// <param name="maxIndoorTemperature">A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a maximum temperature at which point ventilation is stopped and a cooling system is turned on. (default to 100D).</param>
        /// <param name="minOutdoorTemperature">A number for the minimum outdoor temperature at which to ventilate in Celsius. This can be used to ensure ventilative cooling does not happen during the winter even if the Room is above the min_indoor_temperature. (default to -100D).</param>
        /// <param name="maxOutdoorTemperature">A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a limit for when it is considered too hot outside for ventilative cooling. (default to 100D).</param>
        /// <param name="deltaTemperature">A number for the temperature differential in Celsius between indoor and outdoor below which ventilation is shut off.  This should usually be a positive number so that ventilation only occurs when the outdoors is cooler than the indoors. Negative numbers indicate how much hotter the outdoors can be than the indoors before ventilation is stopped. (default to -100D).</param>
        /// <param name="schedule">Identifier of the schedule for the ventilation over the course of the year. Note that this is applied on top of any setpoints. The type of this schedule should be On/Off and values should be either 0 (no possibility of ventilation) or 1 (ventilation possible)..</param>
        public VentilationControlAbridged
        (
             // Required parameters
            double minIndoorTemperature = -100D, double maxIndoorTemperature = 100D, double minOutdoorTemperature = -100D, double maxOutdoorTemperature = 100D, double deltaTemperature = -100D, string schedule= default// Optional parameters
        ) : base()// BaseClass
        {
            this.MinIndoorTemperature = minIndoorTemperature;
            this.MaxIndoorTemperature = maxIndoorTemperature;
            this.MinOutdoorTemperature = minOutdoorTemperature;
            this.MaxOutdoorTemperature = maxOutdoorTemperature;
            this.DeltaTemperature = deltaTemperature;
            this.Schedule = schedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "VentilationControlAbridged";
        }

        /// <summary>
        /// A number for the minimum indoor temperature at which to ventilate in Celsius. Typically, this variable is used to initiate ventilation.
        /// </summary>
        /// <value>A number for the minimum indoor temperature at which to ventilate in Celsius. Typically, this variable is used to initiate ventilation.</value>
        [DataMember(Name="min_indoor_temperature", EmitDefaultValue=false)]
        public double MinIndoorTemperature { get; set; }  = -100D;
        /// <summary>
        /// A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a maximum temperature at which point ventilation is stopped and a cooling system is turned on.
        /// </summary>
        /// <value>A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a maximum temperature at which point ventilation is stopped and a cooling system is turned on.</value>
        [DataMember(Name="max_indoor_temperature", EmitDefaultValue=false)]
        public double MaxIndoorTemperature { get; set; }  = 100D;
        /// <summary>
        /// A number for the minimum outdoor temperature at which to ventilate in Celsius. This can be used to ensure ventilative cooling does not happen during the winter even if the Room is above the min_indoor_temperature.
        /// </summary>
        /// <value>A number for the minimum outdoor temperature at which to ventilate in Celsius. This can be used to ensure ventilative cooling does not happen during the winter even if the Room is above the min_indoor_temperature.</value>
        [DataMember(Name="min_outdoor_temperature", EmitDefaultValue=false)]
        public double MinOutdoorTemperature { get; set; }  = -100D;
        /// <summary>
        /// A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a limit for when it is considered too hot outside for ventilative cooling.
        /// </summary>
        /// <value>A number for the maximum indoor temperature at which to ventilate in Celsius. This can be used to set a limit for when it is considered too hot outside for ventilative cooling.</value>
        [DataMember(Name="max_outdoor_temperature", EmitDefaultValue=false)]
        public double MaxOutdoorTemperature { get; set; }  = 100D;
        /// <summary>
        /// A number for the temperature differential in Celsius between indoor and outdoor below which ventilation is shut off.  This should usually be a positive number so that ventilation only occurs when the outdoors is cooler than the indoors. Negative numbers indicate how much hotter the outdoors can be than the indoors before ventilation is stopped.
        /// </summary>
        /// <value>A number for the temperature differential in Celsius between indoor and outdoor below which ventilation is shut off.  This should usually be a positive number so that ventilation only occurs when the outdoors is cooler than the indoors. Negative numbers indicate how much hotter the outdoors can be than the indoors before ventilation is stopped.</value>
        [DataMember(Name="delta_temperature", EmitDefaultValue=false)]
        public double DeltaTemperature { get; set; }  = -100D;
        /// <summary>
        /// Identifier of the schedule for the ventilation over the course of the year. Note that this is applied on top of any setpoints. The type of this schedule should be On/Off and values should be either 0 (no possibility of ventilation) or 1 (ventilation possible).
        /// </summary>
        /// <value>Identifier of the schedule for the ventilation over the course of the year. Note that this is applied on top of any setpoints. The type of this schedule should be On/Off and values should be either 0 (no possibility of ventilation) or 1 (ventilation possible).</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"VentilationControlAbridged {iDd.Identifier}";
       
            return "VentilationControlAbridged";
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
            sb.Append("VentilationControlAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinIndoorTemperature: ").Append(MinIndoorTemperature).Append("\n");
            sb.Append("  MaxIndoorTemperature: ").Append(MaxIndoorTemperature).Append("\n");
            sb.Append("  MinOutdoorTemperature: ").Append(MinOutdoorTemperature).Append("\n");
            sb.Append("  MaxOutdoorTemperature: ").Append(MaxOutdoorTemperature).Append("\n");
            sb.Append("  DeltaTemperature: ").Append(DeltaTemperature).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>VentilationControlAbridged object</returns>
        public static VentilationControlAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<VentilationControlAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>VentilationControlAbridged object</returns>
        public virtual VentilationControlAbridged DuplicateVentilationControlAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateVentilationControlAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateVentilationControlAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VentilationControlAbridged);
        }

        /// <summary>
        /// Returns true if VentilationControlAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of VentilationControlAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VentilationControlAbridged input)
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
                    this.MinIndoorTemperature == input.MinIndoorTemperature ||
                    (this.MinIndoorTemperature != null &&
                    this.MinIndoorTemperature.Equals(input.MinIndoorTemperature))
                ) && base.Equals(input) && 
                (
                    this.MaxIndoorTemperature == input.MaxIndoorTemperature ||
                    (this.MaxIndoorTemperature != null &&
                    this.MaxIndoorTemperature.Equals(input.MaxIndoorTemperature))
                ) && base.Equals(input) && 
                (
                    this.MinOutdoorTemperature == input.MinOutdoorTemperature ||
                    (this.MinOutdoorTemperature != null &&
                    this.MinOutdoorTemperature.Equals(input.MinOutdoorTemperature))
                ) && base.Equals(input) && 
                (
                    this.MaxOutdoorTemperature == input.MaxOutdoorTemperature ||
                    (this.MaxOutdoorTemperature != null &&
                    this.MaxOutdoorTemperature.Equals(input.MaxOutdoorTemperature))
                ) && base.Equals(input) && 
                (
                    this.DeltaTemperature == input.DeltaTemperature ||
                    (this.DeltaTemperature != null &&
                    this.DeltaTemperature.Equals(input.DeltaTemperature))
                ) && base.Equals(input) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.MinIndoorTemperature != null)
                    hashCode = hashCode * 59 + this.MinIndoorTemperature.GetHashCode();
                if (this.MaxIndoorTemperature != null)
                    hashCode = hashCode * 59 + this.MaxIndoorTemperature.GetHashCode();
                if (this.MinOutdoorTemperature != null)
                    hashCode = hashCode * 59 + this.MinOutdoorTemperature.GetHashCode();
                if (this.MaxOutdoorTemperature != null)
                    hashCode = hashCode * 59 + this.MaxOutdoorTemperature.GetHashCode();
                if (this.DeltaTemperature != null)
                    hashCode = hashCode * 59 + this.DeltaTemperature.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
            Regex regexType = new Regex(@"^VentilationControlAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // MinIndoorTemperature (double) maximum
            if(this.MinIndoorTemperature > (double)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIndoorTemperature, must be a value less than or equal to 100.", new [] { "MinIndoorTemperature" });
            }

            // MinIndoorTemperature (double) minimum
            if(this.MinIndoorTemperature < (double)-100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIndoorTemperature, must be a value greater than or equal to -100.", new [] { "MinIndoorTemperature" });
            }


            
            // MaxIndoorTemperature (double) maximum
            if(this.MaxIndoorTemperature > (double)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxIndoorTemperature, must be a value less than or equal to 100.", new [] { "MaxIndoorTemperature" });
            }

            // MaxIndoorTemperature (double) minimum
            if(this.MaxIndoorTemperature < (double)-100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxIndoorTemperature, must be a value greater than or equal to -100.", new [] { "MaxIndoorTemperature" });
            }


            
            // MinOutdoorTemperature (double) maximum
            if(this.MinOutdoorTemperature > (double)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinOutdoorTemperature, must be a value less than or equal to 100.", new [] { "MinOutdoorTemperature" });
            }

            // MinOutdoorTemperature (double) minimum
            if(this.MinOutdoorTemperature < (double)-100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinOutdoorTemperature, must be a value greater than or equal to -100.", new [] { "MinOutdoorTemperature" });
            }


            
            // MaxOutdoorTemperature (double) maximum
            if(this.MaxOutdoorTemperature > (double)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxOutdoorTemperature, must be a value less than or equal to 100.", new [] { "MaxOutdoorTemperature" });
            }

            // MaxOutdoorTemperature (double) minimum
            if(this.MaxOutdoorTemperature < (double)-100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxOutdoorTemperature, must be a value greater than or equal to -100.", new [] { "MaxOutdoorTemperature" });
            }


            
            // DeltaTemperature (double) maximum
            if(this.DeltaTemperature > (double)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeltaTemperature, must be a value less than or equal to 100.", new [] { "DeltaTemperature" });
            }

            // DeltaTemperature (double) minimum
            if(this.DeltaTemperature < (double)-100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeltaTemperature, must be a value greater than or equal to -100.", new [] { "DeltaTemperature" });
            }

            // Schedule (string) maxLength
            if(this.Schedule != null && this.Schedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be less than 100.", new [] { "Schedule" });
            }

            // Schedule (string) minLength
            if(this.Schedule != null && this.Schedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be greater than 1.", new [] { "Schedule" });
            }
            
            yield break;
        }
    }
}
