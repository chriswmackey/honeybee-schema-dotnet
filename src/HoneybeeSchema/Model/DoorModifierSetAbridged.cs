/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.34.0
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
    /// Abridged set containing radiance modifiers needed for a model&#39;s Doors.
    /// </summary>
    [DataContract]
    public partial class DoorModifierSetAbridged : BaseModifierSetAbridged, IEquatable<DoorModifierSetAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorModifierSetAbridged" /> class.
        /// </summary>
        /// <param name="interiorGlassModifier">Identifier of modifier object for glass with a Surface boundary condition..</param>
        /// <param name="exteriorGlassModifier">Identifier of modifier object for glass with an Outdoors boundary condition..</param>
        /// <param name="overheadModifier">Identifier of a modifier object for doors with an Outdoors boundary condition and a RoofCeiling or Floor face type for their parent face..</param>
        /// <param name="exteriorModifier">Identifier for a radiance modifier object for faces with an  Outdoors boundary condition..</param>
        /// <param name="interiorModifier">Identifier for a radiance modifier object for faces with a boundary condition other than Outdoors..</param>
        public DoorModifierSetAbridged
        (
             // Required parameters
            string exteriorModifier= default, string interiorModifier= default, string interiorGlassModifier= default, string exteriorGlassModifier= default, string overheadModifier= default// Optional parameters
        ) : base(exteriorModifier: exteriorModifier, interiorModifier: interiorModifier )// BaseClass
        {
            this.InteriorGlassModifier = interiorGlassModifier;
            this.ExteriorGlassModifier = exteriorGlassModifier;
            this.OverheadModifier = overheadModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "DoorModifierSetAbridged";
        }
        
        /// <summary>
        /// Identifier of modifier object for glass with a Surface boundary condition.
        /// </summary>
        /// <value>Identifier of modifier object for glass with a Surface boundary condition.</value>
        [DataMember(Name="interior_glass_modifier", EmitDefaultValue=false)]
        [JsonProperty("interior_glass_modifier")]
        public string InteriorGlassModifier { get; set; } 
        /// <summary>
        /// Identifier of modifier object for glass with an Outdoors boundary condition.
        /// </summary>
        /// <value>Identifier of modifier object for glass with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_glass_modifier", EmitDefaultValue=false)]
        [JsonProperty("exterior_glass_modifier")]
        public string ExteriorGlassModifier { get; set; } 
        /// <summary>
        /// Identifier of a modifier object for doors with an Outdoors boundary condition and a RoofCeiling or Floor face type for their parent face.
        /// </summary>
        /// <value>Identifier of a modifier object for doors with an Outdoors boundary condition and a RoofCeiling or Floor face type for their parent face.</value>
        [DataMember(Name="overhead_modifier", EmitDefaultValue=false)]
        [JsonProperty("overhead_modifier")]
        public string OverheadModifier { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DoorModifierSetAbridged {iDd.Identifier}";
       
            return "DoorModifierSetAbridged";
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
            sb.Append("DoorModifierSetAbridged:\n");
            sb.Append("  ExteriorModifier: ").Append(ExteriorModifier).Append("\n");
            sb.Append("  InteriorModifier: ").Append(InteriorModifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InteriorGlassModifier: ").Append(InteriorGlassModifier).Append("\n");
            sb.Append("  ExteriorGlassModifier: ").Append(ExteriorGlassModifier).Append("\n");
            sb.Append("  OverheadModifier: ").Append(OverheadModifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DoorModifierSetAbridged object</returns>
        public static DoorModifierSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DoorModifierSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DoorModifierSetAbridged object</returns>
        public DoorModifierSetAbridged DuplicateDoorModifierSetAbridged()
        {
            return Duplicate() as DoorModifierSetAbridged;
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
            return this.Equals(input as DoorModifierSetAbridged);
        }

        /// <summary>
        /// Returns true if DoorModifierSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of DoorModifierSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoorModifierSetAbridged input)
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
                    this.InteriorGlassModifier == input.InteriorGlassModifier ||
                    (this.InteriorGlassModifier != null &&
                    this.InteriorGlassModifier.Equals(input.InteriorGlassModifier))
                ) && base.Equals(input) && 
                (
                    this.ExteriorGlassModifier == input.ExteriorGlassModifier ||
                    (this.ExteriorGlassModifier != null &&
                    this.ExteriorGlassModifier.Equals(input.ExteriorGlassModifier))
                ) && base.Equals(input) && 
                (
                    this.OverheadModifier == input.OverheadModifier ||
                    (this.OverheadModifier != null &&
                    this.OverheadModifier.Equals(input.OverheadModifier))
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
                if (this.InteriorGlassModifier != null)
                    hashCode = hashCode * 59 + this.InteriorGlassModifier.GetHashCode();
                if (this.ExteriorGlassModifier != null)
                    hashCode = hashCode * 59 + this.ExteriorGlassModifier.GetHashCode();
                if (this.OverheadModifier != null)
                    hashCode = hashCode * 59 + this.OverheadModifier.GetHashCode();
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
            Regex regexType = new Regex(@"^DoorModifierSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
