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
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Model")]
    public partial class Model : IDdBaseModel, IEquatable<Model>, IValidatableObject
    {
        /// <summary>
        /// Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters.
        /// </summary>
        /// <value>Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters.</value>
        [DataMember(Name="units")]
        public Units Units { get; set; } = Units.Meters;
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Model";
            this.Version = "1.48.2";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="rooms">A list of Rooms in the model..</param>
        /// <param name="orphanedFaces">A list of Faces in the model that lack a parent Room. Note that orphaned Faces are not acceptable for Models that are to be exported for energy simulation..</param>
        /// <param name="orphanedShades">A list of Shades in the model that lack a parent..</param>
        /// <param name="orphanedApertures">A list of Apertures in the model that lack a parent Face. Note that orphaned Apertures are not acceptable for Models that are to be exported for energy simulation..</param>
        /// <param name="orphanedDoors">A list of Doors in the model that lack a parent Face. Note that orphaned Doors are not acceptable for Models that are to be exported for energy simulation..</param>
        /// <param name="units">Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters..</param>
        /// <param name="tolerance">The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and it is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters. (default to 0.01D).</param>
        /// <param name="angleTolerance">The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a given Model. (default to 1.0D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Model
        (
            string identifier, ModelProperties properties, // Required parameters
            string displayName= default, Object userData= default, List<Room> rooms= default, List<Face> orphanedFaces= default, List<Shade> orphanedShades= default, List<Aperture> orphanedApertures= default, List<Door> orphanedDoors= default, Units units= Units.Meters, double tolerance = 0.01D, double angleTolerance = 1.0D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData)// BaseClass
        {
            // to ensure "properties" is required (not null)
            this.Properties = properties ?? throw new ArgumentNullException("properties is a required property for Model and cannot be null");
            this.Rooms = rooms;
            this.OrphanedFaces = orphanedFaces;
            this.OrphanedShades = orphanedShades;
            this.OrphanedApertures = orphanedApertures;
            this.OrphanedDoors = orphanedDoors;
            this.Units = units;
            this.Tolerance = tolerance;
            this.AngleTolerance = angleTolerance;

            // Set non-required readonly properties with defaultValue
            this.Type = "Model";
            this.Version = "1.48.2";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Model))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Model";
        //============================================== is ReadOnly 
        /// <summary>
        /// Text string for the current version of the schema.
        /// </summary>
        /// <value>Text string for the current version of the schema.</value>
        [DataMember(Name = "version")]
        public string Version { get; protected set; }  = "1.48.2";

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name = "properties", IsRequired = true)]
        public ModelProperties Properties { get; set; } 
        /// <summary>
        /// A list of Rooms in the model.
        /// </summary>
        /// <value>A list of Rooms in the model.</value>
        [DataMember(Name = "rooms")]
        public List<Room> Rooms { get; set; } 
        /// <summary>
        /// A list of Faces in the model that lack a parent Room. Note that orphaned Faces are not acceptable for Models that are to be exported for energy simulation.
        /// </summary>
        /// <value>A list of Faces in the model that lack a parent Room. Note that orphaned Faces are not acceptable for Models that are to be exported for energy simulation.</value>
        [DataMember(Name = "orphaned_faces")]
        public List<Face> OrphanedFaces { get; set; } 
        /// <summary>
        /// A list of Shades in the model that lack a parent.
        /// </summary>
        /// <value>A list of Shades in the model that lack a parent.</value>
        [DataMember(Name = "orphaned_shades")]
        public List<Shade> OrphanedShades { get; set; } 
        /// <summary>
        /// A list of Apertures in the model that lack a parent Face. Note that orphaned Apertures are not acceptable for Models that are to be exported for energy simulation.
        /// </summary>
        /// <value>A list of Apertures in the model that lack a parent Face. Note that orphaned Apertures are not acceptable for Models that are to be exported for energy simulation.</value>
        [DataMember(Name = "orphaned_apertures")]
        public List<Aperture> OrphanedApertures { get; set; } 
        /// <summary>
        /// A list of Doors in the model that lack a parent Face. Note that orphaned Doors are not acceptable for Models that are to be exported for energy simulation.
        /// </summary>
        /// <value>A list of Doors in the model that lack a parent Face. Note that orphaned Doors are not acceptable for Models that are to be exported for energy simulation.</value>
        [DataMember(Name = "orphaned_doors")]
        public List<Door> OrphanedDoors { get; set; } 
        /// <summary>
        /// The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and it is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.
        /// </summary>
        /// <value>The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and it is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.</value>
        [DataMember(Name = "tolerance")]
        public double Tolerance { get; set; }  = 0.01D;
        /// <summary>
        /// The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a given Model.
        /// </summary>
        /// <value>The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks, including checks for whether Room faces form a closed volume and subsequently correcting all face normals point outward from the Room. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when such checks have not already been performed on a given Model.</value>
        [DataMember(Name = "angle_tolerance")]
        public double AngleTolerance { get; set; }  = 1.0D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Model";
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
            sb.Append("Model:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
            sb.Append("  OrphanedFaces: ").Append(OrphanedFaces).Append("\n");
            sb.Append("  OrphanedShades: ").Append(OrphanedShades).Append("\n");
            sb.Append("  OrphanedApertures: ").Append(OrphanedApertures).Append("\n");
            sb.Append("  OrphanedDoors: ").Append(OrphanedDoors).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
            sb.Append("  AngleTolerance: ").Append(AngleTolerance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Model object</returns>
        public static Model FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Model>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Model object</returns>
        public virtual Model DuplicateModel()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateModel();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateModel();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Model);
        }

        /// <summary>
        /// Returns true if Model instances are equal
        /// </summary>
        /// <param name="input">Instance of Model to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    Extension.Equals(this.Properties, input.Properties)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Type, input.Type)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Version, input.Version)
                ) && base.Equals(input) && 
                (
                    this.Rooms == input.Rooms ||
                    Extension.AllEquals(this.Rooms, input.Rooms)
                ) && base.Equals(input) && 
                (
                    this.OrphanedFaces == input.OrphanedFaces ||
                    Extension.AllEquals(this.OrphanedFaces, input.OrphanedFaces)
                ) && base.Equals(input) && 
                (
                    this.OrphanedShades == input.OrphanedShades ||
                    Extension.AllEquals(this.OrphanedShades, input.OrphanedShades)
                ) && base.Equals(input) && 
                (
                    this.OrphanedApertures == input.OrphanedApertures ||
                    Extension.AllEquals(this.OrphanedApertures, input.OrphanedApertures)
                ) && base.Equals(input) && 
                (
                    this.OrphanedDoors == input.OrphanedDoors ||
                    Extension.AllEquals(this.OrphanedDoors, input.OrphanedDoors)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Units, input.Units)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Tolerance, input.Tolerance)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.AngleTolerance, input.AngleTolerance)
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Rooms != null)
                    hashCode = hashCode * 59 + this.Rooms.GetHashCode();
                if (this.OrphanedFaces != null)
                    hashCode = hashCode * 59 + this.OrphanedFaces.GetHashCode();
                if (this.OrphanedShades != null)
                    hashCode = hashCode * 59 + this.OrphanedShades.GetHashCode();
                if (this.OrphanedApertures != null)
                    hashCode = hashCode * 59 + this.OrphanedApertures.GetHashCode();
                if (this.OrphanedDoors != null)
                    hashCode = hashCode * 59 + this.OrphanedDoors.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                if (this.AngleTolerance != null)
                    hashCode = hashCode * 59 + this.AngleTolerance.GetHashCode();
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
            Regex regexType = new Regex(@"^Model$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // Version (string) pattern
            Regex regexVersion = new Regex(@"([0-9]+)\.([0-9]+)\.([0-9]+)", RegexOptions.CultureInvariant);
            if (this.Version != null && false == regexVersion.Match(this.Version).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must match a pattern of " + regexVersion, new [] { "Version" });
            }


            
            // Tolerance (double) minimum
            if(this.Tolerance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tolerance, must be a value greater than or equal to 0.", new [] { "Tolerance" });
            }


            
            // AngleTolerance (double) minimum
            if(this.AngleTolerance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AngleTolerance, must be a value greater than or equal to 0.", new [] { "AngleTolerance" });
            }

            yield break;
        }
    }
}
