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
    /// Base class for all objects requiring a valid Radiance identifier.
    /// </summary>
    [DataContract(Name = "IDdRadianceBaseModel")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(ModifierSetAbridged), "ModifierSetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ModifierSet), "ModifierSet")]
    [JsonSubtypes.KnownSubType(typeof(ModifierBase), "ModifierBase")]
    [JsonSubtypes.KnownSubType(typeof(StateGeometryAbridged), "StateGeometryAbridged")]
    [JsonSubtypes.KnownSubType(typeof(RadianceAsset), "_RadianceAsset")]
    [JsonSubtypes.KnownSubType(typeof(StateGeometryAbridged), "StateGeometryAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ModifierSet), "ModifierSet")]
    [JsonSubtypes.KnownSubType(typeof(ModifierSetAbridged), "ModifierSetAbridged")]
    [JsonSubtypes.KnownSubType(typeof(ModifierBase), "ModifierBase")]
    [JsonSubtypes.KnownSubType(typeof(RadianceAsset), "_RadianceAsset")]
    [JsonSubtypes.KnownSubType(typeof(Mirror), "Mirror")]
    [JsonSubtypes.KnownSubType(typeof(Metal), "Metal")]
    [JsonSubtypes.KnownSubType(typeof(Trans), "Trans")]
    [JsonSubtypes.KnownSubType(typeof(Light), "Light")]
    [JsonSubtypes.KnownSubType(typeof(Glow), "Glow")]
    [JsonSubtypes.KnownSubType(typeof(BSDF), "BSDF")]
    [JsonSubtypes.KnownSubType(typeof(Glass), "Glass")]
    [JsonSubtypes.KnownSubType(typeof(Plastic), "Plastic")]
    [JsonSubtypes.KnownSubType(typeof(SensorGrid), "SensorGrid")]
    [JsonSubtypes.KnownSubType(typeof(View), "View")]
    public partial class IDdRadianceBaseModel : OpenAPIGenBaseModel, IEquatable<IDdRadianceBaseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IDdRadianceBaseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IDdRadianceBaseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IDdRadianceBaseModel" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public IDdRadianceBaseModel
        (
             string identifier, // Required parameters
            string displayName= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for IDdRadianceBaseModel and cannot be null");
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files.
        /// </summary>
        /// <value>Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files.</value>
        [DataMember(Name="identifier", EmitDefaultValue=true)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "IDdRadianceBaseModel";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"IDdRadianceBaseModel {iDd.Identifier}";
       
            return "IDdRadianceBaseModel";
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
            sb.Append("IDdRadianceBaseModel:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>IDdRadianceBaseModel object</returns>
        public static IDdRadianceBaseModel FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<IDdRadianceBaseModel>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdRadianceBaseModel object</returns>
        public IDdRadianceBaseModel DuplicateIDdRadianceBaseModel()
        {
            return FromJson(this.ToJson()) as IDdRadianceBaseModel;
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
            return this.Equals(input as IDdRadianceBaseModel);
        }

        /// <summary>
        /// Returns true if IDdRadianceBaseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of IDdRadianceBaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IDdRadianceBaseModel input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && base.Equals(input) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^IDdRadianceBaseModel$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
