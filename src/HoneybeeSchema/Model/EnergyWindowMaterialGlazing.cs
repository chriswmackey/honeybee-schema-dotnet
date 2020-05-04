/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.0
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
    /// Describe a single glass pane corresponding to a layer in a window construction.
    /// </summary>
    [DataContract]
    public partial class EnergyWindowMaterialGlazing : IDdEnergyBaseModel, IEquatable<EnergyWindowMaterialGlazing>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGlazing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialGlazing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGlazing" /> class.
        /// </summary>
        /// <param name="thickness">The surface-to-surface of the glass in meters. Default value is 0.003. (default to 0.003D).</param>
        /// <param name="solarTransmittance">Transmittance of solar radiation through the glass at normal incidence. Default value is 0.85 for clear glass. (default to 0.85D).</param>
        /// <param name="solarReflectance">Reflectance of solar radiation off of the front side of the glass at normal incidence, averaged over the solar spectrum. Default value is 0.075 for clear glass. (default to 0.075D).</param>
        /// <param name="solarReflectanceBack">Reflectance of solar radiation off of the back side of the glass at normal incidence, averaged over the solar spectrum..</param>
        /// <param name="visibleTransmittance">Transmittance of visible light through the glass at normal incidence. Default value is 0.9 for clear glass. (default to 0.9D).</param>
        /// <param name="visibleReflectance">Reflectance of visible light off of the front side of the glass at normal incidence. Default value is 0.075 for clear glass. (default to 0.075D).</param>
        /// <param name="visibleReflectanceBack">Reflectance of visible light off of the back side of the glass at normal incidence averaged over the solar spectrum and weighted by the response of the human eye..</param>
        /// <param name="infraredTransmittance">Long-wave transmittance at normal incidence. (default to 0D).</param>
        /// <param name="emissivity">Infrared hemispherical emissivity of the front (outward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating. (default to 0.84D).</param>
        /// <param name="emissivityBack">Infrared hemispherical emissivity of the back (inward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating. (default to 0.84D).</param>
        /// <param name="conductivity">Thermal conductivity of the glass in W/(m-K). Default value is 0.9, which is  typical for clear glass without a low-e coating. (default to 0.9D).</param>
        /// <param name="dirtCorrection">Factor that corrects for the presence of dirt on the glass. A default value of 1 indicates the glass is clean. (default to 1D).</param>
        /// <param name="solarDiffusing">Takes values True and False. If False (default), the beam solar radiation incident on the glass is transmitted as beam radiation with no diffuse component.If True, the beam  solar radiation incident on the glass is transmitted as hemispherical diffuse radiation with no beam component. (default to false).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyWindowMaterialGlazing
        (
            string identifier, // Required parameters
            double thickness = 0.003D, double solarTransmittance = 0.85D, double solarReflectance = 0.075D, double solarReflectanceBack= default, double visibleTransmittance = 0.9D, double visibleReflectance = 0.075D, double visibleReflectanceBack= default, double infraredTransmittance = 0D, double emissivity = 0.84D, double emissivityBack = 0.84D, double conductivity = 0.9D, double dirtCorrection = 1D, bool solarDiffusing = false, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // use default value if no "thickness" provided
            if (thickness == null)
            {
                this.Thickness = 0.003D;
            }
            else
            {
                this.Thickness = thickness;
            }
            // use default value if no "solarTransmittance" provided
            if (solarTransmittance == null)
            {
                this.SolarTransmittance = 0.85D;
            }
            else
            {
                this.SolarTransmittance = solarTransmittance;
            }
            // use default value if no "solarReflectance" provided
            if (solarReflectance == null)
            {
                this.SolarReflectance = 0.075D;
            }
            else
            {
                this.SolarReflectance = solarReflectance;
            }
            this.SolarReflectanceBack = solarReflectanceBack;
            // use default value if no "visibleTransmittance" provided
            if (visibleTransmittance == null)
            {
                this.VisibleTransmittance = 0.9D;
            }
            else
            {
                this.VisibleTransmittance = visibleTransmittance;
            }
            // use default value if no "visibleReflectance" provided
            if (visibleReflectance == null)
            {
                this.VisibleReflectance = 0.075D;
            }
            else
            {
                this.VisibleReflectance = visibleReflectance;
            }
            this.VisibleReflectanceBack = visibleReflectanceBack;
            // use default value if no "infraredTransmittance" provided
            if (infraredTransmittance == null)
            {
                this.InfraredTransmittance = 0D;
            }
            else
            {
                this.InfraredTransmittance = infraredTransmittance;
            }
            // use default value if no "emissivity" provided
            if (emissivity == null)
            {
                this.Emissivity = 0.84D;
            }
            else
            {
                this.Emissivity = emissivity;
            }
            // use default value if no "emissivityBack" provided
            if (emissivityBack == null)
            {
                this.EmissivityBack = 0.84D;
            }
            else
            {
                this.EmissivityBack = emissivityBack;
            }
            // use default value if no "conductivity" provided
            if (conductivity == null)
            {
                this.Conductivity = 0.9D;
            }
            else
            {
                this.Conductivity = conductivity;
            }
            // use default value if no "dirtCorrection" provided
            if (dirtCorrection == null)
            {
                this.DirtCorrection = 1D;
            }
            else
            {
                this.DirtCorrection = dirtCorrection;
            }
            // use default value if no "solarDiffusing" provided
            if (solarDiffusing == null)
            {
                this.SolarDiffusing = false;
            }
            else
            {
                this.SolarDiffusing = solarDiffusing;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyWindowMaterialGlazing";
        }
        
        /// <summary>
        /// The surface-to-surface of the glass in meters. Default value is 0.003.
        /// </summary>
        /// <value>The surface-to-surface of the glass in meters. Default value is 0.003.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        [JsonProperty("thickness")]
        public double Thickness { get; set; }
        /// <summary>
        /// Transmittance of solar radiation through the glass at normal incidence. Default value is 0.85 for clear glass.
        /// </summary>
        /// <value>Transmittance of solar radiation through the glass at normal incidence. Default value is 0.85 for clear glass.</value>
        [DataMember(Name="solar_transmittance", EmitDefaultValue=false)]
        [JsonProperty("solar_transmittance")]
        public double SolarTransmittance { get; set; }
        /// <summary>
        /// Reflectance of solar radiation off of the front side of the glass at normal incidence, averaged over the solar spectrum. Default value is 0.075 for clear glass.
        /// </summary>
        /// <value>Reflectance of solar radiation off of the front side of the glass at normal incidence, averaged over the solar spectrum. Default value is 0.075 for clear glass.</value>
        [DataMember(Name="solar_reflectance", EmitDefaultValue=false)]
        [JsonProperty("solar_reflectance")]
        public double SolarReflectance { get; set; }
        /// <summary>
        /// Reflectance of solar radiation off of the back side of the glass at normal incidence, averaged over the solar spectrum.
        /// </summary>
        /// <value>Reflectance of solar radiation off of the back side of the glass at normal incidence, averaged over the solar spectrum.</value>
        [DataMember(Name="solar_reflectance_back", EmitDefaultValue=false)]
        [JsonProperty("solar_reflectance_back")]
        public double SolarReflectanceBack { get; set; }
        /// <summary>
        /// Transmittance of visible light through the glass at normal incidence. Default value is 0.9 for clear glass.
        /// </summary>
        /// <value>Transmittance of visible light through the glass at normal incidence. Default value is 0.9 for clear glass.</value>
        [DataMember(Name="visible_transmittance", EmitDefaultValue=false)]
        [JsonProperty("visible_transmittance")]
        public double VisibleTransmittance { get; set; }
        /// <summary>
        /// Reflectance of visible light off of the front side of the glass at normal incidence. Default value is 0.075 for clear glass.
        /// </summary>
        /// <value>Reflectance of visible light off of the front side of the glass at normal incidence. Default value is 0.075 for clear glass.</value>
        [DataMember(Name="visible_reflectance", EmitDefaultValue=false)]
        [JsonProperty("visible_reflectance")]
        public double VisibleReflectance { get; set; }
        /// <summary>
        /// Reflectance of visible light off of the back side of the glass at normal incidence averaged over the solar spectrum and weighted by the response of the human eye.
        /// </summary>
        /// <value>Reflectance of visible light off of the back side of the glass at normal incidence averaged over the solar spectrum and weighted by the response of the human eye.</value>
        [DataMember(Name="visible_reflectance_back", EmitDefaultValue=false)]
        [JsonProperty("visible_reflectance_back")]
        public double VisibleReflectanceBack { get; set; }
        /// <summary>
        /// Long-wave transmittance at normal incidence.
        /// </summary>
        /// <value>Long-wave transmittance at normal incidence.</value>
        [DataMember(Name="infrared_transmittance", EmitDefaultValue=false)]
        [JsonProperty("infrared_transmittance")]
        public double InfraredTransmittance { get; set; }
        /// <summary>
        /// Infrared hemispherical emissivity of the front (outward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating.
        /// </summary>
        /// <value>Infrared hemispherical emissivity of the front (outward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating.</value>
        [DataMember(Name="emissivity", EmitDefaultValue=false)]
        [JsonProperty("emissivity")]
        public double Emissivity { get; set; }
        /// <summary>
        /// Infrared hemispherical emissivity of the back (inward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating.
        /// </summary>
        /// <value>Infrared hemispherical emissivity of the back (inward facing) side of the glass.  Default value is 0.84, which is typical for clear glass without a low-e coating.</value>
        [DataMember(Name="emissivity_back", EmitDefaultValue=false)]
        [JsonProperty("emissivity_back")]
        public double EmissivityBack { get; set; }
        /// <summary>
        /// Thermal conductivity of the glass in W/(m-K). Default value is 0.9, which is  typical for clear glass without a low-e coating.
        /// </summary>
        /// <value>Thermal conductivity of the glass in W/(m-K). Default value is 0.9, which is  typical for clear glass without a low-e coating.</value>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        [JsonProperty("conductivity")]
        public double Conductivity { get; set; }
        /// <summary>
        /// Factor that corrects for the presence of dirt on the glass. A default value of 1 indicates the glass is clean.
        /// </summary>
        /// <value>Factor that corrects for the presence of dirt on the glass. A default value of 1 indicates the glass is clean.</value>
        [DataMember(Name="dirt_correction", EmitDefaultValue=false)]
        [JsonProperty("dirt_correction")]
        public double DirtCorrection { get; set; }
        /// <summary>
        /// Takes values True and False. If False (default), the beam solar radiation incident on the glass is transmitted as beam radiation with no diffuse component.If True, the beam  solar radiation incident on the glass is transmitted as hemispherical diffuse radiation with no beam component.
        /// </summary>
        /// <value>Takes values True and False. If False (default), the beam solar radiation incident on the glass is transmitted as beam radiation with no diffuse component.If True, the beam  solar radiation incident on the glass is transmitted as hemispherical diffuse radiation with no beam component.</value>
        [DataMember(Name="solar_diffusing", EmitDefaultValue=false)]
        [JsonProperty("solar_diffusing")]
        public bool SolarDiffusing { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyWindowMaterialGlazing {iDd.Identifier}";
       
            return "EnergyWindowMaterialGlazing";
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
            sb.Append("EnergyWindowMaterialGlazing:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  SolarTransmittance: ").Append(SolarTransmittance).Append("\n");
            sb.Append("  SolarReflectance: ").Append(SolarReflectance).Append("\n");
            sb.Append("  SolarReflectanceBack: ").Append(SolarReflectanceBack).Append("\n");
            sb.Append("  VisibleTransmittance: ").Append(VisibleTransmittance).Append("\n");
            sb.Append("  VisibleReflectance: ").Append(VisibleReflectance).Append("\n");
            sb.Append("  VisibleReflectanceBack: ").Append(VisibleReflectanceBack).Append("\n");
            sb.Append("  InfraredTransmittance: ").Append(InfraredTransmittance).Append("\n");
            sb.Append("  Emissivity: ").Append(Emissivity).Append("\n");
            sb.Append("  EmissivityBack: ").Append(EmissivityBack).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  DirtCorrection: ").Append(DirtCorrection).Append("\n");
            sb.Append("  SolarDiffusing: ").Append(SolarDiffusing).Append("\n");
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
        /// <returns>EnergyWindowMaterialGlazing object</returns>
        public static EnergyWindowMaterialGlazing FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyWindowMaterialGlazing>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyWindowMaterialGlazing);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialGlazing instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialGlazing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialGlazing input)
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
                    this.SolarTransmittance == input.SolarTransmittance ||
                    (this.SolarTransmittance != null &&
                    this.SolarTransmittance.Equals(input.SolarTransmittance))
                ) && base.Equals(input) && 
                (
                    this.SolarReflectance == input.SolarReflectance ||
                    (this.SolarReflectance != null &&
                    this.SolarReflectance.Equals(input.SolarReflectance))
                ) && base.Equals(input) && 
                (
                    this.SolarReflectanceBack == input.SolarReflectanceBack ||
                    (this.SolarReflectanceBack != null &&
                    this.SolarReflectanceBack.Equals(input.SolarReflectanceBack))
                ) && base.Equals(input) && 
                (
                    this.VisibleTransmittance == input.VisibleTransmittance ||
                    (this.VisibleTransmittance != null &&
                    this.VisibleTransmittance.Equals(input.VisibleTransmittance))
                ) && base.Equals(input) && 
                (
                    this.VisibleReflectance == input.VisibleReflectance ||
                    (this.VisibleReflectance != null &&
                    this.VisibleReflectance.Equals(input.VisibleReflectance))
                ) && base.Equals(input) && 
                (
                    this.VisibleReflectanceBack == input.VisibleReflectanceBack ||
                    (this.VisibleReflectanceBack != null &&
                    this.VisibleReflectanceBack.Equals(input.VisibleReflectanceBack))
                ) && base.Equals(input) && 
                (
                    this.InfraredTransmittance == input.InfraredTransmittance ||
                    (this.InfraredTransmittance != null &&
                    this.InfraredTransmittance.Equals(input.InfraredTransmittance))
                ) && base.Equals(input) && 
                (
                    this.Emissivity == input.Emissivity ||
                    (this.Emissivity != null &&
                    this.Emissivity.Equals(input.Emissivity))
                ) && base.Equals(input) && 
                (
                    this.EmissivityBack == input.EmissivityBack ||
                    (this.EmissivityBack != null &&
                    this.EmissivityBack.Equals(input.EmissivityBack))
                ) && base.Equals(input) && 
                (
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && base.Equals(input) && 
                (
                    this.DirtCorrection == input.DirtCorrection ||
                    (this.DirtCorrection != null &&
                    this.DirtCorrection.Equals(input.DirtCorrection))
                ) && base.Equals(input) && 
                (
                    this.SolarDiffusing == input.SolarDiffusing ||
                    (this.SolarDiffusing != null &&
                    this.SolarDiffusing.Equals(input.SolarDiffusing))
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
                if (this.SolarTransmittance != null)
                    hashCode = hashCode * 59 + this.SolarTransmittance.GetHashCode();
                if (this.SolarReflectance != null)
                    hashCode = hashCode * 59 + this.SolarReflectance.GetHashCode();
                if (this.SolarReflectanceBack != null)
                    hashCode = hashCode * 59 + this.SolarReflectanceBack.GetHashCode();
                if (this.VisibleTransmittance != null)
                    hashCode = hashCode * 59 + this.VisibleTransmittance.GetHashCode();
                if (this.VisibleReflectance != null)
                    hashCode = hashCode * 59 + this.VisibleReflectance.GetHashCode();
                if (this.VisibleReflectanceBack != null)
                    hashCode = hashCode * 59 + this.VisibleReflectanceBack.GetHashCode();
                if (this.InfraredTransmittance != null)
                    hashCode = hashCode * 59 + this.InfraredTransmittance.GetHashCode();
                if (this.Emissivity != null)
                    hashCode = hashCode * 59 + this.Emissivity.GetHashCode();
                if (this.EmissivityBack != null)
                    hashCode = hashCode * 59 + this.EmissivityBack.GetHashCode();
                if (this.Conductivity != null)
                    hashCode = hashCode * 59 + this.Conductivity.GetHashCode();
                if (this.DirtCorrection != null)
                    hashCode = hashCode * 59 + this.DirtCorrection.GetHashCode();
                if (this.SolarDiffusing != null)
                    hashCode = hashCode * 59 + this.SolarDiffusing.GetHashCode();
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
            Regex regexType = new Regex(@"^EnergyWindowMaterialGlazing$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // SolarTransmittance (double) maximum
            if(this.SolarTransmittance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarTransmittance, must be a value less than or equal to 1.", new [] { "SolarTransmittance" });
            }

            // SolarTransmittance (double) minimum
            if(this.SolarTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarTransmittance, must be a value greater than or equal to 0.", new [] { "SolarTransmittance" });
            }

            // SolarReflectance (double) maximum
            if(this.SolarReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarReflectance, must be a value less than or equal to 1.", new [] { "SolarReflectance" });
            }

            // SolarReflectance (double) minimum
            if(this.SolarReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarReflectance, must be a value greater than or equal to 0.", new [] { "SolarReflectance" });
            }

            // VisibleTransmittance (double) maximum
            if(this.VisibleTransmittance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleTransmittance, must be a value less than or equal to 1.", new [] { "VisibleTransmittance" });
            }

            // VisibleTransmittance (double) minimum
            if(this.VisibleTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleTransmittance, must be a value greater than or equal to 0.", new [] { "VisibleTransmittance" });
            }

            // VisibleReflectance (double) maximum
            if(this.VisibleReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectance, must be a value less than or equal to 1.", new [] { "VisibleReflectance" });
            }

            // VisibleReflectance (double) minimum
            if(this.VisibleReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectance, must be a value greater than or equal to 0.", new [] { "VisibleReflectance" });
            }

            // VisibleReflectanceBack (double) maximum
            if(this.VisibleReflectanceBack > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectanceBack, must be a value less than or equal to 1.", new [] { "VisibleReflectanceBack" });
            }

            // VisibleReflectanceBack (double) minimum
            if(this.VisibleReflectanceBack < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectanceBack, must be a value greater than or equal to 0.", new [] { "VisibleReflectanceBack" });
            }

            // InfraredTransmittance (double) maximum
            if(this.InfraredTransmittance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InfraredTransmittance, must be a value less than or equal to 1.", new [] { "InfraredTransmittance" });
            }

            // InfraredTransmittance (double) minimum
            if(this.InfraredTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InfraredTransmittance, must be a value greater than or equal to 0.", new [] { "InfraredTransmittance" });
            }

            // Emissivity (double) maximum
            if(this.Emissivity > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Emissivity, must be a value less than or equal to 1.", new [] { "Emissivity" });
            }

            // Emissivity (double) minimum
            if(this.Emissivity < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Emissivity, must be a value greater than or equal to 0.", new [] { "Emissivity" });
            }

            // EmissivityBack (double) maximum
            if(this.EmissivityBack > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmissivityBack, must be a value less than or equal to 1.", new [] { "EmissivityBack" });
            }

            // EmissivityBack (double) minimum
            if(this.EmissivityBack < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmissivityBack, must be a value greater than or equal to 0.", new [] { "EmissivityBack" });
            }

            yield break;
        }
    }

}
