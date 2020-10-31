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
    /// Radiance Properties for Honeybee Aperture Abridged.
    /// </summary>
    [DataContract(Name = "ApertureRadiancePropertiesAbridged")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class ApertureRadiancePropertiesAbridged : PropertiesBaseAbridged, IEquatable<ApertureRadiancePropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="dynamicGroupIdentifier">An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None)..</param>
        /// <param name="states">An optional list of abridged states (default: None)..</param>
        /// <param name="modifier">A string for a Honeybee Radiance Modifier (default: None)..</param>
        /// <param name="modifierBlk">A string for a Honeybee Radiance Modifier to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None)..</param>
        public ApertureRadiancePropertiesAbridged
        (
             // Required parameters
            string modifier= default, string modifierBlk= default, string dynamicGroupIdentifier= default, List<RadianceSubFaceStateAbridged> states= default// Optional parameters
        ) : base(modifier: modifier, modifierBlk: modifierBlk)// BaseClass
        {
            this.DynamicGroupIdentifier = dynamicGroupIdentifier;
            this.States = states;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "ApertureRadiancePropertiesAbridged";
        /// <summary>
        /// An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None).
        /// </summary>
        /// <value>An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None).</value>
        [DataMember(Name="dynamic_group_identifier", EmitDefaultValue=false)]
        public string DynamicGroupIdentifier { get; set; } 
        /// <summary>
        /// An optional list of abridged states (default: None).
        /// </summary>
        /// <value>An optional list of abridged states (default: None).</value>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public List<RadianceSubFaceStateAbridged> States { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ApertureRadiancePropertiesAbridged {iDd.Identifier}";
       
            return "ApertureRadiancePropertiesAbridged";
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
            sb.Append("ApertureRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  ModifierBlk: ").Append(ModifierBlk).Append("\n");
            sb.Append("  DynamicGroupIdentifier: ").Append(DynamicGroupIdentifier).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureRadiancePropertiesAbridged object</returns>
        public static ApertureRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureRadiancePropertiesAbridged object</returns>
        public ApertureRadiancePropertiesAbridged DuplicateApertureRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson()) as ApertureRadiancePropertiesAbridged;
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
            return this.Equals(input as ApertureRadiancePropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ApertureRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureRadiancePropertiesAbridged input)
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
                    this.DynamicGroupIdentifier == input.DynamicGroupIdentifier ||
                    (this.DynamicGroupIdentifier != null &&
                    this.DynamicGroupIdentifier.Equals(input.DynamicGroupIdentifier))
                ) && base.Equals(input) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
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
                if (this.DynamicGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.DynamicGroupIdentifier.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureRadiancePropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
