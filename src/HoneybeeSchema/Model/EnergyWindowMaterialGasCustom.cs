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
    /// Create single layer of custom gas.
    /// </summary>
    [DataContract(Name = "EnergyWindowMaterialGasCustom")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class EnergyWindowMaterialGasCustom : IDdEnergyBaseModel, IEquatable<EnergyWindowMaterialGasCustom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGasCustom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialGasCustom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGasCustom" /> class.
        /// </summary>
        /// <param name="conductivityCoeffA">The A coefficient for gas conductivity in W/(m-K). (required).</param>
        /// <param name="viscosityCoeffA">The A coefficient for gas viscosity in kg/(m-s). (required).</param>
        /// <param name="specificHeatCoeffA">The A coefficient for gas specific heat in J/(kg-K). (required).</param>
        /// <param name="specificHeatRatio">The specific heat ratio for gas. (required).</param>
        /// <param name="molecularWeight">The molecular weight for gas in g/mol. (required).</param>
        /// <param name="thickness">Thickness of the gas layer in meters. Default value is 0.0125. (default to 0.0125D).</param>
        /// <param name="conductivityCoeffB">The B coefficient for gas conductivity in W/(m-K2). (default to 0D).</param>
        /// <param name="conductivityCoeffC">The C coefficient for gas conductivity in W/(m-K3). (default to 0D).</param>
        /// <param name="viscosityCoeffB">The B coefficient for gas viscosity in kg/(m-s-K). (default to 0D).</param>
        /// <param name="viscosityCoeffC">The C coefficient for gas viscosity in kg/(m-s-K2). (default to 0D).</param>
        /// <param name="specificHeatCoeffB">The B coefficient for gas specific heat in J/(kg-K2). (default to 0D).</param>
        /// <param name="specificHeatCoeffC">The C coefficient for gas specific heat in J/(kg-K3). (default to 0D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyWindowMaterialGasCustom
        (
            string identifier, double conductivityCoeffA, double viscosityCoeffA, double specificHeatCoeffA, double specificHeatRatio, double molecularWeight, // Required parameters
            string displayName= default, double thickness = 0.0125D, double conductivityCoeffB = 0D, double conductivityCoeffC = 0D, double viscosityCoeffB = 0D, double viscosityCoeffC = 0D, double specificHeatCoeffB = 0D, double specificHeatCoeffC = 0D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            this.ConductivityCoeffA = conductivityCoeffA;
            this.ViscosityCoeffA = viscosityCoeffA;
            this.SpecificHeatCoeffA = specificHeatCoeffA;
            this.SpecificHeatRatio = specificHeatRatio;
            this.MolecularWeight = molecularWeight;
            this.Thickness = thickness;
            this.ConductivityCoeffB = conductivityCoeffB;
            this.ConductivityCoeffC = conductivityCoeffC;
            this.ViscosityCoeffB = viscosityCoeffB;
            this.ViscosityCoeffC = viscosityCoeffC;
            this.SpecificHeatCoeffB = specificHeatCoeffB;
            this.SpecificHeatCoeffC = specificHeatCoeffC;
        }
        
        /// <summary>
        /// The A coefficient for gas conductivity in W/(m-K).
        /// </summary>
        /// <value>The A coefficient for gas conductivity in W/(m-K).</value>
        [DataMember(Name="conductivity_coeff_a", EmitDefaultValue=true)]
        public double ConductivityCoeffA { get; set; } 
        /// <summary>
        /// The A coefficient for gas viscosity in kg/(m-s).
        /// </summary>
        /// <value>The A coefficient for gas viscosity in kg/(m-s).</value>
        [DataMember(Name="viscosity_coeff_a", EmitDefaultValue=true)]
        public double ViscosityCoeffA { get; set; } 
        /// <summary>
        /// The A coefficient for gas specific heat in J/(kg-K).
        /// </summary>
        /// <value>The A coefficient for gas specific heat in J/(kg-K).</value>
        [DataMember(Name="specific_heat_coeff_a", EmitDefaultValue=true)]
        public double SpecificHeatCoeffA { get; set; } 
        /// <summary>
        /// The specific heat ratio for gas.
        /// </summary>
        /// <value>The specific heat ratio for gas.</value>
        [DataMember(Name="specific_heat_ratio", EmitDefaultValue=true)]
        public double SpecificHeatRatio { get; set; } 
        /// <summary>
        /// The molecular weight for gas in g/mol.
        /// </summary>
        /// <value>The molecular weight for gas in g/mol.</value>
        [DataMember(Name="molecular_weight", EmitDefaultValue=true)]
        public double MolecularWeight { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "EnergyWindowMaterialGasCustom";
        /// <summary>
        /// Thickness of the gas layer in meters. Default value is 0.0125.
        /// </summary>
        /// <value>Thickness of the gas layer in meters. Default value is 0.0125.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        public double Thickness { get; set; }  = 0.0125D;
        /// <summary>
        /// The B coefficient for gas conductivity in W/(m-K2).
        /// </summary>
        /// <value>The B coefficient for gas conductivity in W/(m-K2).</value>
        [DataMember(Name="conductivity_coeff_b", EmitDefaultValue=false)]
        public double ConductivityCoeffB { get; set; }  = 0D;
        /// <summary>
        /// The C coefficient for gas conductivity in W/(m-K3).
        /// </summary>
        /// <value>The C coefficient for gas conductivity in W/(m-K3).</value>
        [DataMember(Name="conductivity_coeff_c", EmitDefaultValue=false)]
        public double ConductivityCoeffC { get; set; }  = 0D;
        /// <summary>
        /// The B coefficient for gas viscosity in kg/(m-s-K).
        /// </summary>
        /// <value>The B coefficient for gas viscosity in kg/(m-s-K).</value>
        [DataMember(Name="viscosity_coeff_b", EmitDefaultValue=false)]
        public double ViscosityCoeffB { get; set; }  = 0D;
        /// <summary>
        /// The C coefficient for gas viscosity in kg/(m-s-K2).
        /// </summary>
        /// <value>The C coefficient for gas viscosity in kg/(m-s-K2).</value>
        [DataMember(Name="viscosity_coeff_c", EmitDefaultValue=false)]
        public double ViscosityCoeffC { get; set; }  = 0D;
        /// <summary>
        /// The B coefficient for gas specific heat in J/(kg-K2).
        /// </summary>
        /// <value>The B coefficient for gas specific heat in J/(kg-K2).</value>
        [DataMember(Name="specific_heat_coeff_b", EmitDefaultValue=false)]
        public double SpecificHeatCoeffB { get; set; }  = 0D;
        /// <summary>
        /// The C coefficient for gas specific heat in J/(kg-K3).
        /// </summary>
        /// <value>The C coefficient for gas specific heat in J/(kg-K3).</value>
        [DataMember(Name="specific_heat_coeff_c", EmitDefaultValue=false)]
        public double SpecificHeatCoeffC { get; set; }  = 0D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyWindowMaterialGasCustom {iDd.Identifier}";
       
            return "EnergyWindowMaterialGasCustom";
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
            sb.Append("EnergyWindowMaterialGasCustom:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ConductivityCoeffA: ").Append(ConductivityCoeffA).Append("\n");
            sb.Append("  ViscosityCoeffA: ").Append(ViscosityCoeffA).Append("\n");
            sb.Append("  SpecificHeatCoeffA: ").Append(SpecificHeatCoeffA).Append("\n");
            sb.Append("  SpecificHeatRatio: ").Append(SpecificHeatRatio).Append("\n");
            sb.Append("  MolecularWeight: ").Append(MolecularWeight).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  ConductivityCoeffB: ").Append(ConductivityCoeffB).Append("\n");
            sb.Append("  ConductivityCoeffC: ").Append(ConductivityCoeffC).Append("\n");
            sb.Append("  ViscosityCoeffB: ").Append(ViscosityCoeffB).Append("\n");
            sb.Append("  ViscosityCoeffC: ").Append(ViscosityCoeffC).Append("\n");
            sb.Append("  SpecificHeatCoeffB: ").Append(SpecificHeatCoeffB).Append("\n");
            sb.Append("  SpecificHeatCoeffC: ").Append(SpecificHeatCoeffC).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EnergyWindowMaterialGasCustom object</returns>
        public static EnergyWindowMaterialGasCustom FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EnergyWindowMaterialGasCustom>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EnergyWindowMaterialGasCustom object</returns>
        public EnergyWindowMaterialGasCustom DuplicateEnergyWindowMaterialGasCustom()
        {
            return FromJson(this.ToJson()) as EnergyWindowMaterialGasCustom;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
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
            return this.Equals(input as EnergyWindowMaterialGasCustom);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialGasCustom instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialGasCustom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialGasCustom input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.ConductivityCoeffA == input.ConductivityCoeffA ||
                    (this.ConductivityCoeffA != null &&
                    this.ConductivityCoeffA.Equals(input.ConductivityCoeffA))
                ) && base.Equals(input) && 
                (
                    this.ViscosityCoeffA == input.ViscosityCoeffA ||
                    (this.ViscosityCoeffA != null &&
                    this.ViscosityCoeffA.Equals(input.ViscosityCoeffA))
                ) && base.Equals(input) && 
                (
                    this.SpecificHeatCoeffA == input.SpecificHeatCoeffA ||
                    (this.SpecificHeatCoeffA != null &&
                    this.SpecificHeatCoeffA.Equals(input.SpecificHeatCoeffA))
                ) && base.Equals(input) && 
                (
                    this.SpecificHeatRatio == input.SpecificHeatRatio ||
                    (this.SpecificHeatRatio != null &&
                    this.SpecificHeatRatio.Equals(input.SpecificHeatRatio))
                ) && base.Equals(input) && 
                (
                    this.MolecularWeight == input.MolecularWeight ||
                    (this.MolecularWeight != null &&
                    this.MolecularWeight.Equals(input.MolecularWeight))
                ) && base.Equals(input) && 
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
                    this.ConductivityCoeffB == input.ConductivityCoeffB ||
                    (this.ConductivityCoeffB != null &&
                    this.ConductivityCoeffB.Equals(input.ConductivityCoeffB))
                ) && base.Equals(input) && 
                (
                    this.ConductivityCoeffC == input.ConductivityCoeffC ||
                    (this.ConductivityCoeffC != null &&
                    this.ConductivityCoeffC.Equals(input.ConductivityCoeffC))
                ) && base.Equals(input) && 
                (
                    this.ViscosityCoeffB == input.ViscosityCoeffB ||
                    (this.ViscosityCoeffB != null &&
                    this.ViscosityCoeffB.Equals(input.ViscosityCoeffB))
                ) && base.Equals(input) && 
                (
                    this.ViscosityCoeffC == input.ViscosityCoeffC ||
                    (this.ViscosityCoeffC != null &&
                    this.ViscosityCoeffC.Equals(input.ViscosityCoeffC))
                ) && base.Equals(input) && 
                (
                    this.SpecificHeatCoeffB == input.SpecificHeatCoeffB ||
                    (this.SpecificHeatCoeffB != null &&
                    this.SpecificHeatCoeffB.Equals(input.SpecificHeatCoeffB))
                ) && base.Equals(input) && 
                (
                    this.SpecificHeatCoeffC == input.SpecificHeatCoeffC ||
                    (this.SpecificHeatCoeffC != null &&
                    this.SpecificHeatCoeffC.Equals(input.SpecificHeatCoeffC))
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
                if (this.ConductivityCoeffA != null)
                    hashCode = hashCode * 59 + this.ConductivityCoeffA.GetHashCode();
                if (this.ViscosityCoeffA != null)
                    hashCode = hashCode * 59 + this.ViscosityCoeffA.GetHashCode();
                if (this.SpecificHeatCoeffA != null)
                    hashCode = hashCode * 59 + this.SpecificHeatCoeffA.GetHashCode();
                if (this.SpecificHeatRatio != null)
                    hashCode = hashCode * 59 + this.SpecificHeatRatio.GetHashCode();
                if (this.MolecularWeight != null)
                    hashCode = hashCode * 59 + this.MolecularWeight.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Thickness != null)
                    hashCode = hashCode * 59 + this.Thickness.GetHashCode();
                if (this.ConductivityCoeffB != null)
                    hashCode = hashCode * 59 + this.ConductivityCoeffB.GetHashCode();
                if (this.ConductivityCoeffC != null)
                    hashCode = hashCode * 59 + this.ConductivityCoeffC.GetHashCode();
                if (this.ViscosityCoeffB != null)
                    hashCode = hashCode * 59 + this.ViscosityCoeffB.GetHashCode();
                if (this.ViscosityCoeffC != null)
                    hashCode = hashCode * 59 + this.ViscosityCoeffC.GetHashCode();
                if (this.SpecificHeatCoeffB != null)
                    hashCode = hashCode * 59 + this.SpecificHeatCoeffB.GetHashCode();
                if (this.SpecificHeatCoeffC != null)
                    hashCode = hashCode * 59 + this.SpecificHeatCoeffC.GetHashCode();
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

            
            // MolecularWeight (double) maximum
            if(this.MolecularWeight > (double)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MolecularWeight, must be a value less than or equal to 200.", new [] { "MolecularWeight" });
            }

            // MolecularWeight (double) minimum
            if(this.MolecularWeight < (double)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MolecularWeight, must be a value greater than or equal to 20.", new [] { "MolecularWeight" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyWindowMaterialGasCustom$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
