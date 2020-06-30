/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.34.2
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
    /// Construction for window objects (Aperture, Door).
    /// </summary>
    [DataContract]
    public partial class WindowConstructionShade : IDdEnergyBaseModel, IEquatable<WindowConstructionShade>, IValidatableObject
    {

        /// <summary>
        /// Text to indicate where in the window assembly the shade_material is located.  Note that the WindowConstruction must have at least one gas gap to use the \&quot;Between\&quot; option. Also note that, for a WindowConstruction with more than one gas gap, the \&quot;Between\&quot; option defalts to using the inner gap as this is the only option that EnergyPlus supports.
        /// </summary>
        /// <value>Text to indicate where in the window assembly the shade_material is located.  Note that the WindowConstruction must have at least one gas gap to use the \&quot;Between\&quot; option. Also note that, for a WindowConstruction with more than one gas gap, the \&quot;Between\&quot; option defalts to using the inner gap as this is the only option that EnergyPlus supports.</value>
        [DataMember(Name="shade_location", EmitDefaultValue=false)]
        public ShadeLocation? ShadeLocation { get; set; }   = HoneybeeSchema.ShadeLocation.Interior; 
        /// <summary>
        /// Text to indicate how the shading device is controlled, which determines when the shading is “on” or “off.”
        /// </summary>
        /// <value>Text to indicate how the shading device is controlled, which determines when the shading is “on” or “off.”</value>
        [DataMember(Name="control_type", EmitDefaultValue=false)]
        public ControlType? ControlType { get; set; }   = HoneybeeSchema.ControlType.AlwaysOn; 
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstructionShade" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowConstructionShade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstructionShade" /> class.
        /// </summary>
        /// <param name="windowConstruction">A WindowConstruction object that serves as the \&quot;switched off\&quot; version of the construction (aka. the \&quot;bare construction\&quot;). The shade_material and shade_location will be used to modify this starting construction. (required).</param>
        /// <param name="shadeMaterial">Identifier of a An EnergyWindowMaterialShade or an EnergyWindowMaterialBlind that serves as the shading layer for this construction. This can also be an EnergyWindowMaterialGlazing, which will indicate that the WindowConstruction has a dynamically-controlled glass pane like an electrochromic window assembly. (required).</param>
        /// <param name="shadeLocation">Text to indicate where in the window assembly the shade_material is located.  Note that the WindowConstruction must have at least one gas gap to use the \&quot;Between\&quot; option. Also note that, for a WindowConstruction with more than one gas gap, the \&quot;Between\&quot; option defalts to using the inner gap as this is the only option that EnergyPlus supports. (default to &quot;Interior&quot;).</param>
        /// <param name="controlType">Text to indicate how the shading device is controlled, which determines when the shading is “on” or “off.” (default to &quot;AlwaysOn&quot;).</param>
        /// <param name="setpoint">A number that corresponds to the specified control_type. This can be a value in (W/m2), (C) or (W) depending upon the control type.Note that this value cannot be None for any control type except \&quot;AlwaysOn.\&quot;.</param>
        /// <param name="schedule">An optional ScheduleRuleset or ScheduleFixedInterval to be applied on top of the control_type. If None, the control_type will govern all behavior of the construction..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public WindowConstructionShade
        (
            string identifier, WindowConstruction windowConstruction, AnyOf<EnergyWindowMaterialShade,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing> shadeMaterial, // Required parameters
            string displayName= default, ShadeLocation? shadeLocation = HoneybeeSchema.ShadeLocation.Interior, ControlType? controlType = HoneybeeSchema.ControlType.AlwaysOn, double setpoint= default, AnyOf<ScheduleRuleset,ScheduleFixedInterval> schedule= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "windowConstruction" is required (not null)
            if (windowConstruction == null)
            {
                throw new InvalidDataException("windowConstruction is a required property for WindowConstructionShade and cannot be null");
            }
            else
            {
                this.WindowConstruction = windowConstruction;
            }
            
            // to ensure "shadeMaterial" is required (not null)
            if (shadeMaterial == null)
            {
                throw new InvalidDataException("shadeMaterial is a required property for WindowConstructionShade and cannot be null");
            }
            else
            {
                this.ShadeMaterial = shadeMaterial;
            }
            
            // use default value if no "shadeLocation" provided
            if (shadeLocation == null)
            {
                this.ShadeLocation = HoneybeeSchema.ShadeLocation.Interior;
            }
            else
            {
                this.ShadeLocation = shadeLocation;
            }
            // use default value if no "controlType" provided
            if (controlType == null)
            {
                this.ControlType = HoneybeeSchema.ControlType.AlwaysOn;
            }
            else
            {
                this.ControlType = controlType;
            }
            this.Setpoint = setpoint;
            this.Schedule = schedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "WindowConstructionShade";
        }
        
        /// <summary>
        /// A WindowConstruction object that serves as the \&quot;switched off\&quot; version of the construction (aka. the \&quot;bare construction\&quot;). The shade_material and shade_location will be used to modify this starting construction.
        /// </summary>
        /// <value>A WindowConstruction object that serves as the \&quot;switched off\&quot; version of the construction (aka. the \&quot;bare construction\&quot;). The shade_material and shade_location will be used to modify this starting construction.</value>
        [DataMember(Name="window_construction", EmitDefaultValue=false)]
        [JsonProperty("window_construction")]
        public WindowConstruction WindowConstruction { get; set; } 
        /// <summary>
        /// Identifier of a An EnergyWindowMaterialShade or an EnergyWindowMaterialBlind that serves as the shading layer for this construction. This can also be an EnergyWindowMaterialGlazing, which will indicate that the WindowConstruction has a dynamically-controlled glass pane like an electrochromic window assembly.
        /// </summary>
        /// <value>Identifier of a An EnergyWindowMaterialShade or an EnergyWindowMaterialBlind that serves as the shading layer for this construction. This can also be an EnergyWindowMaterialGlazing, which will indicate that the WindowConstruction has a dynamically-controlled glass pane like an electrochromic window assembly.</value>
        [DataMember(Name="shade_material", EmitDefaultValue=false)]
        [JsonProperty("shade_material")]
        public AnyOf<EnergyWindowMaterialShade,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing> ShadeMaterial { get; set; } 
        /// <summary>
        /// A number that corresponds to the specified control_type. This can be a value in (W/m2), (C) or (W) depending upon the control type.Note that this value cannot be None for any control type except \&quot;AlwaysOn.\&quot;
        /// </summary>
        /// <value>A number that corresponds to the specified control_type. This can be a value in (W/m2), (C) or (W) depending upon the control type.Note that this value cannot be None for any control type except \&quot;AlwaysOn.\&quot;</value>
        [DataMember(Name="setpoint", EmitDefaultValue=false)]
        [JsonProperty("setpoint")]
        public double Setpoint { get; set; } 
        /// <summary>
        /// An optional ScheduleRuleset or ScheduleFixedInterval to be applied on top of the control_type. If None, the control_type will govern all behavior of the construction.
        /// </summary>
        /// <value>An optional ScheduleRuleset or ScheduleFixedInterval to be applied on top of the control_type. If None, the control_type will govern all behavior of the construction.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> Schedule { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"WindowConstructionShade {iDd.Identifier}";
       
            return "WindowConstructionShade";
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
            sb.Append("WindowConstructionShade:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WindowConstruction: ").Append(WindowConstruction).Append("\n");
            sb.Append("  ShadeMaterial: ").Append(ShadeMaterial).Append("\n");
            sb.Append("  ShadeLocation: ").Append(ShadeLocation).Append("\n");
            sb.Append("  ControlType: ").Append(ControlType).Append("\n");
            sb.Append("  Setpoint: ").Append(Setpoint).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowConstructionShade object</returns>
        public static WindowConstructionShade FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WindowConstructionShade>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowConstructionShade object</returns>
        public WindowConstructionShade DuplicateWindowConstructionShade()
        {
            return Duplicate() as WindowConstructionShade;
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
            return this.Equals(input as WindowConstructionShade);
        }

        /// <summary>
        /// Returns true if WindowConstructionShade instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowConstructionShade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowConstructionShade input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.WindowConstruction == input.WindowConstruction ||
                    (this.WindowConstruction != null &&
                    this.WindowConstruction.Equals(input.WindowConstruction))
                ) && base.Equals(input) && 
                (
                    this.ShadeMaterial == input.ShadeMaterial ||
                    (this.ShadeMaterial != null &&
                    this.ShadeMaterial.Equals(input.ShadeMaterial))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.ShadeLocation == input.ShadeLocation ||
                    (this.ShadeLocation != null &&
                    this.ShadeLocation.Equals(input.ShadeLocation))
                ) && base.Equals(input) && 
                (
                    this.ControlType == input.ControlType ||
                    (this.ControlType != null &&
                    this.ControlType.Equals(input.ControlType))
                ) && base.Equals(input) && 
                (
                    this.Setpoint == input.Setpoint ||
                    (this.Setpoint != null &&
                    this.Setpoint.Equals(input.Setpoint))
                ) && base.Equals(input) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.WindowConstruction != null)
                    hashCode = hashCode * 59 + this.WindowConstruction.GetHashCode();
                if (this.ShadeMaterial != null)
                    hashCode = hashCode * 59 + this.ShadeMaterial.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ShadeLocation != null)
                    hashCode = hashCode * 59 + this.ShadeLocation.GetHashCode();
                if (this.ControlType != null)
                    hashCode = hashCode * 59 + this.ControlType.GetHashCode();
                if (this.Setpoint != null)
                    hashCode = hashCode * 59 + this.Setpoint.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
            Regex regexType = new Regex(@"^WindowConstructionShade$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
