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
    /// A set of constructions for aperture assemblies.
    /// </summary>
    [DataContract]
    public partial class ApertureConstructionSet : HoneybeeObject, IEquatable<ApertureConstructionSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureConstructionSet" /> class.
        /// </summary>
        /// <param name="interiorConstruction">A WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face..</param>
        /// <param name="windowConstruction">A WindowConstruction for all apertures with a Surface boundary condition..</param>
        /// <param name="skylightConstruction">A WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face..</param>
        /// <param name="operableConstruction">A WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property..</param>
        public ApertureConstructionSet
        (
             // Required parameters
            WindowConstruction interiorConstruction= default, WindowConstruction windowConstruction= default, WindowConstruction skylightConstruction= default, WindowConstruction operableConstruction= default// Optional parameters
        )// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.WindowConstruction = windowConstruction;
            this.SkylightConstruction = skylightConstruction;
            this.OperableConstruction = operableConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureConstructionSet";
        }
        
        /// <summary>
        /// A WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face.
        /// </summary>
        /// <value>A WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face.</value>
        [DataMember(Name="interior_construction", EmitDefaultValue=false)]
        [JsonProperty("interior_construction")]
        public WindowConstruction InteriorConstruction { get; set; } 
        /// <summary>
        /// A WindowConstruction for all apertures with a Surface boundary condition.
        /// </summary>
        /// <value>A WindowConstruction for all apertures with a Surface boundary condition.</value>
        [DataMember(Name="window_construction", EmitDefaultValue=false)]
        [JsonProperty("window_construction")]
        public WindowConstruction WindowConstruction { get; set; } 
        /// <summary>
        /// A WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.
        /// </summary>
        /// <value>A WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.</value>
        [DataMember(Name="skylight_construction", EmitDefaultValue=false)]
        [JsonProperty("skylight_construction")]
        public WindowConstruction SkylightConstruction { get; set; } 
        /// <summary>
        /// A WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property.
        /// </summary>
        /// <value>A WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property.</value>
        [DataMember(Name="operable_construction", EmitDefaultValue=false)]
        [JsonProperty("operable_construction")]
        public WindowConstruction OperableConstruction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ApertureConstructionSet {iDd.Identifier}";
       
            return "ApertureConstructionSet";
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
            sb.Append("ApertureConstructionSet:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  WindowConstruction: ").Append(WindowConstruction).Append("\n");
            sb.Append("  SkylightConstruction: ").Append(SkylightConstruction).Append("\n");
            sb.Append("  OperableConstruction: ").Append(OperableConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureConstructionSet object</returns>
        public static ApertureConstructionSet FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureConstructionSet>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureConstructionSet object</returns>
        public ApertureConstructionSet DuplicateApertureConstructionSet()
        {
            return Duplicate() as ApertureConstructionSet;
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
            return this.Equals(input as ApertureConstructionSet);
        }

        /// <summary>
        /// Returns true if ApertureConstructionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureConstructionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureConstructionSet input)
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
                    this.InteriorConstruction == input.InteriorConstruction ||
                    (this.InteriorConstruction != null &&
                    this.InteriorConstruction.Equals(input.InteriorConstruction))
                ) && 
                (
                    this.WindowConstruction == input.WindowConstruction ||
                    (this.WindowConstruction != null &&
                    this.WindowConstruction.Equals(input.WindowConstruction))
                ) && 
                (
                    this.SkylightConstruction == input.SkylightConstruction ||
                    (this.SkylightConstruction != null &&
                    this.SkylightConstruction.Equals(input.SkylightConstruction))
                ) && 
                (
                    this.OperableConstruction == input.OperableConstruction ||
                    (this.OperableConstruction != null &&
                    this.OperableConstruction.Equals(input.OperableConstruction))
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
                if (this.InteriorConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorConstruction.GetHashCode();
                if (this.WindowConstruction != null)
                    hashCode = hashCode * 59 + this.WindowConstruction.GetHashCode();
                if (this.SkylightConstruction != null)
                    hashCode = hashCode * 59 + this.SkylightConstruction.GetHashCode();
                if (this.OperableConstruction != null)
                    hashCode = hashCode * 59 + this.OperableConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureConstructionSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
