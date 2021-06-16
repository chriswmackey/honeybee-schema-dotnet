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
    /// Create single layer of gas in a window construction.  Can be combined with EnergyWindowMaterialGlazing to make multi-pane windows.
    /// </summary>
    [DataContract(Name = "EnergyWindowMaterialGas")]
    public partial class EnergyWindowMaterialGas : IDdEnergyBaseModel, IEquatable<EnergyWindowMaterialGas>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GasType
        /// </summary>
        [DataMember(Name="gas_type")]
        public GasType GasType { get; set; } = GasType.Air;
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialGas() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyWindowMaterialGas";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGas" /> class.
        /// </summary>
        /// <param name="thickness">Thickness of the gas layer in meters. Default value is 0.0125. (default to 0.0125D).</param>
        /// <param name="gasType">gasType.</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyWindowMaterialGas
        (
            string identifier, // Required parameters
            string displayName= default, double thickness = 0.0125D, GasType gasType= GasType.Air// Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            this.Thickness = thickness;
            this.GasType = gasType;

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyWindowMaterialGas";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(EnergyWindowMaterialGas))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "EnergyWindowMaterialGas";

        /// <summary>
        /// Thickness of the gas layer in meters. Default value is 0.0125.
        /// </summary>
        /// <value>Thickness of the gas layer in meters. Default value is 0.0125.</value>
        [DataMember(Name = "thickness")]
        public double Thickness { get; set; }  = 0.0125D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "EnergyWindowMaterialGas";
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
            sb.Append("EnergyWindowMaterialGas:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  GasType: ").Append(GasType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EnergyWindowMaterialGas object</returns>
        public static EnergyWindowMaterialGas FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EnergyWindowMaterialGas>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EnergyWindowMaterialGas object</returns>
        public virtual EnergyWindowMaterialGas DuplicateEnergyWindowMaterialGas()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateEnergyWindowMaterialGas();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateEnergyWindowMaterialGas();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as EnergyWindowMaterialGas);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialGas instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialGas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialGas input)
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
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
                ) && base.Equals(input) && 
                (
                    this.GasType == input.GasType ||
                    (this.GasType != null &&
                    this.GasType.Equals(input.GasType))
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
                if (this.Thickness != null)
                    hashCode = hashCode * 59 + this.Thickness.GetHashCode();
                if (this.GasType != null)
                    hashCode = hashCode * 59 + this.GasType.GetHashCode();
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
            Regex regexType = new Regex(@"^EnergyWindowMaterialGas$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
