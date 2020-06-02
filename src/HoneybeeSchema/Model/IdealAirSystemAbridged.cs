/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.34.0
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
    /// Provides a model for an ideal HVAC system.
    /// </summary>
    [DataContract]
    public partial class IdealAirSystemAbridged : IDdEnergyBaseModel, IEquatable<IdealAirSystemAbridged>, IValidatableObject
    {

        /// <summary>
        /// Text to indicate the type of air-side economizer used on the ideal air system. Economizers will mix in a greater amount of outdoor air to cool the zone (rather than running the cooling system) when the zone needs cooling and the outdoor air is cooler than the zone.
        /// </summary>
        /// <value>Text to indicate the type of air-side economizer used on the ideal air system. Economizers will mix in a greater amount of outdoor air to cool the zone (rather than running the cooling system) when the zone needs cooling and the outdoor air is cooler than the zone.</value>
        [DataMember(Name="economizer_type", EmitDefaultValue=false)]
        public EconomizerType? EconomizerType { get; set; }   = HoneybeeSchema.EconomizerType.DifferentialDryBulb; 
        /// <summary>
        /// Initializes a new instance of the <see cref="IdealAirSystemAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdealAirSystemAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdealAirSystemAbridged" /> class.
        /// </summary>
        /// <param name="economizerType">Text to indicate the type of air-side economizer used on the ideal air system. Economizers will mix in a greater amount of outdoor air to cool the zone (rather than running the cooling system) when the zone needs cooling and the outdoor air is cooler than the zone. (default to &quot;DifferentialDryBulb&quot;).</param>
        /// <param name="demandControlledVentilation">Boolean to note whether demand controlled ventilation should be used on the system, which will vary the amount of ventilation air according to the occupancy schedule of the zone. (default to false).</param>
        /// <param name="sensibleHeatRecovery">A number between 0 and 1 for the effectiveness of sensible heat recovery within the system. (default to 0D).</param>
        /// <param name="latentHeatRecovery">A number between 0 and 1 for the effectiveness of latent heat recovery within the system. (default to 0D).</param>
        /// <param name="heatingAirTemperature">A number for the maximum heating supply air temperature [C]. (default to 50D).</param>
        /// <param name="coolingAirTemperature">A number for the minimum cooling supply air temperature [C]. (default to 13D).</param>
        /// <param name="heatingLimit">A number for the maximum heating capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the heating capacity..</param>
        /// <param name="coolingLimit">A number for the maximum cooling capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the cooling capacity..</param>
        /// <param name="heatingAvailability">An optional identifier of a schedule to set the availability of heating over the course of the simulation..</param>
        /// <param name="coolingAvailability">An optional identifier of a schedule to set the availability of cooling over the course of the simulation..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public IdealAirSystemAbridged
        (
            string identifier, // Required parameters
            string displayName= default, EconomizerType? economizerType = HoneybeeSchema.EconomizerType.DifferentialDryBulb, bool demandControlledVentilation = false, double sensibleHeatRecovery = 0D, double latentHeatRecovery = 0D, double heatingAirTemperature = 50D, double coolingAirTemperature = 13D, AnyOf<NoLimit,Autosize,double> heatingLimit= default, AnyOf<NoLimit,Autosize,double> coolingLimit= default, string heatingAvailability= default, string coolingAvailability= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // use default value if no "economizerType" provided
            if (economizerType == null)
            {
                this.EconomizerType = HoneybeeSchema.EconomizerType.DifferentialDryBulb;
            }
            else
            {
                this.EconomizerType = economizerType;
            }
            // use default value if no "demandControlledVentilation" provided
            if (demandControlledVentilation == null)
            {
                this.DemandControlledVentilation = false;
            }
            else
            {
                this.DemandControlledVentilation = demandControlledVentilation;
            }
            // use default value if no "sensibleHeatRecovery" provided
            if (sensibleHeatRecovery == null)
            {
                this.SensibleHeatRecovery = 0D;
            }
            else
            {
                this.SensibleHeatRecovery = sensibleHeatRecovery;
            }
            // use default value if no "latentHeatRecovery" provided
            if (latentHeatRecovery == null)
            {
                this.LatentHeatRecovery = 0D;
            }
            else
            {
                this.LatentHeatRecovery = latentHeatRecovery;
            }
            // use default value if no "heatingAirTemperature" provided
            if (heatingAirTemperature == null)
            {
                this.HeatingAirTemperature = 50D;
            }
            else
            {
                this.HeatingAirTemperature = heatingAirTemperature;
            }
            // use default value if no "coolingAirTemperature" provided
            if (coolingAirTemperature == null)
            {
                this.CoolingAirTemperature = 13D;
            }
            else
            {
                this.CoolingAirTemperature = coolingAirTemperature;
            }
            this.HeatingLimit = heatingLimit;
            this.CoolingLimit = coolingLimit;
            this.HeatingAvailability = heatingAvailability;
            this.CoolingAvailability = coolingAvailability;

            // Set non-required readonly properties with defaultValue
            this.Type = "IdealAirSystemAbridged";
        }
        
        /// <summary>
        /// Boolean to note whether demand controlled ventilation should be used on the system, which will vary the amount of ventilation air according to the occupancy schedule of the zone.
        /// </summary>
        /// <value>Boolean to note whether demand controlled ventilation should be used on the system, which will vary the amount of ventilation air according to the occupancy schedule of the zone.</value>
        [DataMember(Name="demand_controlled_ventilation", EmitDefaultValue=false)]
        [JsonProperty("demand_controlled_ventilation")]
        public bool DemandControlledVentilation { get; set; }  = false;
        /// <summary>
        /// A number between 0 and 1 for the effectiveness of sensible heat recovery within the system.
        /// </summary>
        /// <value>A number between 0 and 1 for the effectiveness of sensible heat recovery within the system.</value>
        [DataMember(Name="sensible_heat_recovery", EmitDefaultValue=false)]
        [JsonProperty("sensible_heat_recovery")]
        public double SensibleHeatRecovery { get; set; }  = 0D;
        /// <summary>
        /// A number between 0 and 1 for the effectiveness of latent heat recovery within the system.
        /// </summary>
        /// <value>A number between 0 and 1 for the effectiveness of latent heat recovery within the system.</value>
        [DataMember(Name="latent_heat_recovery", EmitDefaultValue=false)]
        [JsonProperty("latent_heat_recovery")]
        public double LatentHeatRecovery { get; set; }  = 0D;
        /// <summary>
        /// A number for the maximum heating supply air temperature [C].
        /// </summary>
        /// <value>A number for the maximum heating supply air temperature [C].</value>
        [DataMember(Name="heating_air_temperature", EmitDefaultValue=false)]
        [JsonProperty("heating_air_temperature")]
        public double HeatingAirTemperature { get; set; }  = 50D;
        /// <summary>
        /// A number for the minimum cooling supply air temperature [C].
        /// </summary>
        /// <value>A number for the minimum cooling supply air temperature [C].</value>
        [DataMember(Name="cooling_air_temperature", EmitDefaultValue=false)]
        [JsonProperty("cooling_air_temperature")]
        public double CoolingAirTemperature { get; set; }  = 13D;
        /// <summary>
        /// A number for the maximum heating capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the heating capacity.
        /// </summary>
        /// <value>A number for the maximum heating capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the heating capacity.</value>
        [DataMember(Name="heating_limit", EmitDefaultValue=false)]
        [JsonProperty("heating_limit")]
        public AnyOf<NoLimit,Autosize,double> HeatingLimit { get; set; } 
        /// <summary>
        /// A number for the maximum cooling capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the cooling capacity.
        /// </summary>
        /// <value>A number for the maximum cooling capacity in Watts. This can also be an Autosize object to indicate that the capacity should be determined during the EnergyPlus sizing calculation. This can also be a NoLimit object to indicate no upper limit to the cooling capacity.</value>
        [DataMember(Name="cooling_limit", EmitDefaultValue=false)]
        [JsonProperty("cooling_limit")]
        public AnyOf<NoLimit,Autosize,double> CoolingLimit { get; set; } 
        /// <summary>
        /// An optional identifier of a schedule to set the availability of heating over the course of the simulation.
        /// </summary>
        /// <value>An optional identifier of a schedule to set the availability of heating over the course of the simulation.</value>
        [DataMember(Name="heating_availability", EmitDefaultValue=false)]
        [JsonProperty("heating_availability")]
        public string HeatingAvailability { get; set; } 
        /// <summary>
        /// An optional identifier of a schedule to set the availability of cooling over the course of the simulation.
        /// </summary>
        /// <value>An optional identifier of a schedule to set the availability of cooling over the course of the simulation.</value>
        [DataMember(Name="cooling_availability", EmitDefaultValue=false)]
        [JsonProperty("cooling_availability")]
        public string CoolingAvailability { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"IdealAirSystemAbridged {iDd.Identifier}";
       
            return "IdealAirSystemAbridged";
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
            sb.Append("IdealAirSystemAbridged:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EconomizerType: ").Append(EconomizerType).Append("\n");
            sb.Append("  DemandControlledVentilation: ").Append(DemandControlledVentilation).Append("\n");
            sb.Append("  SensibleHeatRecovery: ").Append(SensibleHeatRecovery).Append("\n");
            sb.Append("  LatentHeatRecovery: ").Append(LatentHeatRecovery).Append("\n");
            sb.Append("  HeatingAirTemperature: ").Append(HeatingAirTemperature).Append("\n");
            sb.Append("  CoolingAirTemperature: ").Append(CoolingAirTemperature).Append("\n");
            sb.Append("  HeatingLimit: ").Append(HeatingLimit).Append("\n");
            sb.Append("  CoolingLimit: ").Append(CoolingLimit).Append("\n");
            sb.Append("  HeatingAvailability: ").Append(HeatingAvailability).Append("\n");
            sb.Append("  CoolingAvailability: ").Append(CoolingAvailability).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>IdealAirSystemAbridged object</returns>
        public static IdealAirSystemAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<IdealAirSystemAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IdealAirSystemAbridged object</returns>
        public IdealAirSystemAbridged DuplicateIdealAirSystemAbridged()
        {
            return Duplicate() as IdealAirSystemAbridged;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
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
            return this.Equals(input as IdealAirSystemAbridged);
        }

        /// <summary>
        /// Returns true if IdealAirSystemAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of IdealAirSystemAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdealAirSystemAbridged input)
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
                    this.EconomizerType == input.EconomizerType ||
                    (this.EconomizerType != null &&
                    this.EconomizerType.Equals(input.EconomizerType))
                ) && base.Equals(input) && 
                (
                    this.DemandControlledVentilation == input.DemandControlledVentilation ||
                    (this.DemandControlledVentilation != null &&
                    this.DemandControlledVentilation.Equals(input.DemandControlledVentilation))
                ) && base.Equals(input) && 
                (
                    this.SensibleHeatRecovery == input.SensibleHeatRecovery ||
                    (this.SensibleHeatRecovery != null &&
                    this.SensibleHeatRecovery.Equals(input.SensibleHeatRecovery))
                ) && base.Equals(input) && 
                (
                    this.LatentHeatRecovery == input.LatentHeatRecovery ||
                    (this.LatentHeatRecovery != null &&
                    this.LatentHeatRecovery.Equals(input.LatentHeatRecovery))
                ) && base.Equals(input) && 
                (
                    this.HeatingAirTemperature == input.HeatingAirTemperature ||
                    (this.HeatingAirTemperature != null &&
                    this.HeatingAirTemperature.Equals(input.HeatingAirTemperature))
                ) && base.Equals(input) && 
                (
                    this.CoolingAirTemperature == input.CoolingAirTemperature ||
                    (this.CoolingAirTemperature != null &&
                    this.CoolingAirTemperature.Equals(input.CoolingAirTemperature))
                ) && base.Equals(input) && 
                (
                    this.HeatingLimit == input.HeatingLimit ||
                    (this.HeatingLimit != null &&
                    this.HeatingLimit.Equals(input.HeatingLimit))
                ) && base.Equals(input) && 
                (
                    this.CoolingLimit == input.CoolingLimit ||
                    (this.CoolingLimit != null &&
                    this.CoolingLimit.Equals(input.CoolingLimit))
                ) && base.Equals(input) && 
                (
                    this.HeatingAvailability == input.HeatingAvailability ||
                    (this.HeatingAvailability != null &&
                    this.HeatingAvailability.Equals(input.HeatingAvailability))
                ) && base.Equals(input) && 
                (
                    this.CoolingAvailability == input.CoolingAvailability ||
                    (this.CoolingAvailability != null &&
                    this.CoolingAvailability.Equals(input.CoolingAvailability))
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
                if (this.EconomizerType != null)
                    hashCode = hashCode * 59 + this.EconomizerType.GetHashCode();
                if (this.DemandControlledVentilation != null)
                    hashCode = hashCode * 59 + this.DemandControlledVentilation.GetHashCode();
                if (this.SensibleHeatRecovery != null)
                    hashCode = hashCode * 59 + this.SensibleHeatRecovery.GetHashCode();
                if (this.LatentHeatRecovery != null)
                    hashCode = hashCode * 59 + this.LatentHeatRecovery.GetHashCode();
                if (this.HeatingAirTemperature != null)
                    hashCode = hashCode * 59 + this.HeatingAirTemperature.GetHashCode();
                if (this.CoolingAirTemperature != null)
                    hashCode = hashCode * 59 + this.CoolingAirTemperature.GetHashCode();
                if (this.HeatingLimit != null)
                    hashCode = hashCode * 59 + this.HeatingLimit.GetHashCode();
                if (this.CoolingLimit != null)
                    hashCode = hashCode * 59 + this.CoolingLimit.GetHashCode();
                if (this.HeatingAvailability != null)
                    hashCode = hashCode * 59 + this.HeatingAvailability.GetHashCode();
                if (this.CoolingAvailability != null)
                    hashCode = hashCode * 59 + this.CoolingAvailability.GetHashCode();
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
            Regex regexType = new Regex(@"^IdealAirSystemAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // SensibleHeatRecovery (double) maximum
            if(this.SensibleHeatRecovery > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SensibleHeatRecovery, must be a value less than or equal to 1.", new [] { "SensibleHeatRecovery" });
            }

            // SensibleHeatRecovery (double) minimum
            if(this.SensibleHeatRecovery < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SensibleHeatRecovery, must be a value greater than or equal to 0.", new [] { "SensibleHeatRecovery" });
            }

            // LatentHeatRecovery (double) maximum
            if(this.LatentHeatRecovery > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentHeatRecovery, must be a value less than or equal to 1.", new [] { "LatentHeatRecovery" });
            }

            // LatentHeatRecovery (double) minimum
            if(this.LatentHeatRecovery < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentHeatRecovery, must be a value greater than or equal to 0.", new [] { "LatentHeatRecovery" });
            }

            // HeatingAvailability (string) maxLength
            if(this.HeatingAvailability != null && this.HeatingAvailability.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingAvailability, length must be less than 100.", new [] { "HeatingAvailability" });
            }

            // HeatingAvailability (string) minLength
            if(this.HeatingAvailability != null && this.HeatingAvailability.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingAvailability, length must be greater than 1.", new [] { "HeatingAvailability" });
            }

            // CoolingAvailability (string) maxLength
            if(this.CoolingAvailability != null && this.CoolingAvailability.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingAvailability, length must be less than 100.", new [] { "CoolingAvailability" });
            }

            // CoolingAvailability (string) minLength
            if(this.CoolingAvailability != null && this.CoolingAvailability.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingAvailability, length must be greater than 1.", new [] { "CoolingAvailability" });
            }

            yield break;
        }
    }

}
