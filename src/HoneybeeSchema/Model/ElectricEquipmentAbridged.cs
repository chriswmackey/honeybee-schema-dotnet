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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract(Name = "ElectricEquipmentAbridged")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class ElectricEquipmentAbridged : EquipmentBase, IEquatable<ElectricEquipmentAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipmentAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectricEquipmentAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipmentAbridged" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">Identifier of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. (required).</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0. (default to 0D).</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by electricequipment. Default value is 0. (default to 0D).</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0. (default to 0D).</param>
        public ElectricEquipmentAbridged
        (
            string identifier, double wattsPerArea, string schedule, // Required parameters
            string displayName= default, double radiantFraction = 0D, double latentFraction = 0D, double lostFraction = 0D // Optional parameters
        ) : base(identifier: identifier, displayName: displayName, wattsPerArea: wattsPerArea, schedule: schedule, radiantFraction: radiantFraction, latentFraction: latentFraction, lostFraction: lostFraction)// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "ElectricEquipmentAbridged";
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ElectricEquipmentAbridged {iDd.Identifier}";
       
            return "ElectricEquipmentAbridged";
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
            sb.Append("ElectricEquipmentAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(LostFraction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ElectricEquipmentAbridged object</returns>
        public static ElectricEquipmentAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ElectricEquipmentAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ElectricEquipmentAbridged object</returns>
        public ElectricEquipmentAbridged DuplicateElectricEquipmentAbridged()
        {
            return FromJson(this.ToJson()) as ElectricEquipmentAbridged;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
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
            return this.Equals(input as ElectricEquipmentAbridged);
        }

        /// <summary>
        /// Returns true if ElectricEquipmentAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectricEquipmentAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectricEquipmentAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
            Regex regexType = new Regex(@"^ElectricEquipmentAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
