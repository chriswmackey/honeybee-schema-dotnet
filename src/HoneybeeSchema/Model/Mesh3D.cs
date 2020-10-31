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
    /// A mesh in 3D space.
    /// </summary>
    [DataContract(Name = "Mesh3D")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class Mesh3D : OpenAPIGenBaseModel, IEquatable<Mesh3D>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mesh3D() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D" /> class.
        /// </summary>
        /// <param name="vertices">A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values. (required).</param>
        /// <param name="faces">A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices. (required).</param>
        /// <param name="colors">An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh..</param>
        public Mesh3D
        (
             List<List<double>> vertices, List<List<int>> faces, // Required parameters
            List<Color> colors= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "vertices" is required (not null)
            this.Vertices = vertices ?? throw new ArgumentNullException("vertices is a required property for Mesh3D and cannot be null");
            // to ensure "faces" is required (not null)
            this.Faces = faces ?? throw new ArgumentNullException("faces is a required property for Mesh3D and cannot be null");
            this.Colors = colors;
        }
        
        /// <summary>
        /// A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.
        /// </summary>
        /// <value>A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.</value>
        [DataMember(Name="vertices", EmitDefaultValue=true)]
        public List<List<double>> Vertices { get; set; } 
        /// <summary>
        /// A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices.
        /// </summary>
        /// <value>A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices.</value>
        [DataMember(Name="faces", EmitDefaultValue=true)]
        public List<List<int>> Faces { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "Mesh3D";
        /// <summary>
        /// An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh.
        /// </summary>
        /// <value>An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh.</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<Color> Colors { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Mesh3D {iDd.Identifier}";
       
            return "Mesh3D";
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
            sb.Append("Mesh3D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vertices: ").Append(Vertices).Append("\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Mesh3D object</returns>
        public static Mesh3D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Mesh3D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Mesh3D object</returns>
        public Mesh3D DuplicateMesh3D()
        {
            return FromJson(this.ToJson()) as Mesh3D;
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
            return this.Equals(input as Mesh3D);
        }

        /// <summary>
        /// Returns true if Mesh3D instances are equal
        /// </summary>
        /// <param name="input">Instance of Mesh3D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mesh3D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Vertices == input.Vertices ||
                    this.Vertices != null &&
                    input.Vertices != null &&
                    this.Vertices.SequenceEqual(input.Vertices)
                ) && base.Equals(input) && 
                (
                    this.Faces == input.Faces ||
                    this.Faces != null &&
                    input.Faces != null &&
                    this.Faces.SequenceEqual(input.Faces)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    input.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
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
                if (this.Vertices != null)
                    hashCode = hashCode * 59 + this.Vertices.GetHashCode();
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
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
            Regex regexType = new Regex(@"^Mesh3D$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
