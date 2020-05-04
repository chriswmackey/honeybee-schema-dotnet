/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.1
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
    [DataContract]
    public partial class EnergyWindowMaterialGas : IDdEnergyBaseModel, IEquatable<EnergyWindowMaterialGas>, IValidatableObject
    {

        /// <summary>
        /// Defines GasType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GasTypeEnum
        {
            /// <summary>
            /// Enum Air for value: Air
            /// </summary>
            [EnumMember(Value = "Air")]
            Air = 1,

            /// <summary>
            /// Enum Argon for value: Argon
            /// </summary>
            [EnumMember(Value = "Argon")]
            Argon = 2,

            /// <summary>
            /// Enum Krypton for value: Krypton
            /// </summary>
            [EnumMember(Value = "Krypton")]
            Krypton = 3,

            /// <summary>
            /// Enum Xenon for value: Xenon
            /// </summary>
            [EnumMember(Value = "Xenon")]
            Xenon = 4

        }

        /// <summary>
        /// Gets or Sets GasType
        /// </summary>
        [DataMember(Name="gas_type", EmitDefaultValue=false)]
        public GasTypeEnum? GasType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialGas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGas" /> class.
        /// </summary>
        /// <param name="thickness">Thickness of the gas layer in meters. Default value is 0.0125. (default to 0.0125D).</param>
        /// <param name="gasType">gasType (default to GasTypeEnum.Air).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyWindowMaterialGas
        (
            string identifier, // Required parameters
            double thickness = 0.0125D, GasTypeEnum? gasType = GasTypeEnum.Air, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // use default value if no "thickness" provided
            if (thickness == null)
            {
                this.Thickness = 0.0125D;
            }
            else
            {
                this.Thickness = thickness;
            }
            // use default value if no "gasType" provided
            if (gasType == null)
            {
                this.GasType = GasTypeEnum.Air;
            }
            else
            {
                this.GasType = gasType;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyWindowMaterialGas";
        }
        
        /// <summary>
        /// Thickness of the gas layer in meters. Default value is 0.0125.
        /// </summary>
        /// <value>Thickness of the gas layer in meters. Default value is 0.0125.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        [JsonProperty("thickness")]
        public double Thickness { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyWindowMaterialGas {iDd.Identifier}";
       
            return "EnergyWindowMaterialGas";
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
            sb.Append("EnergyWindowMaterialGas:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  GasType: ").Append(GasType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EnergyWindowMaterialGas object</returns>
        public static EnergyWindowMaterialGas FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyWindowMaterialGas>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
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
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
