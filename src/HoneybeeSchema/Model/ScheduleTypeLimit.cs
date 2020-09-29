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
    /// Specifies the data types and limits for values contained in schedules.
    /// </summary>
    [DataContract]
    public partial class ScheduleTypeLimit : IDdEnergyBaseModel, IEquatable<ScheduleTypeLimit>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets NumericType
        /// </summary>
        [DataMember(Name="numeric_type", EmitDefaultValue=false)]
        public ScheduleNumericType? NumericType { get; set; }   
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unit_type", EmitDefaultValue=false)]
        public ScheduleUnitType? UnitType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTypeLimit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleTypeLimit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTypeLimit" /> class.
        /// </summary>
        /// <param name="lowerLimit">Lower limit for the schedule type or NoLimit..</param>
        /// <param name="upperLimit">Upper limit for the schedule type or NoLimit..</param>
        /// <param name="numericType">numericType.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ScheduleTypeLimit
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<NoLimit,double> lowerLimit= default, AnyOf<NoLimit,double> upperLimit= default, ScheduleNumericType? numericType= default, ScheduleUnitType? unitType= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
            this.NumericType = numericType;
            this.UnitType = unitType;

            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleTypeLimit";
        }
        
        /// <summary>
        /// Lower limit for the schedule type or NoLimit.
        /// </summary>
        /// <value>Lower limit for the schedule type or NoLimit.</value>
        [DataMember(Name="lower_limit", EmitDefaultValue=false)]
        [JsonProperty("lower_limit")]
        public AnyOf<NoLimit,double> LowerLimit { get; set; } 
        /// <summary>
        /// Upper limit for the schedule type or NoLimit.
        /// </summary>
        /// <value>Upper limit for the schedule type or NoLimit.</value>
        [DataMember(Name="upper_limit", EmitDefaultValue=false)]
        [JsonProperty("upper_limit")]
        public AnyOf<NoLimit,double> UpperLimit { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ScheduleTypeLimit {iDd.Identifier}";
       
            return "ScheduleTypeLimit";
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
            sb.Append("ScheduleTypeLimit:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
            sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
            sb.Append("  NumericType: ").Append(NumericType).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ScheduleTypeLimit object</returns>
        public static ScheduleTypeLimit FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ScheduleTypeLimit>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ScheduleTypeLimit object</returns>
        public ScheduleTypeLimit DuplicateScheduleTypeLimit()
        {
            return Duplicate() as ScheduleTypeLimit;
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
            return this.Equals(input as ScheduleTypeLimit);
        }

        /// <summary>
        /// Returns true if ScheduleTypeLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleTypeLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleTypeLimit input)
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
                    this.LowerLimit == input.LowerLimit ||
                    (this.LowerLimit != null &&
                    this.LowerLimit.Equals(input.LowerLimit))
                ) && base.Equals(input) && 
                (
                    this.UpperLimit == input.UpperLimit ||
                    (this.UpperLimit != null &&
                    this.UpperLimit.Equals(input.UpperLimit))
                ) && base.Equals(input) && 
                (
                    this.NumericType == input.NumericType ||
                    (this.NumericType != null &&
                    this.NumericType.Equals(input.NumericType))
                ) && base.Equals(input) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
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
                if (this.LowerLimit != null)
                    hashCode = hashCode * 59 + this.LowerLimit.GetHashCode();
                if (this.UpperLimit != null)
                    hashCode = hashCode * 59 + this.UpperLimit.GetHashCode();
                if (this.NumericType != null)
                    hashCode = hashCode * 59 + this.NumericType.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
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
            Regex regexType = new Regex(@"^ScheduleTypeLimit$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
