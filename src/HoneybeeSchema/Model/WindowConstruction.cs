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
    /// Construction for window objects (Aperture, Door).
    /// </summary>
    [DataContract(Name = "WindowConstruction")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class WindowConstruction : WindowConstructionAbridged, IEquatable<WindowConstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowConstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction" /> class.
        /// </summary>
        /// <param name="materials">List of glazing and gas materials. The order of the materials is from outside to inside. If a SimpleGlazSys material is used, it must be the only material in the construction. For multi-layered constructions, adjacent glass layers must be separated by one and only one gas layer. (required).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="layers">List of strings for glazing or gas material identifiers. The order of the materials is from exterior to interior. If a SimpleGlazSys material is used, it must be the only material in the construction. For multi-layered constructions, adjacent glass layers must be separated by one and only one gas layer. (required).</param>
        public WindowConstruction
        (
            string identifier, List<string> layers, List<AnyOf<EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialGlazing,EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture>> materials, // Required parameters
            string displayName= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName, layers: layers)// BaseClass
        {
            // to ensure "materials" is required (not null)
            this.Materials = materials ?? throw new ArgumentNullException("materials is a required property for WindowConstruction and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "WindowConstruction";
        }

        /// <summary>
        /// List of glazing and gas materials. The order of the materials is from outside to inside. If a SimpleGlazSys material is used, it must be the only material in the construction. For multi-layered constructions, adjacent glass layers must be separated by one and only one gas layer.
        /// </summary>
        /// <value>List of glazing and gas materials. The order of the materials is from outside to inside. If a SimpleGlazSys material is used, it must be the only material in the construction. For multi-layered constructions, adjacent glass layers must be separated by one and only one gas layer.</value>
        [DataMember(Name = "materials", IsRequired = true, EmitDefaultValue = false)]
        
        public List<AnyOf<EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialGlazing,EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture>> Materials { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"WindowConstruction {iDd.Identifier}";
       
            return "WindowConstruction";
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
            sb.Append("WindowConstruction:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowConstruction object</returns>
        public static WindowConstruction FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WindowConstruction>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowConstruction object</returns>
        public virtual WindowConstruction DuplicateWindowConstruction()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateWindowConstruction();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override WindowConstructionAbridged DuplicateWindowConstructionAbridged()
        {
            return DuplicateWindowConstruction();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WindowConstruction);
        }

        /// <summary>
        /// Returns true if WindowConstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowConstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowConstruction input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^WindowConstruction$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
