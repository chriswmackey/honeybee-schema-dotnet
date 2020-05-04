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
    /// Opaque material representing a layer within an opaque construction.
    /// </summary>
    [DataContract]
    public partial class EnergyMaterial : IDdEnergyBaseModel, IEquatable<EnergyMaterial>, IValidatableObject
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
        /// <param name="thickness">Thickness of the material layer in meters. (required).</param>
        /// <param name="conductivity">Thermal conductivity of the material layer in W/(m-K). (required).</param>
        /// <param name="density">Density of the material layer in kg/m3. (required).</param>
        /// <param name="specificHeat">Specific heat of the material layer in J/(kg-K). (required).</param>
        /// <param name="roughness">roughness (default to RoughnessEnum.MediumRough).</param>
        /// <param name="thermalAbsorptance">Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9. (default to 0.9D).</param>
        /// <param name="solarAbsorptance">Fraction of incident solar radiation absorbed by the material. Default value is 0.7. (default to 0.7D).</param>
        /// <param name="visibleAbsorptance">Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7. (default to 0.7D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyMaterial
        (
            string identifier, double thickness, double conductivity, double density, double specificHeat, // Required parameters
            RoughnessEnum? roughness = RoughnessEnum.MediumRough, double thermalAbsorptance = 0.9D, double solarAbsorptance = 0.7D, double visibleAbsorptance = 0.7D, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
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
                this.ThermalAbsorptance = 0.9D;
            }
            else
            {
                this.ThermalAbsorptance = thermalAbsorptance;
            }
            // use default value if no "solarAbsorptance" provided
            if (solarAbsorptance == null)
            {
                this.SolarAbsorptance = 0.7D;
            }
            else
            {
                this.SolarAbsorptance = solarAbsorptance;
            }
            // use default value if no "visibleAbsorptance" provided
            if (visibleAbsorptance == null)
            {
                this.VisibleAbsorptance = 0.7D;
            }
            else
            {
                this.VisibleAbsorptance = visibleAbsorptance;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyMaterial";
        }
        
        /// <summary>
        /// Thickness of the material layer in meters.
        /// </summary>
        /// <value>Thickness of the material layer in meters.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        [JsonProperty("thickness")]
        public double Thickness { get; set; }
        /// <summary>
        /// Thermal conductivity of the material layer in W/(m-K).
        /// </summary>
        /// <value>Thermal conductivity of the material layer in W/(m-K).</value>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        [JsonProperty("conductivity")]
        public double Conductivity { get; set; }
        /// <summary>
        /// Density of the material layer in kg/m3.
        /// </summary>
        /// <value>Density of the material layer in kg/m3.</value>
        [DataMember(Name="density", EmitDefaultValue=false)]
        [JsonProperty("density")]
        public double Density { get; set; }
        /// <summary>
        /// Specific heat of the material layer in J/(kg-K).
        /// </summary>
        /// <value>Specific heat of the material layer in J/(kg-K).</value>
        [DataMember(Name="specific_heat", EmitDefaultValue=false)]
        [JsonProperty("specific_heat")]
        public double SpecificHeat { get; set; }
        /// <summary>
        /// Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.
        /// </summary>
        /// <value>Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.</value>
        [DataMember(Name="thermal_absorptance", EmitDefaultValue=false)]
        [JsonProperty("thermal_absorptance")]
        public double ThermalAbsorptance { get; set; }
        /// <summary>
        /// Fraction of incident solar radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident solar radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="solar_absorptance", EmitDefaultValue=false)]
        [JsonProperty("solar_absorptance")]
        public double SolarAbsorptance { get; set; }
        /// <summary>
        /// Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="visible_absorptance", EmitDefaultValue=false)]
        [JsonProperty("visible_absorptance")]
        public double VisibleAbsorptance { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyMaterial {iDd.Identifier}";
       
            return "EnergyMaterial";
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
            sb.Append("EnergyMaterial:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  Density: ").Append(Density).Append("\n");
            sb.Append("  SpecificHeat: ").Append(SpecificHeat).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            sb.Append("  ThermalAbsorptance: ").Append(ThermalAbsorptance).Append("\n");
            sb.Append("  SolarAbsorptance: ").Append(SolarAbsorptance).Append("\n");
            sb.Append("  VisibleAbsorptance: ").Append(VisibleAbsorptance).Append("\n");
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
        /// <returns>EnergyMaterial object</returns>
        public static EnergyMaterial FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyMaterial>(json, new AnyOfJsonConverter());
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

            return base.Equals(input) && 
                (
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
                ) && base.Equals(input) && 
                (
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && base.Equals(input) && 
                (
                    this.Density == input.Density ||
                    (this.Density != null &&
                    this.Density.Equals(input.Density))
                ) && base.Equals(input) && 
                (
                    this.SpecificHeat == input.SpecificHeat ||
                    (this.SpecificHeat != null &&
                    this.SpecificHeat.Equals(input.SpecificHeat))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Roughness == input.Roughness ||
                    (this.Roughness != null &&
                    this.Roughness.Equals(input.Roughness))
                ) && base.Equals(input) && 
                (
                    this.ThermalAbsorptance == input.ThermalAbsorptance ||
                    (this.ThermalAbsorptance != null &&
                    this.ThermalAbsorptance.Equals(input.ThermalAbsorptance))
                ) && base.Equals(input) && 
                (
                    this.SolarAbsorptance == input.SolarAbsorptance ||
                    (this.SolarAbsorptance != null &&
                    this.SolarAbsorptance.Equals(input.SolarAbsorptance))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Thickness (double) maximum
            if(this.Thickness > (double)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Thickness, must be a value less than or equal to 3.", new [] { "Thickness" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyMaterial$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ThermalAbsorptance (double) maximum
            if(this.ThermalAbsorptance > (double)0.99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThermalAbsorptance, must be a value less than or equal to 0.99999.", new [] { "ThermalAbsorptance" });
            }

            // SolarAbsorptance (double) maximum
            if(this.SolarAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value less than or equal to 1.", new [] { "SolarAbsorptance" });
            }

            // SolarAbsorptance (double) minimum
            if(this.SolarAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value greater than or equal to 0.", new [] { "SolarAbsorptance" });
            }

            // VisibleAbsorptance (double) maximum
            if(this.VisibleAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value less than or equal to 1.", new [] { "VisibleAbsorptance" });
            }

            // VisibleAbsorptance (double) minimum
            if(this.VisibleAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value greater than or equal to 0.", new [] { "VisibleAbsorptance" });
            }

            yield break;
        }
    }

}
