/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.0
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
    /// Set containing radiance modifiers needed for a model&#39;s Apertures.
    /// </summary>
    [DataContract]
    public partial class ApertureModifierSet : HoneybeeObject, IEquatable<ApertureModifierSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureModifierSet" /> class.
        /// </summary>
        /// <param name="windowModifier">A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face..</param>
        /// <param name="interiorModifier">A modifier object for apertures with a Surface boundary condition..</param>
        /// <param name="skylightModifier">A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face..</param>
        /// <param name="operableModifier">A modifier object for apertures with an Outdoors boundary condition and a True is_operable property..</param>
        public ApertureModifierSet
        ( // Required parameters
            AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> windowModifier= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> interiorModifier= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> skylightModifier= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> operableModifier= default// Optional parameters
        )// BaseClass
        {
            this.WindowModifier = windowModifier;
            this.InteriorModifier = interiorModifier;
            this.SkylightModifier = skylightModifier;
            this.OperableModifier = operableModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureModifierSet";
        }
        
        /// <summary>
        /// A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face.
        /// </summary>
        /// <value>A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face.</value>
        [DataMember(Name="window_modifier", EmitDefaultValue=false)]
        [JsonProperty("window_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> WindowModifier { get; set; }
        /// <summary>
        /// A modifier object for apertures with a Surface boundary condition.
        /// </summary>
        /// <value>A modifier object for apertures with a Surface boundary condition.</value>
        [DataMember(Name="interior_modifier", EmitDefaultValue=false)]
        [JsonProperty("interior_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> InteriorModifier { get; set; }
        /// <summary>
        /// A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.
        /// </summary>
        /// <value>A modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.</value>
        [DataMember(Name="skylight_modifier", EmitDefaultValue=false)]
        [JsonProperty("skylight_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> SkylightModifier { get; set; }
        /// <summary>
        /// A modifier object for apertures with an Outdoors boundary condition and a True is_operable property.
        /// </summary>
        /// <value>A modifier object for apertures with an Outdoors boundary condition and a True is_operable property.</value>
        [DataMember(Name="operable_modifier", EmitDefaultValue=false)]
        [JsonProperty("operable_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Void,Mirror> OperableModifier { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ApertureModifierSet {iDd.Identifier}";
       
            return "ApertureModifierSet";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("ApertureModifierSet:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WindowModifier: ").Append(WindowModifier).Append("\n");
            sb.Append("  InteriorModifier: ").Append(InteriorModifier).Append("\n");
            sb.Append("  SkylightModifier: ").Append(SkylightModifier).Append("\n");
            sb.Append("  OperableModifier: ").Append(OperableModifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureModifierSet object</returns>
        public static ApertureModifierSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ApertureModifierSet>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApertureModifierSet);
        }

        /// <summary>
        /// Returns true if ApertureModifierSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureModifierSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureModifierSet input)
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
                    this.WindowModifier == input.WindowModifier ||
                    (this.WindowModifier != null &&
                    this.WindowModifier.Equals(input.WindowModifier))
                ) && 
                (
                    this.InteriorModifier == input.InteriorModifier ||
                    (this.InteriorModifier != null &&
                    this.InteriorModifier.Equals(input.InteriorModifier))
                ) && 
                (
                    this.SkylightModifier == input.SkylightModifier ||
                    (this.SkylightModifier != null &&
                    this.SkylightModifier.Equals(input.SkylightModifier))
                ) && 
                (
                    this.OperableModifier == input.OperableModifier ||
                    (this.OperableModifier != null &&
                    this.OperableModifier.Equals(input.OperableModifier))
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
                if (this.WindowModifier != null)
                    hashCode = hashCode * 59 + this.WindowModifier.GetHashCode();
                if (this.InteriorModifier != null)
                    hashCode = hashCode * 59 + this.InteriorModifier.GetHashCode();
                if (this.SkylightModifier != null)
                    hashCode = hashCode * 59 + this.SkylightModifier.GetHashCode();
                if (this.OperableModifier != null)
                    hashCode = hashCode * 59 + this.OperableModifier.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureModifierSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
