/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.34.2
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
    /// A single planar geometry that can be assigned to Radiance states.
    /// </summary>
    [DataContract]
    public partial class StateGeometryAbridged : IDdRadianceBaseModel, IEquatable<StateGeometryAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StateGeometryAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StateGeometryAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateGeometryAbridged" /> class.
        /// </summary>
        /// <param name="geometry">A ladybug_geometry Face3D. (required).</param>
        /// <param name="modifier">A string for a Honeybee Radiance Modifier identifier (default: None)..</param>
        /// <param name="modifierDirect">A string for Honeybee Radiance Modifier identifiers to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None)..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public StateGeometryAbridged
        (
            string identifier, Face3D geometry, // Required parameters
            string displayName= default, string modifier= default, string modifierDirect= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new InvalidDataException("geometry is a required property for StateGeometryAbridged and cannot be null");
            }
            else
            {
                this.Geometry = geometry;
            }
            
            this.Modifier = modifier;
            this.ModifierDirect = modifierDirect;

            // Set non-required readonly properties with defaultValue
            this.Type = "StateGeometryAbridged";
        }
        
        /// <summary>
        /// A ladybug_geometry Face3D.
        /// </summary>
        /// <value>A ladybug_geometry Face3D.</value>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        [JsonProperty("geometry")]
        public Face3D Geometry { get; set; } 
        /// <summary>
        /// A string for a Honeybee Radiance Modifier identifier (default: None).
        /// </summary>
        /// <value>A string for a Honeybee Radiance Modifier identifier (default: None).</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        [JsonProperty("modifier")]
        public string Modifier { get; set; } 
        /// <summary>
        /// A string for Honeybee Radiance Modifier identifiers to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None).
        /// </summary>
        /// <value>A string for Honeybee Radiance Modifier identifiers to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None).</value>
        [DataMember(Name="modifier_direct", EmitDefaultValue=false)]
        [JsonProperty("modifier_direct")]
        public string ModifierDirect { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"StateGeometryAbridged {iDd.Identifier}";
       
            return "StateGeometryAbridged";
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
            sb.Append("StateGeometryAbridged:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  ModifierDirect: ").Append(ModifierDirect).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StateGeometryAbridged object</returns>
        public static StateGeometryAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StateGeometryAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StateGeometryAbridged object</returns>
        public StateGeometryAbridged DuplicateStateGeometryAbridged()
        {
            return Duplicate() as StateGeometryAbridged;
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
            return this.Equals(input as StateGeometryAbridged);
        }

        /// <summary>
        /// Returns true if StateGeometryAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of StateGeometryAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateGeometryAbridged input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && base.Equals(input) && 
                (
                    this.ModifierDirect == input.ModifierDirect ||
                    (this.ModifierDirect != null &&
                    this.ModifierDirect.Equals(input.ModifierDirect))
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.ModifierDirect != null)
                    hashCode = hashCode * 59 + this.ModifierDirect.GetHashCode();
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
            Regex regexType = new Regex(@"^StateGeometryAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
