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
    [DataContract(Name = "ShadeEnergyPropertiesAbridged")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class ShadeEnergyPropertiesAbridged : OpenAPIGenBaseModel, IEquatable<ShadeEnergyPropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShadeEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Identifier of a ShadeConstruction to set the reflectance and specularity of the Shade. If None, the construction is set by theparent Room construction_set, the Model global_construction_set or (in the case fo an orphaned shade) the EnergyPlus default of 0.2 diffuse reflectance..</param>
        /// <param name="transmittanceSchedule">Identifier of a schedule to set the transmittance of the shade, which can vary throughout the simulation. If None, the shade will be completely opaque..</param>
        public ShadeEnergyPropertiesAbridged
        (
             // Required parameters
            string construction= default, string transmittanceSchedule= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Construction = construction;
            this.TransmittanceSchedule = transmittanceSchedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "ShadeEnergyPropertiesAbridged";
        }

        /// <summary>
        /// Identifier of a ShadeConstruction to set the reflectance and specularity of the Shade. If None, the construction is set by theparent Room construction_set, the Model global_construction_set or (in the case fo an orphaned shade) the EnergyPlus default of 0.2 diffuse reflectance.
        /// </summary>
        /// <value>Identifier of a ShadeConstruction to set the reflectance and specularity of the Shade. If None, the construction is set by theparent Room construction_set, the Model global_construction_set or (in the case fo an orphaned shade) the EnergyPlus default of 0.2 diffuse reflectance.</value>
        [DataMember(Name = "construction", EmitDefaultValue = false)]
        
        public string Construction { get; set; } 
        /// <summary>
        /// Identifier of a schedule to set the transmittance of the shade, which can vary throughout the simulation. If None, the shade will be completely opaque.
        /// </summary>
        /// <value>Identifier of a schedule to set the transmittance of the shade, which can vary throughout the simulation. If None, the shade will be completely opaque.</value>
        [DataMember(Name = "transmittance_schedule", EmitDefaultValue = false)]
        
        public string TransmittanceSchedule { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ShadeEnergyPropertiesAbridged {iDd.Identifier}";
       
            return "ShadeEnergyPropertiesAbridged";
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
            sb.Append("ShadeEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
            sb.Append("  TransmittanceSchedule: ").Append(TransmittanceSchedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ShadeEnergyPropertiesAbridged object</returns>
        public static ShadeEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ShadeEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ShadeEnergyPropertiesAbridged object</returns>
        public virtual ShadeEnergyPropertiesAbridged DuplicateShadeEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateShadeEnergyPropertiesAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateShadeEnergyPropertiesAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShadeEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ShadeEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ShadeEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShadeEnergyPropertiesAbridged input)
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
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
                ) && base.Equals(input) && 
                (
                    this.TransmittanceSchedule == input.TransmittanceSchedule ||
                    (this.TransmittanceSchedule != null &&
                    this.TransmittanceSchedule.Equals(input.TransmittanceSchedule))
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.TransmittanceSchedule != null)
                    hashCode = hashCode * 59 + this.TransmittanceSchedule.GetHashCode();
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
            Regex regexType = new Regex(@"^ShadeEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }
            
            // TransmittanceSchedule (string) maxLength
            if(this.TransmittanceSchedule != null && this.TransmittanceSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittanceSchedule, length must be less than 100.", new [] { "TransmittanceSchedule" });
            }

            // TransmittanceSchedule (string) minLength
            if(this.TransmittanceSchedule != null && this.TransmittanceSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittanceSchedule, length must be greater than 1.", new [] { "TransmittanceSchedule" });
            }
            
            yield break;
        }
    }
}
