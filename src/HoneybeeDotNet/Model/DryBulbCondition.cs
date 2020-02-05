/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.14.1
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


namespace HoneybeeDotNet
{
    /// <summary>
    /// Used to specify dry bulb conditions on a design day.
    /// </summary>
    [DataContract]
    public partial class DryBulbCondition :  IEquatable<DryBulbCondition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DryBulbCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DryBulbCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DryBulbCondition" /> class.
        /// </summary>
        /// <param name="dryBulbMax">The maximum dry bulb temperature on the design day [C]. (required).</param>
        /// <param name="dryBulbRange">The difference between min and max temperatures on thedesign day [C]. (required).</param>
        /// <param name="type">type (default to &quot;DryBulbCondition&quot;).</param>
        public DryBulbCondition(double dryBulbMax, double dryBulbRange, string type = "DryBulbCondition")
        {
            // to ensure "dryBulbMax" is required (not null)
            if (dryBulbMax == null)
            {
                throw new InvalidDataException("dryBulbMax is a required property for DryBulbCondition and cannot be null");
            }
            else
            {
                this.DryBulbMax = dryBulbMax;
            }
            
            // to ensure "dryBulbRange" is required (not null)
            if (dryBulbRange == null)
            {
                throw new InvalidDataException("dryBulbRange is a required property for DryBulbCondition and cannot be null");
            }
            else
            {
                this.DryBulbRange = dryBulbRange;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "DryBulbCondition";
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// The maximum dry bulb temperature on the design day [C].
        /// </summary>
        /// <value>The maximum dry bulb temperature on the design day [C].</value>
        [DataMember(Name="dry_bulb_max", EmitDefaultValue=false)]
        [JsonProperty("dry_bulb_max")]
        public double DryBulbMax { get; set; }

        /// <summary>
        /// The difference between min and max temperatures on thedesign day [C].
        /// </summary>
        /// <value>The difference between min and max temperatures on thedesign day [C].</value>
        [DataMember(Name="dry_bulb_range", EmitDefaultValue=false)]
        [JsonProperty("dry_bulb_range")]
        public double DryBulbRange { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DryBulbCondition {\n");
            sb.Append("  DryBulbMax: ").Append(DryBulbMax).Append("\n");
            sb.Append("  DryBulbRange: ").Append(DryBulbRange).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
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
        /// <returns>DryBulbCondition object</returns>
        public static DryBulbCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DryBulbCondition>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DryBulbCondition);
        }

        /// <summary>
        /// Returns true if DryBulbCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of DryBulbCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DryBulbCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DryBulbMax == input.DryBulbMax ||
                    (this.DryBulbMax != null &&
                    this.DryBulbMax.Equals(input.DryBulbMax))
                ) && 
                (
                    this.DryBulbRange == input.DryBulbRange ||
                    (this.DryBulbRange != null &&
                    this.DryBulbRange.Equals(input.DryBulbRange))
                ) && 
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
                int hashCode = 41;
                if (this.DryBulbMax != null)
                    hashCode = hashCode * 59 + this.DryBulbMax.GetHashCode();
                if (this.DryBulbRange != null)
                    hashCode = hashCode * 59 + this.DryBulbRange.GetHashCode();
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
            // DryBulbMax (double) maximum
            if(this.DryBulbMax > (double)70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DryBulbMax, must be a value less than or equal to 70.", new [] { "DryBulbMax" });
            }

            // DryBulbMax (double) minimum
            if(this.DryBulbMax < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DryBulbMax, must be a value greater than or equal to -90.", new [] { "DryBulbMax" });
            }

            // DryBulbRange (double) minimum
            if(this.DryBulbRange < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DryBulbRange, must be a value greater than or equal to 0.", new [] { "DryBulbRange" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^DryBulbCondition$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
