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
    /// Opaque material representing a layer within an opaque construction.
    /// </summary>
    [DataContract]
    public partial class EnergyMaterial :  IEquatable<EnergyMaterial>, IValidatableObject
    {
        /// <summary>
        /// Defines Roughness
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoughnessEnum
        {
            /// <summary>
            /// Enum VeryRough for value: VeryRough
            /// </summary>
            [EnumMember(Value = "VeryRough")]
            VeryRough = 1,

            /// <summary>
            /// Enum Rough for value: Rough
            /// </summary>
            [EnumMember(Value = "Rough")]
            Rough = 2,

            /// <summary>
            /// Enum MediumRough for value: MediumRough
            /// </summary>
            [EnumMember(Value = "MediumRough")]
            MediumRough = 3,

            /// <summary>
            /// Enum MediumSmooth for value: MediumSmooth
            /// </summary>
            [EnumMember(Value = "MediumSmooth")]
            MediumSmooth = 4,

            /// <summary>
            /// Enum Smooth for value: Smooth
            /// </summary>
            [EnumMember(Value = "Smooth")]
            Smooth = 5,

            /// <summary>
            /// Enum VerySmooth for value: VerySmooth
            /// </summary>
            [EnumMember(Value = "VerySmooth")]
            VerySmooth = 6

        }

        /// <summary>
        /// Gets or Sets Roughness
        /// </summary>
        [DataMember(Name="roughness", EmitDefaultValue=false)]
        public RoughnessEnum? Roughness { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyMaterial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterial" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="thickness">Thickness of the material layer in meters. (required).</param>
        /// <param name="conductivity">Thermal conductivity of the material layer in W/(m-K). (required).</param>
        /// <param name="density">Density of the material layer in kg/m3. (required).</param>
        /// <param name="specificHeat">Specific heat of the material layer in J/(kg-K). (required).</param>
        /// <param name="type">type (default to &quot;EnergyMaterial&quot;).</param>
        /// <param name="roughness">roughness (default to RoughnessEnum.MediumRough).</param>
        /// <param name="thermalAbsorptance">Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9. (default to 0.9M).</param>
        /// <param name="solarAbsorptance">Fraction of incident solar radiation absorbed by the material. Default value is 0.7. (default to 0.7M).</param>
        /// <param name="visibleAbsorptance">Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7. (default to 0.7M).</param>
        public EnergyMaterial(string name, decimal thickness, decimal conductivity, decimal density, decimal specificHeat, string type = "EnergyMaterial", RoughnessEnum? roughness = RoughnessEnum.MediumRough, decimal thermalAbsorptance = 0.9M, decimal solarAbsorptance = 0.7M, decimal visibleAbsorptance = 0.7M)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EnergyMaterial and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "thickness" is required (not null)
            if (thickness == null)
            {
                throw new InvalidDataException("thickness is a required property for EnergyMaterial and cannot be null");
            }
            else
            {
                this.Thickness = thickness;
            }
            
            // to ensure "conductivity" is required (not null)
            if (conductivity == null)
            {
                throw new InvalidDataException("conductivity is a required property for EnergyMaterial and cannot be null");
            }
            else
            {
                this.Conductivity = conductivity;
            }
            
            // to ensure "density" is required (not null)
            if (density == null)
            {
                throw new InvalidDataException("density is a required property for EnergyMaterial and cannot be null");
            }
            else
            {
                this.Density = density;
            }
            
            // to ensure "specificHeat" is required (not null)
            if (specificHeat == null)
            {
                throw new InvalidDataException("specificHeat is a required property for EnergyMaterial and cannot be null");
            }
            else
            {
                this.SpecificHeat = specificHeat;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "EnergyMaterial";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "roughness" provided
            if (roughness == null)
            {
                this.Roughness = RoughnessEnum.MediumRough;
            }
            else
            {
                this.Roughness = roughness;
            }
            // use default value if no "thermalAbsorptance" provided
            if (thermalAbsorptance == null)
            {
                this.ThermalAbsorptance = 0.9M;
            }
            else
            {
                this.ThermalAbsorptance = thermalAbsorptance;
            }
            // use default value if no "solarAbsorptance" provided
            if (solarAbsorptance == null)
            {
                this.SolarAbsorptance = 0.7M;
            }
            else
            {
                this.SolarAbsorptance = solarAbsorptance;
            }
            // use default value if no "visibleAbsorptance" provided
            if (visibleAbsorptance == null)
            {
                this.VisibleAbsorptance = 0.7M;
            }
            else
            {
                this.VisibleAbsorptance = visibleAbsorptance;
            }
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Thickness of the material layer in meters.
        /// </summary>
        /// <value>Thickness of the material layer in meters.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        public decimal Thickness { get; set; }

        /// <summary>
        /// Thermal conductivity of the material layer in W/(m-K).
        /// </summary>
        /// <value>Thermal conductivity of the material layer in W/(m-K).</value>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        public decimal Conductivity { get; set; }

        /// <summary>
        /// Density of the material layer in kg/m3.
        /// </summary>
        /// <value>Density of the material layer in kg/m3.</value>
        [DataMember(Name="density", EmitDefaultValue=false)]
        public decimal Density { get; set; }

        /// <summary>
        /// Specific heat of the material layer in J/(kg-K).
        /// </summary>
        /// <value>Specific heat of the material layer in J/(kg-K).</value>
        [DataMember(Name="specific_heat", EmitDefaultValue=false)]
        public decimal SpecificHeat { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.
        /// </summary>
        /// <value>Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.</value>
        [DataMember(Name="thermal_absorptance", EmitDefaultValue=false)]
        public decimal ThermalAbsorptance { get; set; }

        /// <summary>
        /// Fraction of incident solar radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident solar radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="solar_absorptance", EmitDefaultValue=false)]
        public decimal SolarAbsorptance { get; set; }

        /// <summary>
        /// Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="visible_absorptance", EmitDefaultValue=false)]
        public decimal VisibleAbsorptance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyMaterial {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  Density: ").Append(Density).Append("\n");
            sb.Append("  SpecificHeat: ").Append(SpecificHeat).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            sb.Append("  ThermalAbsorptance: ").Append(ThermalAbsorptance).Append("\n");
            sb.Append("  SolarAbsorptance: ").Append(SolarAbsorptance).Append("\n");
            sb.Append("  VisibleAbsorptance: ").Append(VisibleAbsorptance).Append("\n");
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
            return this.Equals(input as EnergyMaterial);
        }

        /// <summary>
        /// Returns true if EnergyMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyMaterial input)
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
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
                ) && 
                (
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && 
                (
                    this.Density == input.Density ||
                    (this.Density != null &&
                    this.Density.Equals(input.Density))
                ) && 
                (
                    this.SpecificHeat == input.SpecificHeat ||
                    (this.SpecificHeat != null &&
                    this.SpecificHeat.Equals(input.SpecificHeat))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Roughness == input.Roughness ||
                    (this.Roughness != null &&
                    this.Roughness.Equals(input.Roughness))
                ) && 
                (
                    this.ThermalAbsorptance == input.ThermalAbsorptance ||
                    (this.ThermalAbsorptance != null &&
                    this.ThermalAbsorptance.Equals(input.ThermalAbsorptance))
                ) && 
                (
                    this.SolarAbsorptance == input.SolarAbsorptance ||
                    (this.SolarAbsorptance != null &&
                    this.SolarAbsorptance.Equals(input.SolarAbsorptance))
                ) && 
                (
                    this.VisibleAbsorptance == input.VisibleAbsorptance ||
                    (this.VisibleAbsorptance != null &&
                    this.VisibleAbsorptance.Equals(input.VisibleAbsorptance))
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
                if (this.Thickness != null)
                    hashCode = hashCode * 59 + this.Thickness.GetHashCode();
                if (this.Conductivity != null)
                    hashCode = hashCode * 59 + this.Conductivity.GetHashCode();
                if (this.Density != null)
                    hashCode = hashCode * 59 + this.Density.GetHashCode();
                if (this.SpecificHeat != null)
                    hashCode = hashCode * 59 + this.SpecificHeat.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Roughness != null)
                    hashCode = hashCode * 59 + this.Roughness.GetHashCode();
                if (this.ThermalAbsorptance != null)
                    hashCode = hashCode * 59 + this.ThermalAbsorptance.GetHashCode();
                if (this.SolarAbsorptance != null)
                    hashCode = hashCode * 59 + this.SolarAbsorptance.GetHashCode();
                if (this.VisibleAbsorptance != null)
                    hashCode = hashCode * 59 + this.VisibleAbsorptance.GetHashCode();
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

            // Thickness (decimal) maximum
            if(this.Thickness > (decimal)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Thickness, must be a value less than or equal to 3.", new [] { "Thickness" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyMaterial$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ThermalAbsorptance (decimal) maximum
            if(this.ThermalAbsorptance > (decimal)0.99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThermalAbsorptance, must be a value less than or equal to 0.99999.", new [] { "ThermalAbsorptance" });
            }

            // SolarAbsorptance (decimal) maximum
            if(this.SolarAbsorptance > (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value less than or equal to 1.", new [] { "SolarAbsorptance" });
            }

            // SolarAbsorptance (decimal) minimum
            if(this.SolarAbsorptance < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value greater than or equal to 0.", new [] { "SolarAbsorptance" });
            }

            // VisibleAbsorptance (decimal) maximum
            if(this.VisibleAbsorptance > (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value less than or equal to 1.", new [] { "VisibleAbsorptance" });
            }

            // VisibleAbsorptance (decimal) minimum
            if(this.VisibleAbsorptance < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value greater than or equal to 0.", new [] { "VisibleAbsorptance" });
            }

            yield break;
        }
    }

}
