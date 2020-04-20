/* 
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.25.3
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
    /// The complete set of EnergyPlus Simulation Settings.
    /// </summary>
    [DataContract]
    public partial class SimulationParameter : HoneybeeObject, IEquatable<SimulationParameter>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationParameter" /> class.
        /// </summary>
        /// <param name="output">A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them..</param>
        /// <param name="runPeriod">A RunPeriod to describe the time period over which to run the simulation..</param>
        /// <param name="timestep">An integer for the number of timesteps per hour at which the energy calculation will be run. (default to 6).</param>
        /// <param name="simulationControl">A SimulationControl object that describes which types of calculations to run..</param>
        /// <param name="shadowCalculation">A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation..</param>
        /// <param name="sizingParameter">A SizingParameter object with criteria for sizing the heating and cooling system..</param>
        public SimulationParameter
        (
            // Required parameters
            SimulationOutput output= default, RunPeriod runPeriod= default, int timestep = 6, SimulationControl simulationControl= default, ShadowCalculation shadowCalculation= default, SizingParameter sizingParameter= default// Optional parameters
        )// BaseClass
        {
            this.Output = output;
            this.RunPeriod = runPeriod;
            // use default value if no "timestep" provided
            if (timestep == null)
            {
                this.Timestep = 6;
            }
            else
            {
                this.Timestep = timestep;
            }
            this.SimulationControl = simulationControl;
            this.ShadowCalculation = shadowCalculation;
            this.SizingParameter = sizingParameter;

            // Set non-required readonly properties with defaultValue
            this.Type = "SimulationParameter";
        }
        
        /// <summary>
        /// A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them.
        /// </summary>
        /// <value>A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them.</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        [JsonProperty("output")]
        public SimulationOutput Output { get; set; }
        /// <summary>
        /// A RunPeriod to describe the time period over which to run the simulation.
        /// </summary>
        /// <value>A RunPeriod to describe the time period over which to run the simulation.</value>
        [DataMember(Name="run_period", EmitDefaultValue=false)]
        [JsonProperty("run_period")]
        public RunPeriod RunPeriod { get; set; }
        /// <summary>
        /// An integer for the number of timesteps per hour at which the energy calculation will be run.
        /// </summary>
        /// <value>An integer for the number of timesteps per hour at which the energy calculation will be run.</value>
        [DataMember(Name="timestep", EmitDefaultValue=false)]
        [JsonProperty("timestep")]
        public int Timestep { get; set; }
        /// <summary>
        /// A SimulationControl object that describes which types of calculations to run.
        /// </summary>
        /// <value>A SimulationControl object that describes which types of calculations to run.</value>
        [DataMember(Name="simulation_control", EmitDefaultValue=false)]
        [JsonProperty("simulation_control")]
        public SimulationControl SimulationControl { get; set; }
        /// <summary>
        /// A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation.
        /// </summary>
        /// <value>A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation.</value>
        [DataMember(Name="shadow_calculation", EmitDefaultValue=false)]
        [JsonProperty("shadow_calculation")]
        public ShadowCalculation ShadowCalculation { get; set; }
        /// <summary>
        /// A SizingParameter object with criteria for sizing the heating and cooling system.
        /// </summary>
        /// <value>A SizingParameter object with criteria for sizing the heating and cooling system.</value>
        [DataMember(Name="sizing_parameter", EmitDefaultValue=false)]
        [JsonProperty("sizing_parameter")]
        public SizingParameter SizingParameter { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SimulationParameter {iDd.Identifier}";
       
            return "SimulationParameter";
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
            sb.Append("SimulationParameter:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  RunPeriod: ").Append(RunPeriod).Append("\n");
            sb.Append("  Timestep: ").Append(Timestep).Append("\n");
            sb.Append("  SimulationControl: ").Append(SimulationControl).Append("\n");
            sb.Append("  ShadowCalculation: ").Append(ShadowCalculation).Append("\n");
            sb.Append("  SizingParameter: ").Append(SizingParameter).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimulationParameter object</returns>
        public static SimulationParameter FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SimulationParameter>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimulationParameter);
        }

        /// <summary>
        /// Returns true if SimulationParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.RunPeriod == input.RunPeriod ||
                    (this.RunPeriod != null &&
                    this.RunPeriod.Equals(input.RunPeriod))
                ) && 
                (
                    this.Timestep == input.Timestep ||
                    (this.Timestep != null &&
                    this.Timestep.Equals(input.Timestep))
                ) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && 
                (
                    this.ShadowCalculation == input.ShadowCalculation ||
                    (this.ShadowCalculation != null &&
                    this.ShadowCalculation.Equals(input.ShadowCalculation))
                ) && 
                (
                    this.SizingParameter == input.SizingParameter ||
                    (this.SizingParameter != null &&
                    this.SizingParameter.Equals(input.SizingParameter))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.RunPeriod != null)
                    hashCode = hashCode * 59 + this.RunPeriod.GetHashCode();
                if (this.Timestep != null)
                    hashCode = hashCode * 59 + this.Timestep.GetHashCode();
                if (this.SimulationControl != null)
                    hashCode = hashCode * 59 + this.SimulationControl.GetHashCode();
                if (this.ShadowCalculation != null)
                    hashCode = hashCode * 59 + this.ShadowCalculation.GetHashCode();
                if (this.SizingParameter != null)
                    hashCode = hashCode * 59 + this.SizingParameter.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^SimulationParameter$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Timestep (int) maximum
            if(this.Timestep > (int)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestep, must be a value less than or equal to 60.", new [] { "Timestep" });
            }

            // Timestep (int) minimum
            if(this.Timestep < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestep, must be a value greater than or equal to 1.", new [] { "Timestep" });
            }

            yield break;
        }
    }

}
