/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.35.0
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
    /// RadianceShadeStateAbridged represents a single state for a dynamic Shade.
    /// </summary>
    [DataContract]
    public partial class RadianceShadeStateAbridged : HoneybeeObject, IEquatable<RadianceShadeStateAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RadianceShadeStateAbridged" /> class.
        /// </summary>
        /// <param name="modifier">A Radiance Modifier identifier (default: None)..</param>
        /// <param name="modifierDirect">A Radiance Modifier identifier (default: None)..</param>
        /// <param name="shades">A list of StateGeometryAbridged objects (default: None)..</param>
        public RadianceShadeStateAbridged
        (
             // Required parameters
            string modifier= default, string modifierDirect= default, List<StateGeometryAbridged> shades= default// Optional parameters
        )// BaseClass
        {
            this.Modifier = modifier;
            this.ModifierDirect = modifierDirect;
            this.Shades = shades;

            // Set non-required readonly properties with defaultValue
            this.Type = "RadianceShadeStateAbridged";
        }
        
        /// <summary>
        /// A Radiance Modifier identifier (default: None).
        /// </summary>
        /// <value>A Radiance Modifier identifier (default: None).</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        [JsonProperty("modifier")]
        public string Modifier { get; set; } 
        /// <summary>
        /// A Radiance Modifier identifier (default: None).
        /// </summary>
        /// <value>A Radiance Modifier identifier (default: None).</value>
        [DataMember(Name="modifier_direct", EmitDefaultValue=false)]
        [JsonProperty("modifier_direct")]
        public string ModifierDirect { get; set; } 
        /// <summary>
        /// A list of StateGeometryAbridged objects (default: None).
        /// </summary>
        /// <value>A list of StateGeometryAbridged objects (default: None).</value>
        [DataMember(Name="shades", EmitDefaultValue=false)]
        [JsonProperty("shades")]
        public List<StateGeometryAbridged> Shades { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RadianceShadeStateAbridged {iDd.Identifier}";
       
            return "RadianceShadeStateAbridged";
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
            sb.Append("RadianceShadeStateAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  ModifierDirect: ").Append(ModifierDirect).Append("\n");
            sb.Append("  Shades: ").Append(Shades).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RadianceShadeStateAbridged object</returns>
        public static RadianceShadeStateAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RadianceShadeStateAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RadianceShadeStateAbridged object</returns>
        public RadianceShadeStateAbridged DuplicateRadianceShadeStateAbridged()
        {
            return Duplicate() as RadianceShadeStateAbridged;
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
            return this.Equals(input as RadianceShadeStateAbridged);
        }

        /// <summary>
        /// Returns true if RadianceShadeStateAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of RadianceShadeStateAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadianceShadeStateAbridged input)
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
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && 
                (
                    this.ModifierDirect == input.ModifierDirect ||
                    (this.ModifierDirect != null &&
                    this.ModifierDirect.Equals(input.ModifierDirect))
                ) && 
                (
                    this.Shades == input.Shades ||
                    this.Shades != null &&
                    input.Shades != null &&
                    this.Shades.SequenceEqual(input.Shades)
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
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.ModifierDirect != null)
                    hashCode = hashCode * 59 + this.ModifierDirect.GetHashCode();
                if (this.Shades != null)
                    hashCode = hashCode * 59 + this.Shades.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^RadianceShadeStateAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
