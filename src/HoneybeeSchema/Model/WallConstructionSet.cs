/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// A set of constructions for wall assemblies.
    /// </summary>
    [DataContract]
    public partial class WallConstructionSet : HoneybeeObject, IEquatable<WallConstructionSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstructionSet" /> class.
        /// </summary>
        /// <param name="interiorConstruction">An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition..</param>
        /// <param name="exteriorConstruction">An OpaqueConstruction for walls with an Outdoors boundary condition..</param>
        /// <param name="groundConstruction">An OpaqueConstruction for walls with a Ground boundary condition..</param>
        public WallConstructionSet
        (
             // Required parameters
            OpaqueConstruction interiorConstruction= default, OpaqueConstruction exteriorConstruction= default, OpaqueConstruction groundConstruction= default // Optional parameters
        )// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.ExteriorConstruction = exteriorConstruction;
            this.GroundConstruction = groundConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "WallConstructionSet";
        }
        
        /// <summary>
        /// An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.</value>
        [DataMember(Name="interior_construction", EmitDefaultValue=false)]
        [JsonProperty("interior_construction")]
        public OpaqueConstruction InteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for walls with an Outdoors boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_construction", EmitDefaultValue=false)]
        [JsonProperty("exterior_construction")]
        public OpaqueConstruction ExteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for walls with a Ground boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with a Ground boundary condition.</value>
        [DataMember(Name="ground_construction", EmitDefaultValue=false)]
        [JsonProperty("ground_construction")]
        public OpaqueConstruction GroundConstruction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"WallConstructionSet {iDd.Identifier}";
       
            return "WallConstructionSet";
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
            sb.Append("WallConstructionSet:\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  ExteriorConstruction: ").Append(ExteriorConstruction).Append("\n");
            sb.Append("  GroundConstruction: ").Append(GroundConstruction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WallConstructionSet object</returns>
        public static WallConstructionSet FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WallConstructionSet>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WallConstructionSet object</returns>
        public WallConstructionSet DuplicateWallConstructionSet()
        {
            return Duplicate() as WallConstructionSet;
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
            return this.Equals(input as WallConstructionSet);
        }

        /// <summary>
        /// Returns true if WallConstructionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of WallConstructionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WallConstructionSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InteriorConstruction == input.InteriorConstruction ||
                    (this.InteriorConstruction != null &&
                    this.InteriorConstruction.Equals(input.InteriorConstruction))
                ) && 
                (
                    this.ExteriorConstruction == input.ExteriorConstruction ||
                    (this.ExteriorConstruction != null &&
                    this.ExteriorConstruction.Equals(input.ExteriorConstruction))
                ) && 
                (
                    this.GroundConstruction == input.GroundConstruction ||
                    (this.GroundConstruction != null &&
                    this.GroundConstruction.Equals(input.GroundConstruction))
                ) && 
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
                int hashCode = 41;
                if (this.InteriorConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorConstruction.GetHashCode();
                if (this.ExteriorConstruction != null)
                    hashCode = hashCode * 59 + this.ExteriorConstruction.GetHashCode();
                if (this.GroundConstruction != null)
                    hashCode = hashCode * 59 + this.GroundConstruction.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^WallConstructionSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
