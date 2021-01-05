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
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// RadianceShadeStateAbridged represents a single state for a dynamic Shade.
    /// </summary>
    [DataContract(Name = "RadianceShadeStateAbridged")]
    public partial class RadianceShadeStateAbridged : OpenAPIGenBaseModel, IEquatable<RadianceShadeStateAbridged>, IValidatableObject
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
        ) : base()// BaseClass
        {
            this.Modifier = modifier;
            this.ModifierDirect = modifierDirect;
            this.Shades = shades;

            // Set non-required readonly properties with defaultValue
            this.Type = "RadianceShadeStateAbridged";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "RadianceShadeStateAbridged";

        /// <summary>
        /// A Radiance Modifier identifier (default: None).
        /// </summary>
        /// <value>A Radiance Modifier identifier (default: None).</value>
        [DataMember(Name = "modifier")]
        public string Modifier { get; set; } 
        /// <summary>
        /// A Radiance Modifier identifier (default: None).
        /// </summary>
        /// <value>A Radiance Modifier identifier (default: None).</value>
        [DataMember(Name = "modifier_direct")]
        public string ModifierDirect { get; set; } 
        /// <summary>
        /// A list of StateGeometryAbridged objects (default: None).
        /// </summary>
        /// <value>A list of StateGeometryAbridged objects (default: None).</value>
        [DataMember(Name = "shades")]
        public List<StateGeometryAbridged> Shades { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        public virtual RadianceShadeStateAbridged DuplicateRadianceShadeStateAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRadianceShadeStateAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRadianceShadeStateAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
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
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
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
