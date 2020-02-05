/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Surface
    /// </summary>
    [DataContract]
    public partial class Surface :  IEquatable<Surface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Surface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Surface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Surface" /> class.
        /// </summary>
        /// <param name="boundaryConditionObjects">A list of up to 3 object names that are adjacent to this one. The first object is always the one that is immediately adjacet and is of the same object type (Face, Aperture, Door). When this boundary condition is applied to a Face, the second object in the tuple will be the parent Room of the adjacent object. When the boundary condition is applied to a sub-face (Door or Aperture), the second object will be the parent Face of the adjacent sub-face and the third object will be the parent Room of the adjacent sub-face. (required).</param>
        /// <param name="type">type (default to &quot;Surface&quot;).</param>
        public Surface(List<string> boundaryConditionObjects, string type = "Surface")
        {
            // to ensure "boundaryConditionObjects" is required (not null)
            if (boundaryConditionObjects == null)
            {
                throw new InvalidDataException("boundaryConditionObjects is a required property for Surface and cannot be null");
            }
            else
            {
                this.BoundaryConditionObjects = boundaryConditionObjects;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "Surface";
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// A list of up to 3 object names that are adjacent to this one. The first object is always the one that is immediately adjacet and is of the same object type (Face, Aperture, Door). When this boundary condition is applied to a Face, the second object in the tuple will be the parent Room of the adjacent object. When the boundary condition is applied to a sub-face (Door or Aperture), the second object will be the parent Face of the adjacent sub-face and the third object will be the parent Room of the adjacent sub-face.
        /// </summary>
        /// <value>A list of up to 3 object names that are adjacent to this one. The first object is always the one that is immediately adjacet and is of the same object type (Face, Aperture, Door). When this boundary condition is applied to a Face, the second object in the tuple will be the parent Room of the adjacent object. When the boundary condition is applied to a sub-face (Door or Aperture), the second object will be the parent Face of the adjacent sub-face and the third object will be the parent Room of the adjacent sub-face.</value>
        [DataMember(Name="boundary_condition_objects", EmitDefaultValue=false)]
        [JsonProperty("boundary_condition_objects")]
        public List<string> BoundaryConditionObjects { get; set; }

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
            sb.Append("class Surface {\n");
            sb.Append("  BoundaryConditionObjects: ").Append(BoundaryConditionObjects).Append("\n");
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
        /// <returns>Surface object</returns>
        public static Surface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Surface>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Surface);
        }

        /// <summary>
        /// Returns true if Surface instances are equal
        /// </summary>
        /// <param name="input">Instance of Surface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Surface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundaryConditionObjects == input.BoundaryConditionObjects ||
                    this.BoundaryConditionObjects != null &&
                    input.BoundaryConditionObjects != null &&
                    this.BoundaryConditionObjects.SequenceEqual(input.BoundaryConditionObjects)
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
                if (this.BoundaryConditionObjects != null)
                    hashCode = hashCode * 59 + this.BoundaryConditionObjects.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^Surface$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
