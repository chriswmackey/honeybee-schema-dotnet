/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
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
using OpenAPIDateConverter = HoneybeeDotNet.Client.OpenAPIDateConverter;

namespace HoneybeeDotNet.Model
{
    /// <summary>
    /// A set of constructions for wall assemblies.
    /// </summary>
    [DataContract]
    public partial class WallSetAbridged :  IEquatable<WallSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallSetAbridged" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;WallSetAbridged&quot;).</param>
        /// <param name="interiorConstruction">Name for an OpaqueConstruction for walls with a Surface or Adiabatic boundary condition..</param>
        /// <param name="exteriorConstruction">Name for an OpaqueConstruction for walls with an Outdoors boundary condition..</param>
        /// <param name="groundConstruction">Name for an OpaqueConstruction for walls with a Ground boundary condition..</param>
        public WallSetAbridged(string type = "WallSetAbridged", string interiorConstruction = default(string), string exteriorConstruction = default(string), string groundConstruction = default(string))
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "WallSetAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.InteriorConstruction = interiorConstruction;
            this.ExteriorConstruction = exteriorConstruction;
            this.GroundConstruction = groundConstruction;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Name for an OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.
        /// </summary>
        /// <value>Name for an OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.</value>
        [DataMember(Name="interior_construction", EmitDefaultValue=false)]
        public string InteriorConstruction { get; set; }

        /// <summary>
        /// Name for an OpaqueConstruction for walls with an Outdoors boundary condition.
        /// </summary>
        /// <value>Name for an OpaqueConstruction for walls with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_construction", EmitDefaultValue=false)]
        public string ExteriorConstruction { get; set; }

        /// <summary>
        /// Name for an OpaqueConstruction for walls with a Ground boundary condition.
        /// </summary>
        /// <value>Name for an OpaqueConstruction for walls with a Ground boundary condition.</value>
        [DataMember(Name="ground_construction", EmitDefaultValue=false)]
        public string GroundConstruction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WallSetAbridged {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  ExteriorConstruction: ").Append(ExteriorConstruction).Append("\n");
            sb.Append("  GroundConstruction: ").Append(GroundConstruction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WallSetAbridged);
        }

        /// <summary>
        /// Returns true if WallSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of WallSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WallSetAbridged input)
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
                    this.ExteriorConstruction == input.ExteriorConstruction ||
                    (this.ExteriorConstruction != null &&
                    this.ExteriorConstruction.Equals(input.ExteriorConstruction))
                ) && 
                (
                    this.GroundConstruction == input.GroundConstruction ||
                    (this.GroundConstruction != null &&
                    this.GroundConstruction.Equals(input.GroundConstruction))
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
                if (this.ExteriorConstruction != null)
                    hashCode = hashCode * 59 + this.ExteriorConstruction.GetHashCode();
                if (this.GroundConstruction != null)
                    hashCode = hashCode * 59 + this.GroundConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^WallSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // InteriorConstruction (string) maxLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be less than 100.", new [] { "InteriorConstruction" });
            }

            // InteriorConstruction (string) minLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be greater than 1.", new [] { "InteriorConstruction" });
            }

            // ExteriorConstruction (string) maxLength
            if(this.ExteriorConstruction != null && this.ExteriorConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExteriorConstruction, length must be less than 100.", new [] { "ExteriorConstruction" });
            }

            // ExteriorConstruction (string) minLength
            if(this.ExteriorConstruction != null && this.ExteriorConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExteriorConstruction, length must be greater than 1.", new [] { "ExteriorConstruction" });
            }

            // GroundConstruction (string) maxLength
            if(this.GroundConstruction != null && this.GroundConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroundConstruction, length must be less than 100.", new [] { "GroundConstruction" });
            }

            // GroundConstruction (string) minLength
            if(this.GroundConstruction != null && this.GroundConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroundConstruction, length must be greater than 1.", new [] { "GroundConstruction" });
            }

            yield break;
        }
    }

}
