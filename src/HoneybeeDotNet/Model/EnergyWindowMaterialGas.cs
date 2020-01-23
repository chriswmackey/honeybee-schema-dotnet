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
    /// Create single layer of gas in a window construction.  Can be combined with EnergyWindowMaterialGlazing to make multi-pane windows.
    /// </summary>
    [DataContract]
    public partial class EnergyWindowMaterialGas :  IEquatable<EnergyWindowMaterialGas>, IValidatableObject
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
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="type">type (default to &quot;EnergyWindowMaterialGas&quot;).</param>
        /// <param name="thickness">Thickness of the gas layer in meters. Default value is 0.0125. (default to 0.0125M).</param>
        /// <param name="gasType">gasType (default to GasTypeEnum.Air).</param>
        public EnergyWindowMaterialGas(string name, string type = "EnergyWindowMaterialGas", decimal thickness = 0.0125M, GasTypeEnum? gasType = GasTypeEnum.Air)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EnergyWindowMaterialGas and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "EnergyWindowMaterialGas";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "thickness" provided
            if (thickness == null)
            {
                this.Thickness = 0.0125M;
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
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Thickness of the gas layer in meters. Default value is 0.0125.
        /// </summary>
        /// <value>Thickness of the gas layer in meters. Default value is 0.0125.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        public decimal Thickness { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyWindowMaterialGas {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  GasType: ").Append(GasType).Append("\n");
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

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
                ) && 
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
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

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
