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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract(Name = "IDdEnergyBaseModel")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGlazing), "EnergyWindowMaterialGlazing")]
    [JsonSubtypes.KnownSubType(typeof(Residential), "Residential")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleRulesetAbridged), "ScheduleRulesetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(AirBoundaryConstruction), "AirBoundaryConstruction")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGas), "EnergyWindowMaterialGas")]
    [JsonSubtypes.KnownSubType(typeof(DOASBase), "_DOASBase")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGasMixture), "EnergyWindowMaterialGasMixture")]
    [JsonSubtypes.KnownSubType(typeof(ProgramType), "ProgramType")]
    [JsonSubtypes.KnownSubType(typeof(TemplateSystem), "_TemplateSystem")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGasCustom), "EnergyWindowMaterialGasCustom")]
    [JsonSubtypes.KnownSubType(typeof(EnergyMaterialNoMass), "EnergyMaterialNoMass")]
    [JsonSubtypes.KnownSubType(typeof(LightingAbridged), "LightingAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EvaporativeCooler), "EvaporativeCooler")]
    [JsonSubtypes.KnownSubType(typeof(VRFwithDOAS), "VRFwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionShadeAbridged), "WindowConstructionShadeAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ProgramTypeAbridged), "ProgramTypeAbridged")]
    [JsonSubtypes.KnownSubType(typeof(InfiltrationAbridged), "InfiltrationAbridged")]
    [JsonSubtypes.KnownSubType(typeof(IdealAirSystemAbridged), "IdealAirSystemAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialShade), "EnergyWindowMaterialShade")]
    [JsonSubtypes.KnownSubType(typeof(ConstructionSetAbridged), "ConstructionSetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EquipmentBase), "_EquipmentBase")]
    [JsonSubtypes.KnownSubType(typeof(EnergyMaterial), "EnergyMaterial")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleDay), "ScheduleDay")]
    [JsonSubtypes.KnownSubType(typeof(FCUwithDOAS), "FCUwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(PVAV), "PVAV")]
    [JsonSubtypes.KnownSubType(typeof(VentilationAbridged), "VentilationAbridged")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionAbridged), "WindowConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionShade), "WindowConstructionShade")]
    [JsonSubtypes.KnownSubType(typeof(PSZ), "PSZ")]
    [JsonSubtypes.KnownSubType(typeof(Ventilation), "Ventilation")]
    [JsonSubtypes.KnownSubType(typeof(Infiltration), "Infiltration")]
    [JsonSubtypes.KnownSubType(typeof(WSHP), "WSHP")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialBlind), "EnergyWindowMaterialBlind")]
    [JsonSubtypes.KnownSubType(typeof(ShadeConstruction), "ShadeConstruction")]
    [JsonSubtypes.KnownSubType(typeof(People), "People")]
    [JsonSubtypes.KnownSubType(typeof(AllAirBase), "_AllAirBase")]
    [JsonSubtypes.KnownSubType(typeof(PTAC), "PTAC")]
    [JsonSubtypes.KnownSubType(typeof(VAV), "VAV")]
    [JsonSubtypes.KnownSubType(typeof(VRF), "VRF")]
    [JsonSubtypes.KnownSubType(typeof(ElectricEquipment), "ElectricEquipment")]
    [JsonSubtypes.KnownSubType(typeof(FCU), "FCU")]
    [JsonSubtypes.KnownSubType(typeof(GasEquipment), "GasEquipment")]
    [JsonSubtypes.KnownSubType(typeof(WindowAC), "WindowAC")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleRuleset), "ScheduleRuleset")]
    [JsonSubtypes.KnownSubType(typeof(ForcedAirFurnace), "ForcedAirFurnace")]
    [JsonSubtypes.KnownSubType(typeof(ConstructionSet), "ConstructionSet")]
    [JsonSubtypes.KnownSubType(typeof(PeopleAbridged), "PeopleAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleFixedInterval), "ScheduleFixedInterval")]
    [JsonSubtypes.KnownSubType(typeof(Setpoint), "Setpoint")]
    [JsonSubtypes.KnownSubType(typeof(HeatCoolBase), "_HeatCoolBase")]
    [JsonSubtypes.KnownSubType(typeof(GasUnitHeater), "GasUnitHeater")]
    [JsonSubtypes.KnownSubType(typeof(AirBoundaryConstructionAbridged), "AirBoundaryConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(Baseboard), "Baseboard")]
    [JsonSubtypes.KnownSubType(typeof(OpaqueConstructionAbridged), "OpaqueConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleFixedIntervalAbridged), "ScheduleFixedIntervalAbridged")]
    [JsonSubtypes.KnownSubType(typeof(SetpointAbridged), "SetpointAbridged")]
    [JsonSubtypes.KnownSubType(typeof(WSHPwithDOAS), "WSHPwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(Lighting), "Lighting")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleTypeLimit), "ScheduleTypeLimit")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialSimpleGlazSys), "EnergyWindowMaterialSimpleGlazSys")]
    [JsonSubtypes.KnownSubType(typeof(PeopleAbridged), "PeopleAbridged")]
    [JsonSubtypes.KnownSubType(typeof(LightingAbridged), "LightingAbridged")]
    [JsonSubtypes.KnownSubType(typeof(InfiltrationAbridged), "InfiltrationAbridged")]
    [JsonSubtypes.KnownSubType(typeof(VentilationAbridged), "VentilationAbridged")]
    [JsonSubtypes.KnownSubType(typeof(SetpointAbridged), "SetpointAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleDay), "ScheduleDay")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleTypeLimit), "ScheduleTypeLimit")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleRuleset), "ScheduleRuleset")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleFixedInterval), "ScheduleFixedInterval")]
    [JsonSubtypes.KnownSubType(typeof(GasEquipment), "GasEquipment")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleRulesetAbridged), "ScheduleRulesetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialSimpleGlazSys), "EnergyWindowMaterialSimpleGlazSys")]
    [JsonSubtypes.KnownSubType(typeof(PTAC), "PTAC")]
    [JsonSubtypes.KnownSubType(typeof(FCUwithDOAS), "FCUwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(VRFwithDOAS), "VRFwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(ConstructionSetAbridged), "ConstructionSetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EnergyMaterial), "EnergyMaterial")]
    [JsonSubtypes.KnownSubType(typeof(EnergyMaterialNoMass), "EnergyMaterialNoMass")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGlazing), "EnergyWindowMaterialGlazing")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGas), "EnergyWindowMaterialGas")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGasCustom), "EnergyWindowMaterialGasCustom")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialGasMixture), "EnergyWindowMaterialGasMixture")]
    [JsonSubtypes.KnownSubType(typeof(ShadeConstruction), "ShadeConstruction")]
    [JsonSubtypes.KnownSubType(typeof(AirBoundaryConstruction), "AirBoundaryConstruction")]
    [JsonSubtypes.KnownSubType(typeof(ConstructionSet), "ConstructionSet")]
    [JsonSubtypes.KnownSubType(typeof(OpaqueConstructionAbridged), "OpaqueConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionAbridged), "WindowConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionShadeAbridged), "WindowConstructionShadeAbridged")]
    [JsonSubtypes.KnownSubType(typeof(AirBoundaryConstructionAbridged), "AirBoundaryConstructionAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialShade), "EnergyWindowMaterialShade")]
    [JsonSubtypes.KnownSubType(typeof(EnergyWindowMaterialBlind), "EnergyWindowMaterialBlind")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstructionShade), "WindowConstructionShade")]
    [JsonSubtypes.KnownSubType(typeof(IdealAirSystemAbridged), "IdealAirSystemAbridged")]
    [JsonSubtypes.KnownSubType(typeof(VAV), "VAV")]
    [JsonSubtypes.KnownSubType(typeof(PVAV), "PVAV")]
    [JsonSubtypes.KnownSubType(typeof(PSZ), "PSZ")]
    [JsonSubtypes.KnownSubType(typeof(ForcedAirFurnace), "ForcedAirFurnace")]
    [JsonSubtypes.KnownSubType(typeof(WSHPwithDOAS), "WSHPwithDOAS")]
    [JsonSubtypes.KnownSubType(typeof(FCU), "FCU")]
    [JsonSubtypes.KnownSubType(typeof(WSHP), "WSHP")]
    [JsonSubtypes.KnownSubType(typeof(VRF), "VRF")]
    [JsonSubtypes.KnownSubType(typeof(Baseboard), "Baseboard")]
    [JsonSubtypes.KnownSubType(typeof(EvaporativeCooler), "EvaporativeCooler")]
    [JsonSubtypes.KnownSubType(typeof(Residential), "Residential")]
    [JsonSubtypes.KnownSubType(typeof(WindowAC), "WindowAC")]
    [JsonSubtypes.KnownSubType(typeof(GasUnitHeater), "GasUnitHeater")]
    [JsonSubtypes.KnownSubType(typeof(ProgramTypeAbridged), "ProgramTypeAbridged")]
    [JsonSubtypes.KnownSubType(typeof(People), "People")]
    [JsonSubtypes.KnownSubType(typeof(Lighting), "Lighting")]
    [JsonSubtypes.KnownSubType(typeof(ElectricEquipment), "ElectricEquipment")]
    [JsonSubtypes.KnownSubType(typeof(Infiltration), "Infiltration")]
    [JsonSubtypes.KnownSubType(typeof(Ventilation), "Ventilation")]
    [JsonSubtypes.KnownSubType(typeof(Setpoint), "Setpoint")]
    [JsonSubtypes.KnownSubType(typeof(ProgramType), "ProgramType")]
    [JsonSubtypes.KnownSubType(typeof(ScheduleFixedIntervalAbridged), "ScheduleFixedIntervalAbridged")]
    [JsonSubtypes.KnownSubType(typeof(EquipmentBase), "_EquipmentBase")]
    [JsonSubtypes.KnownSubType(typeof(AllAirBase), "_AllAirBase")]
    [JsonSubtypes.KnownSubType(typeof(TemplateSystem), "_TemplateSystem")]
    [JsonSubtypes.KnownSubType(typeof(DOASBase), "_DOASBase")]
    [JsonSubtypes.KnownSubType(typeof(HeatCoolBase), "_HeatCoolBase")]
    [JsonSubtypes.KnownSubType(typeof(OpaqueConstruction), "OpaqueConstruction")]
    [JsonSubtypes.KnownSubType(typeof(WindowConstruction), "WindowConstruction")]
    [JsonSubtypes.KnownSubType(typeof(ElectricEquipmentAbridged), "ElectricEquipmentAbridged")]
    [JsonSubtypes.KnownSubType(typeof(GasEquipmentAbridged), "GasEquipmentAbridged")]
    public partial class IDdEnergyBaseModel : OpenAPIGenBaseModel, IEquatable<IDdEnergyBaseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IDdEnergyBaseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IDdEnergyBaseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IDdEnergyBaseModel" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public IDdEnergyBaseModel
        (
             string identifier, // Required parameters
            string displayName= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for IDdEnergyBaseModel and cannot be null");
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=true)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "IDdEnergyBaseModel";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"IDdEnergyBaseModel {iDd.Identifier}";
       
            return "IDdEnergyBaseModel";
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
            sb.Append("IDdEnergyBaseModel:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>IDdEnergyBaseModel object</returns>
        public static IDdEnergyBaseModel FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<IDdEnergyBaseModel>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdEnergyBaseModel object</returns>
        public IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return FromJson(this.ToJson()) as IDdEnergyBaseModel;
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
            return this.Equals(input as IDdEnergyBaseModel);
        }

        /// <summary>
        /// Returns true if IDdEnergyBaseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of IDdEnergyBaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IDdEnergyBaseModel input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && base.Equals(input) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }
            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^IDdEnergyBaseModel$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
