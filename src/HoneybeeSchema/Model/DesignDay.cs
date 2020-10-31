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
    /// An object representing design day conditions.
    /// </summary>
    [DataContract(Name = "DesignDay")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class DesignDay : OpenAPIGenBaseModel, IEquatable<DesignDay>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DayType
        /// </summary>
        [DataMember(Name="day_type", EmitDefaultValue=false)]
        public DesignDayTypes DayType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignDay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DesignDay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignDay" /> class.
        /// </summary>
        /// <param name="name">Text string for a unique design day name. This name remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). It is also used to reference the object within SimulationParameters. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="dayType">dayType (required).</param>
        /// <param name="dryBulbCondition">A DryBulbCondition describing temperature conditions on the design day. (required).</param>
        /// <param name="humidityCondition">A HumidityCondition describing humidity and precipitation conditions on the design day. (required).</param>
        /// <param name="windCondition">A WindCondition describing wind conditions on the design day. (required).</param>
        /// <param name="skyCondition">skyCondition (required).</param>
        public DesignDay
        (
             string name, DesignDayTypes dayType, DryBulbCondition dryBulbCondition, HumidityCondition humidityCondition, WindCondition windCondition, AnyOf<ASHRAEClearSky,ASHRAETau> skyCondition// Required parameters
             // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DesignDay and cannot be null");
            this.DayType = dayType;
            // to ensure "dryBulbCondition" is required (not null)
            this.DryBulbCondition = dryBulbCondition ?? throw new ArgumentNullException("dryBulbCondition is a required property for DesignDay and cannot be null");
            // to ensure "humidityCondition" is required (not null)
            this.HumidityCondition = humidityCondition ?? throw new ArgumentNullException("humidityCondition is a required property for DesignDay and cannot be null");
            // to ensure "windCondition" is required (not null)
            this.WindCondition = windCondition ?? throw new ArgumentNullException("windCondition is a required property for DesignDay and cannot be null");
            // to ensure "skyCondition" is required (not null)
            this.SkyCondition = skyCondition ?? throw new ArgumentNullException("skyCondition is a required property for DesignDay and cannot be null");
        }
        
        /// <summary>
        /// Text string for a unique design day name. This name remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). It is also used to reference the object within SimulationParameters. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique design day name. This name remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). It is also used to reference the object within SimulationParameters. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; } 
        /// <summary>
        /// A DryBulbCondition describing temperature conditions on the design day.
        /// </summary>
        /// <value>A DryBulbCondition describing temperature conditions on the design day.</value>
        [DataMember(Name="dry_bulb_condition", EmitDefaultValue=true)]
        public DryBulbCondition DryBulbCondition { get; set; } 
        /// <summary>
        /// A HumidityCondition describing humidity and precipitation conditions on the design day.
        /// </summary>
        /// <value>A HumidityCondition describing humidity and precipitation conditions on the design day.</value>
        [DataMember(Name="humidity_condition", EmitDefaultValue=true)]
        public HumidityCondition HumidityCondition { get; set; } 
        /// <summary>
        /// A WindCondition describing wind conditions on the design day.
        /// </summary>
        /// <value>A WindCondition describing wind conditions on the design day.</value>
        [DataMember(Name="wind_condition", EmitDefaultValue=true)]
        public WindCondition WindCondition { get; set; } 
        /// <summary>
        /// Gets or Sets SkyCondition
        /// </summary>
        [DataMember(Name="sky_condition", EmitDefaultValue=true)]
        public AnyOf<ASHRAEClearSky,ASHRAETau> SkyCondition { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "DesignDay";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DesignDay {iDd.Identifier}";
       
            return "DesignDay";
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
            sb.Append("DesignDay:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DayType: ").Append(DayType).Append("\n");
            sb.Append("  DryBulbCondition: ").Append(DryBulbCondition).Append("\n");
            sb.Append("  HumidityCondition: ").Append(HumidityCondition).Append("\n");
            sb.Append("  WindCondition: ").Append(WindCondition).Append("\n");
            sb.Append("  SkyCondition: ").Append(SkyCondition).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DesignDay object</returns>
        public static DesignDay FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DesignDay>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DesignDay object</returns>
        public DesignDay DuplicateDesignDay()
        {
            return FromJson(this.ToJson()) as DesignDay;
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
            return this.Equals(input as DesignDay);
        }

        /// <summary>
        /// Returns true if DesignDay instances are equal
        /// </summary>
        /// <param name="input">Instance of DesignDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignDay input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.DayType == input.DayType ||
                    (this.DayType != null &&
                    this.DayType.Equals(input.DayType))
                ) && base.Equals(input) && 
                (
                    this.DryBulbCondition == input.DryBulbCondition ||
                    (this.DryBulbCondition != null &&
                    this.DryBulbCondition.Equals(input.DryBulbCondition))
                ) && base.Equals(input) && 
                (
                    this.HumidityCondition == input.HumidityCondition ||
                    (this.HumidityCondition != null &&
                    this.HumidityCondition.Equals(input.HumidityCondition))
                ) && base.Equals(input) && 
                (
                    this.WindCondition == input.WindCondition ||
                    (this.WindCondition != null &&
                    this.WindCondition.Equals(input.WindCondition))
                ) && base.Equals(input) && 
                (
                    this.SkyCondition == input.SkyCondition ||
                    (this.SkyCondition != null &&
                    this.SkyCondition.Equals(input.SkyCondition))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DayType != null)
                    hashCode = hashCode * 59 + this.DayType.GetHashCode();
                if (this.DryBulbCondition != null)
                    hashCode = hashCode * 59 + this.DryBulbCondition.GetHashCode();
                if (this.HumidityCondition != null)
                    hashCode = hashCode * 59 + this.HumidityCondition.GetHashCode();
                if (this.WindCondition != null)
                    hashCode = hashCode * 59 + this.WindCondition.GetHashCode();
                if (this.SkyCondition != null)
                    hashCode = hashCode * 59 + this.SkyCondition.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
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
            Regex regexType = new Regex(@"^DesignDay$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
