/* 
 * Honeybee Simulation Parameter Schema
 *
 * Documentation for Honeybee simulation-parameter schema
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
    /// The complete set of EnergyPlus Simulation Settings.
    /// </summary>
    [DataContract(Name = "SimulationParameter")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class SimulationParameter : OpenAPIGenBaseModel, IEquatable<SimulationParameter>, IValidatableObject
    {
        /// <summary>
        /// Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the rooms.
        /// </summary>
        /// <value>Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the rooms.</value>
        [DataMember(Name="terrain_type", EmitDefaultValue=false)]
        public TerrianTypes TerrainType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationParameter" /> class.
        /// </summary>
        /// <param name="output">A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them..</param>
        /// <param name="runPeriod">A RunPeriod to describe the time period over which to run the simulation..</param>
        /// <param name="timestep">An integer for the number of timesteps per hour at which the energy calculation will be run. (default to 6).</param>
        /// <param name="simulationControl">A SimulationControl object that describes which types of calculations to run..</param>
        /// <param name="shadowCalculation">A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation..</param>
        /// <param name="sizingParameter">A SizingParameter object with criteria for sizing the heating and cooling system..</param>
        /// <param name="northAngle">A number between -360 and 360 for the north direction in degrees.This is the counterclockwise difference between the North and the positive Y-axis. 90 is West and 270 is East. Note that this is different than the convention used in EnergyPlus, which uses clockwise difference instead of counterclockwise difference. (default to 0D).</param>
        /// <param name="terrainType">Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the rooms..</param>
        public SimulationParameter
        (
             // Required parameters
            SimulationOutput output= default, RunPeriod runPeriod= default, int timestep = 6, SimulationControl simulationControl= default, ShadowCalculation shadowCalculation= default, SizingParameter sizingParameter= default, double northAngle = 0D, TerrianTypes terrainType= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Output = output;
            this.RunPeriod = runPeriod;
            this.Timestep = timestep;
            this.SimulationControl = simulationControl;
            this.ShadowCalculation = shadowCalculation;
            this.SizingParameter = sizingParameter;
            this.NorthAngle = northAngle;
            this.TerrainType = terrainType;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "SimulationParameter";
        /// <summary>
        /// A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them.
        /// </summary>
        /// <value>A SimulationOutput that lists the desired outputs from the simulation and the format in which to report them.</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public SimulationOutput Output { get; set; } 
        /// <summary>
        /// A RunPeriod to describe the time period over which to run the simulation.
        /// </summary>
        /// <value>A RunPeriod to describe the time period over which to run the simulation.</value>
        [DataMember(Name="run_period", EmitDefaultValue=false)]
        public RunPeriod RunPeriod { get; set; } 
        /// <summary>
        /// An integer for the number of timesteps per hour at which the energy calculation will be run.
        /// </summary>
        /// <value>An integer for the number of timesteps per hour at which the energy calculation will be run.</value>
        [DataMember(Name="timestep", EmitDefaultValue=false)]
        public int Timestep { get; set; }  = 6;
        /// <summary>
        /// A SimulationControl object that describes which types of calculations to run.
        /// </summary>
        /// <value>A SimulationControl object that describes which types of calculations to run.</value>
        [DataMember(Name="simulation_control", EmitDefaultValue=false)]
        public SimulationControl SimulationControl { get; set; } 
        /// <summary>
        /// A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation.
        /// </summary>
        /// <value>A ShadowCalculation object describing settings for the EnergyPlus Shadow Calculation.</value>
        [DataMember(Name="shadow_calculation", EmitDefaultValue=false)]
        public ShadowCalculation ShadowCalculation { get; set; } 
        /// <summary>
        /// A SizingParameter object with criteria for sizing the heating and cooling system.
        /// </summary>
        /// <value>A SizingParameter object with criteria for sizing the heating and cooling system.</value>
        [DataMember(Name="sizing_parameter", EmitDefaultValue=false)]
        public SizingParameter SizingParameter { get; set; } 
        /// <summary>
        /// A number between -360 and 360 for the north direction in degrees.This is the counterclockwise difference between the North and the positive Y-axis. 90 is West and 270 is East. Note that this is different than the convention used in EnergyPlus, which uses clockwise difference instead of counterclockwise difference.
        /// </summary>
        /// <value>A number between -360 and 360 for the north direction in degrees.This is the counterclockwise difference between the North and the positive Y-axis. 90 is West and 270 is East. Note that this is different than the convention used in EnergyPlus, which uses clockwise difference instead of counterclockwise difference.</value>
        [DataMember(Name="north_angle", EmitDefaultValue=false)]
        public double NorthAngle { get; set; }  = 0D;

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
        public override string ToString(bool detailed)
        {
            if (!detailed)
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
            sb.Append("  NorthAngle: ").Append(NorthAngle).Append("\n");
            sb.Append("  TerrainType: ").Append(TerrainType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimulationParameter object</returns>
        public static SimulationParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationParameter object</returns>
        public SimulationParameter DuplicateSimulationParameter()
        {
            return FromJson(this.ToJson()) as SimulationParameter;
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
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && base.Equals(input) && 
                (
                    this.RunPeriod == input.RunPeriod ||
                    (this.RunPeriod != null &&
                    this.RunPeriod.Equals(input.RunPeriod))
                ) && base.Equals(input) && 
                (
                    this.Timestep == input.Timestep ||
                    (this.Timestep != null &&
                    this.Timestep.Equals(input.Timestep))
                ) && base.Equals(input) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && base.Equals(input) && 
                (
                    this.ShadowCalculation == input.ShadowCalculation ||
                    (this.ShadowCalculation != null &&
                    this.ShadowCalculation.Equals(input.ShadowCalculation))
                ) && base.Equals(input) && 
                (
                    this.SizingParameter == input.SizingParameter ||
                    (this.SizingParameter != null &&
                    this.SizingParameter.Equals(input.SizingParameter))
                ) && base.Equals(input) && 
                (
                    this.NorthAngle == input.NorthAngle ||
                    (this.NorthAngle != null &&
                    this.NorthAngle.Equals(input.NorthAngle))
                ) && base.Equals(input) && 
                (
                    this.TerrainType == input.TerrainType ||
                    (this.TerrainType != null &&
                    this.TerrainType.Equals(input.TerrainType))
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
                if (this.NorthAngle != null)
                    hashCode = hashCode * 59 + this.NorthAngle.GetHashCode();
                if (this.TerrainType != null)
                    hashCode = hashCode * 59 + this.TerrainType.GetHashCode();
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


            
            // NorthAngle (double) minimum
            if(this.NorthAngle < (double)-360)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NorthAngle, must be a value greater than or equal to -360.", new [] { "NorthAngle" });
            }

            yield break;
        }
    }
}
