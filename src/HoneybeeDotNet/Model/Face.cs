/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
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
using OpenAPIDateConverter = HoneybeeDotNet.Client.OpenAPIDateConverter;

namespace HoneybeeDotNet.Model
{
    /// <summary>
    /// Base class for all objects requiring a valid names for all engines.
    /// </summary>
    [DataContract]
    public partial class Face :  IEquatable<Face>, IValidatableObject
    {
        /// <summary>
        /// Defines FaceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FaceTypeEnum
        {
            /// <summary>
            /// Enum Wall for value: Wall
            /// </summary>
            [EnumMember(Value = "Wall")]
            Wall = 1,

            /// <summary>
            /// Enum Floor for value: Floor
            /// </summary>
            [EnumMember(Value = "Floor")]
            Floor = 2,

            /// <summary>
            /// Enum RoofCeiling for value: RoofCeiling
            /// </summary>
            [EnumMember(Value = "RoofCeiling")]
            RoofCeiling = 3,

            /// <summary>
            /// Enum AirWall for value: AirWall
            /// </summary>
            [EnumMember(Value = "AirWall")]
            AirWall = 4

        }

        /// <summary>
        /// Gets or Sets FaceType
        /// </summary>
        [DataMember(Name="face_type", EmitDefaultValue=false)]
        public FaceTypeEnum FaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Face" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Face() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Face" /> class.
        /// </summary>
        /// <param name="name">Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. (required).</param>
        /// <param name="geometry">Planar Face3D for the geometry. (required).</param>
        /// <param name="faceType">faceType (required).</param>
        /// <param name="boundaryCondition">boundaryCondition (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="displayName">Display name of the object with no restrictions..</param>
        /// <param name="type">type (default to &quot;Face&quot;).</param>
        /// <param name="apertures">Apertures assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid..</param>
        /// <param name="doors">Doors assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid..</param>
        /// <param name="indoorShades">Shades assigned to the interior side of this object..</param>
        /// <param name="outdoorShades">Shades assigned to the exterior side of this object (eg. balcony, overhang)..</param>
        public Face(string name, Face3D geometry, FaceTypeEnum faceType, AnyOfGroundOutdoorsAdiabaticSurface boundaryCondition, FacePropertiesAbridged properties, string displayName = default(string), string type = "Face", List<Aperture> apertures = default(List<Aperture>), List<Door> doors = default(List<Door>), List<Shade> indoorShades = default(List<Shade>), List<Shade> outdoorShades = default(List<Shade>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Face and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new InvalidDataException("geometry is a required property for Face and cannot be null");
            }
            else
            {
                this.Geometry = geometry;
            }
            
            // to ensure "faceType" is required (not null)
            if (faceType == null)
            {
                throw new InvalidDataException("faceType is a required property for Face and cannot be null");
            }
            else
            {
                this.FaceType = faceType;
            }
            
            // to ensure "boundaryCondition" is required (not null)
            if (boundaryCondition == null)
            {
                throw new InvalidDataException("boundaryCondition is a required property for Face and cannot be null");
            }
            else
            {
                this.BoundaryCondition = boundaryCondition;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Face and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "Face";
            }
            else
            {
                this.Type = type;
            }
            this.Apertures = apertures;
            this.Doors = doors;
            this.IndoorShades = indoorShades;
            this.OutdoorShades = outdoorShades;
        }
        
        /// <summary>
        /// Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Planar Face3D for the geometry.
        /// </summary>
        /// <value>Planar Face3D for the geometry.</value>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Face3D Geometry { get; set; }


        /// <summary>
        /// Gets or Sets BoundaryCondition
        /// </summary>
        [DataMember(Name="boundary_condition", EmitDefaultValue=false)]
        public AnyOfGroundOutdoorsAdiabaticSurface BoundaryCondition { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public FacePropertiesAbridged Properties { get; set; }

        /// <summary>
        /// Display name of the object with no restrictions.
        /// </summary>
        /// <value>Display name of the object with no restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Apertures assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid.
        /// </summary>
        /// <value>Apertures assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid.</value>
        [DataMember(Name="apertures", EmitDefaultValue=false)]
        public List<Aperture> Apertures { get; set; }

        /// <summary>
        /// Doors assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid.
        /// </summary>
        /// <value>Doors assigned to this Face. Should be coplanar with this Face and completely within the boundary of the Face to be valid.</value>
        [DataMember(Name="doors", EmitDefaultValue=false)]
        public List<Door> Doors { get; set; }

        /// <summary>
        /// Shades assigned to the interior side of this object.
        /// </summary>
        /// <value>Shades assigned to the interior side of this object.</value>
        [DataMember(Name="indoor_shades", EmitDefaultValue=false)]
        public List<Shade> IndoorShades { get; set; }

        /// <summary>
        /// Shades assigned to the exterior side of this object (eg. balcony, overhang).
        /// </summary>
        /// <value>Shades assigned to the exterior side of this object (eg. balcony, overhang).</value>
        [DataMember(Name="outdoor_shades", EmitDefaultValue=false)]
        public List<Shade> OutdoorShades { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Face {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  FaceType: ").Append(FaceType).Append("\n");
            sb.Append("  BoundaryCondition: ").Append(BoundaryCondition).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Apertures: ").Append(Apertures).Append("\n");
            sb.Append("  Doors: ").Append(Doors).Append("\n");
            sb.Append("  IndoorShades: ").Append(IndoorShades).Append("\n");
            sb.Append("  OutdoorShades: ").Append(OutdoorShades).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Face);
        }

        /// <summary>
        /// Returns true if Face instances are equal
        /// </summary>
        /// <param name="input">Instance of Face to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Face input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.FaceType == input.FaceType ||
                    (this.FaceType != null &&
                    this.FaceType.Equals(input.FaceType))
                ) && 
                (
                    this.BoundaryCondition == input.BoundaryCondition ||
                    (this.BoundaryCondition != null &&
                    this.BoundaryCondition.Equals(input.BoundaryCondition))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Apertures == input.Apertures ||
                    this.Apertures != null &&
                    input.Apertures != null &&
                    this.Apertures.SequenceEqual(input.Apertures)
                ) && 
                (
                    this.Doors == input.Doors ||
                    this.Doors != null &&
                    input.Doors != null &&
                    this.Doors.SequenceEqual(input.Doors)
                ) && 
                (
                    this.IndoorShades == input.IndoorShades ||
                    this.IndoorShades != null &&
                    input.IndoorShades != null &&
                    this.IndoorShades.SequenceEqual(input.IndoorShades)
                ) && 
                (
                    this.OutdoorShades == input.OutdoorShades ||
                    this.OutdoorShades != null &&
                    input.OutdoorShades != null &&
                    this.OutdoorShades.SequenceEqual(input.OutdoorShades)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.FaceType != null)
                    hashCode = hashCode * 59 + this.FaceType.GetHashCode();
                if (this.BoundaryCondition != null)
                    hashCode = hashCode * 59 + this.BoundaryCondition.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Apertures != null)
                    hashCode = hashCode * 59 + this.Apertures.GetHashCode();
                if (this.Doors != null)
                    hashCode = hashCode * 59 + this.Doors.GetHashCode();
                if (this.IndoorShades != null)
                    hashCode = hashCode * 59 + this.IndoorShades.GetHashCode();
                if (this.OutdoorShades != null)
                    hashCode = hashCode * 59 + this.OutdoorShades.GetHashCode();
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

            // Name (string) pattern
            Regex regexName = new Regex(@"[A-Za-z0-9_-]", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^Face$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
