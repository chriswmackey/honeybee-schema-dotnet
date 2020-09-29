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
    /// DoorPropertiesAbridged
    /// </summary>
    [DataContract]
    public partial class DoorPropertiesAbridged : HoneybeeObject, IEquatable<DoorPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="energy">energy.</param>
        /// <param name="radiance">radiance.</param>
        public DoorPropertiesAbridged
        (
             // Required parameters
            DoorEnergyPropertiesAbridged energy= default, DoorRadiancePropertiesAbridged radiance= default// Optional parameters
        )// BaseClass
        {
            this.Energy = energy;
            this.Radiance = radiance;

            // Set non-required readonly properties with defaultValue
            this.Type = "DoorPropertiesAbridged";
        }
        
        /// <summary>
        /// Gets or Sets Energy
        /// </summary>
        [DataMember(Name="energy", EmitDefaultValue=false)]
        [JsonProperty("energy")]
        public DoorEnergyPropertiesAbridged Energy { get; set; } 
        /// <summary>
        /// Gets or Sets Radiance
        /// </summary>
        [DataMember(Name="radiance", EmitDefaultValue=false)]
        [JsonProperty("radiance")]
        public DoorRadiancePropertiesAbridged Radiance { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DoorPropertiesAbridged {iDd.Identifier}";
       
            return "DoorPropertiesAbridged";
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
            sb.Append("DoorPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Energy: ").Append(Energy).Append("\n");
            sb.Append("  Radiance: ").Append(Radiance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DoorPropertiesAbridged object</returns>
        public static DoorPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DoorPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DoorPropertiesAbridged object</returns>
        public DoorPropertiesAbridged DuplicateDoorPropertiesAbridged()
        {
            return Duplicate() as DoorPropertiesAbridged;
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
            return this.Equals(input as DoorPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if DoorPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of DoorPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoorPropertiesAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Energy == input.Energy ||
                    (this.Energy != null &&
                    this.Energy.Equals(input.Energy))
                ) && 
                (
                    this.Radiance == input.Radiance ||
                    (this.Radiance != null &&
                    this.Radiance.Equals(input.Radiance))
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
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Energy != null)
                    hashCode = hashCode * 59 + this.Energy.GetHashCode();
                if (this.Radiance != null)
                    hashCode = hashCode * 59 + this.Radiance.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^DoorPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
