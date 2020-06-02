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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract]
    public partial class People : IDdEnergyBaseModel, IEquatable<People>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="People" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected People() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="People" /> class.
        /// </summary>
        /// <param name="peoplePerArea">People per floor area expressed as [people/m2] (required).</param>
        /// <param name="occupancySchedule">A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile. (required).</param>
        /// <param name="activitySchedule">A schedule for the activity of the occupants over the course of the year. The type of this schedule should be Power and the values of the schedule equal to the number of Watts given off by an individual person in the room. (required).</param>
        /// <param name="radiantFraction">The radiant fraction of sensible heat released by people. The defaultvalue is 0.30. (default to 0.3D).</param>
        /// <param name="latentFraction">Number for the latent fraction of heat gain due to people or an Autocalculate object..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public People
        (
            string identifier, double peoplePerArea, AnyOf<ScheduleRuleset,ScheduleFixedInterval> occupancySchedule, AnyOf<ScheduleRuleset,ScheduleFixedInterval> activitySchedule, // Required parameters
            string displayName= default, double radiantFraction = 0.3D, AnyOf<Autocalculate,double> latentFraction= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "peoplePerArea" is required (not null)
            if (peoplePerArea == null)
            {
                throw new InvalidDataException("peoplePerArea is a required property for People and cannot be null");
            }
            else
            {
                this.PeoplePerArea = peoplePerArea;
            }
            
            // to ensure "occupancySchedule" is required (not null)
            if (occupancySchedule == null)
            {
                throw new InvalidDataException("occupancySchedule is a required property for People and cannot be null");
            }
            else
            {
                this.OccupancySchedule = occupancySchedule;
            }
            
            // to ensure "activitySchedule" is required (not null)
            if (activitySchedule == null)
            {
                throw new InvalidDataException("activitySchedule is a required property for People and cannot be null");
            }
            else
            {
                this.ActivitySchedule = activitySchedule;
            }
            
            // use default value if no "radiantFraction" provided
            if (radiantFraction == null)
            {
                this.RadiantFraction = 0.3D;
            }
            else
            {
                this.RadiantFraction = radiantFraction;
            }
            this.LatentFraction = latentFraction;

            // Set non-required readonly properties with defaultValue
            this.Type = "People";
        }
        
        /// <summary>
        /// People per floor area expressed as [people/m2]
        /// </summary>
        /// <value>People per floor area expressed as [people/m2]</value>
        [DataMember(Name="people_per_area", EmitDefaultValue=false)]
        [JsonProperty("people_per_area")]
        public double PeoplePerArea { get; set; } 
        /// <summary>
        /// A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile.
        /// </summary>
        /// <value>A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile.</value>
        [DataMember(Name="occupancy_schedule", EmitDefaultValue=false)]
        [JsonProperty("occupancy_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> OccupancySchedule { get; set; } 
        /// <summary>
        /// A schedule for the activity of the occupants over the course of the year. The type of this schedule should be Power and the values of the schedule equal to the number of Watts given off by an individual person in the room.
        /// </summary>
        /// <value>A schedule for the activity of the occupants over the course of the year. The type of this schedule should be Power and the values of the schedule equal to the number of Watts given off by an individual person in the room.</value>
        [DataMember(Name="activity_schedule", EmitDefaultValue=false)]
        [JsonProperty("activity_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> ActivitySchedule { get; set; } 
        /// <summary>
        /// The radiant fraction of sensible heat released by people. The defaultvalue is 0.30.
        /// </summary>
        /// <value>The radiant fraction of sensible heat released by people. The defaultvalue is 0.30.</value>
        [DataMember(Name="radiant_fraction", EmitDefaultValue=false)]
        [JsonProperty("radiant_fraction")]
        public double RadiantFraction { get; set; }  = 0.3D;
        /// <summary>
        /// Number for the latent fraction of heat gain due to people or an Autocalculate object.
        /// </summary>
        /// <value>Number for the latent fraction of heat gain due to people or an Autocalculate object.</value>
        [DataMember(Name="latent_fraction", EmitDefaultValue=false)]
        [JsonProperty("latent_fraction")]
        public AnyOf<Autocalculate,double> LatentFraction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"People {iDd.Identifier}";
       
            return "People";
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
            sb.Append("People:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PeoplePerArea: ").Append(PeoplePerArea).Append("\n");
            sb.Append("  OccupancySchedule: ").Append(OccupancySchedule).Append("\n");
            sb.Append("  ActivitySchedule: ").Append(ActivitySchedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>People object</returns>
        public static People FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<People>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>People object</returns>
        public People DuplicatePeople()
        {
            return Duplicate() as People;
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
            return this.Equals(input as People);
        }

        /// <summary>
        /// Returns true if People instances are equal
        /// </summary>
        /// <param name="input">Instance of People to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(People input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PeoplePerArea == input.PeoplePerArea ||
                    (this.PeoplePerArea != null &&
                    this.PeoplePerArea.Equals(input.PeoplePerArea))
                ) && base.Equals(input) && 
                (
                    this.OccupancySchedule == input.OccupancySchedule ||
                    (this.OccupancySchedule != null &&
                    this.OccupancySchedule.Equals(input.OccupancySchedule))
                ) && base.Equals(input) && 
                (
                    this.ActivitySchedule == input.ActivitySchedule ||
                    (this.ActivitySchedule != null &&
                    this.ActivitySchedule.Equals(input.ActivitySchedule))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.RadiantFraction == input.RadiantFraction ||
                    (this.RadiantFraction != null &&
                    this.RadiantFraction.Equals(input.RadiantFraction))
                ) && base.Equals(input) && 
                (
                    this.LatentFraction == input.LatentFraction ||
                    (this.LatentFraction != null &&
                    this.LatentFraction.Equals(input.LatentFraction))
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
                if (this.PeoplePerArea != null)
                    hashCode = hashCode * 59 + this.PeoplePerArea.GetHashCode();
                if (this.OccupancySchedule != null)
                    hashCode = hashCode * 59 + this.OccupancySchedule.GetHashCode();
                if (this.ActivitySchedule != null)
                    hashCode = hashCode * 59 + this.ActivitySchedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
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
            // PeoplePerArea (double) minimum
            if(this.PeoplePerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeoplePerArea, must be a value greater than or equal to 0.", new [] { "PeoplePerArea" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^People$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // RadiantFraction (double) maximum
            if(this.RadiantFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value less than or equal to 1.", new [] { "RadiantFraction" });
            }

            // RadiantFraction (double) minimum
            if(this.RadiantFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value greater than or equal to 0.", new [] { "RadiantFraction" });
            }

            yield break;
        }
    }

}
