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
    /// A single Radiance of sensors.
    /// </summary>
    [Serializable]
    [DataContract(Name = "View")]
    public partial class View : RadianceAsset, IEquatable<View>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ViewType
        /// </summary>
        [DataMember(Name="view_type")]
        public ViewType ViewType { get; set; } = ViewType.v;
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected View() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "View";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="position">The view position (-vp) as an array of (x, y, z) values.This is the focal point of a perspective view or the center of a parallel projection. (required).</param>
        /// <param name="direction">The view direction (-vd) as an array of (x, y, z) values.The length of this vector indicates the focal distance as needed by the pixel depth of field (-pd) in rpict. (required).</param>
        /// <param name="upVector">The view up (-vu) vector as an array of (x, y, z) values. (required).</param>
        /// <param name="viewType">viewType.</param>
        /// <param name="hSize">A number for the horizontal field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates. (default to 60D).</param>
        /// <param name="vSize">A number for the vertical field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates. (default to 60D).</param>
        /// <param name="shift">The view shift (-vs). This is the amount the actual image will be shifted to the right of the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well..</param>
        /// <param name="lift">The view lift (-vl). This is the amount the actual image will be lifted up from the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well..</param>
        /// <param name="foreClip">View fore clip (-vo) at a distance from the view point.The plane will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with fore_clip radius. Objects in front of this imaginary surface will not be visible..</param>
        /// <param name="aftClip">View aft clip (-va) at a distance from the view point.Like the view fore plane, it will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with radius val..</param>
        /// <param name="groupIdentifier">An optional string to note the view group &#39;             &#39;to which the sensor is a part of. Views sharing the same &#39;             &#39;group_identifier will be written to the same subfolder in Radiance &#39;             &#39;folder (default: None)..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="roomIdentifier">Optional text string for the Room identifier to which this object belongs. This will be used to narrow down the number of aperture groups that have to be run with this sensor grid. If None, the grid will be run with all aperture groups in the model..</param>
        /// <param name="lightPath">Get or set a list of lists for the light path from the object to the sky. Each sub-list contains identifiers of aperture groups through which light passes. (eg. [[\&quot;SouthWindow1\&quot;], [\&quot;static_apertures\&quot;, \&quot;NorthWindow2\&quot;]]).Setting this property will override any auto-calculation of the light path from the model and room_identifier upon export to the simulation..</param>
        public View
        (
            string identifier, List<double> position, List<double> direction, List<double> upVector, // Required parameters
            string displayName= default, string roomIdentifier= default, List<List<string>> lightPath= default, ViewType viewType= ViewType.v, double hSize = 60D, double vSize = 60D, double shift= default, double lift= default, double foreClip= default, double aftClip= default, string groupIdentifier= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, roomIdentifier: roomIdentifier, lightPath: lightPath)// BaseClass
        {
            // to ensure "position" is required (not null)
            this.Position = position ?? throw new ArgumentNullException("position is a required property for View and cannot be null");
            // to ensure "direction" is required (not null)
            this.Direction = direction ?? throw new ArgumentNullException("direction is a required property for View and cannot be null");
            // to ensure "upVector" is required (not null)
            this.UpVector = upVector ?? throw new ArgumentNullException("upVector is a required property for View and cannot be null");
            this.ViewType = viewType;
            this.HSize = hSize;
            this.VSize = vSize;
            this.Shift = shift;
            this.Lift = lift;
            this.ForeClip = foreClip;
            this.AftClip = aftClip;
            this.GroupIdentifier = groupIdentifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "View";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(View))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "View";

        /// <summary>
        /// The view position (-vp) as an array of (x, y, z) values.This is the focal point of a perspective view or the center of a parallel projection.
        /// </summary>
        /// <value>The view position (-vp) as an array of (x, y, z) values.This is the focal point of a perspective view or the center of a parallel projection.</value>
        [DataMember(Name = "position", IsRequired = true)]
        public List<double> Position { get; set; } 
        /// <summary>
        /// The view direction (-vd) as an array of (x, y, z) values.The length of this vector indicates the focal distance as needed by the pixel depth of field (-pd) in rpict.
        /// </summary>
        /// <value>The view direction (-vd) as an array of (x, y, z) values.The length of this vector indicates the focal distance as needed by the pixel depth of field (-pd) in rpict.</value>
        [DataMember(Name = "direction", IsRequired = true)]
        public List<double> Direction { get; set; } 
        /// <summary>
        /// The view up (-vu) vector as an array of (x, y, z) values.
        /// </summary>
        /// <value>The view up (-vu) vector as an array of (x, y, z) values.</value>
        [DataMember(Name = "up_vector", IsRequired = true)]
        public List<double> UpVector { get; set; } 
        /// <summary>
        /// A number for the horizontal field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates.
        /// </summary>
        /// <value>A number for the horizontal field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates.</value>
        [DataMember(Name = "h_size")]
        public double HSize { get; set; }  = 60D;
        /// <summary>
        /// A number for the vertical field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates.
        /// </summary>
        /// <value>A number for the vertical field of view in degrees (for all perspective projections including fisheye). For a parallel projection, this is the view width in world coordinates.</value>
        [DataMember(Name = "v_size")]
        public double VSize { get; set; }  = 60D;
        /// <summary>
        /// The view shift (-vs). This is the amount the actual image will be shifted to the right of the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well.
        /// </summary>
        /// <value>The view shift (-vs). This is the amount the actual image will be shifted to the right of the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well.</value>
        [DataMember(Name = "shift")]
        public double Shift { get; set; } 
        /// <summary>
        /// The view lift (-vl). This is the amount the actual image will be lifted up from the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well.
        /// </summary>
        /// <value>The view lift (-vl). This is the amount the actual image will be lifted up from the specified view. This option is useful for generating skewed perspectives or rendering an image a piece at a time. A value of 1 means that the rendered image starts just to the right of the normal view. A value of -1 would be to the left. Larger or fractional values are permitted as well.</value>
        [DataMember(Name = "lift")]
        public double Lift { get; set; } 
        /// <summary>
        /// View fore clip (-vo) at a distance from the view point.The plane will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with fore_clip radius. Objects in front of this imaginary surface will not be visible.
        /// </summary>
        /// <value>View fore clip (-vo) at a distance from the view point.The plane will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with fore_clip radius. Objects in front of this imaginary surface will not be visible.</value>
        [DataMember(Name = "fore_clip")]
        public double ForeClip { get; set; } 
        /// <summary>
        /// View aft clip (-va) at a distance from the view point.Like the view fore plane, it will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with radius val.
        /// </summary>
        /// <value>View aft clip (-va) at a distance from the view point.Like the view fore plane, it will be perpendicular to the view direction for perspective and parallel view types. For fisheye view types, the clipping plane is actually a clipping sphere, centered on the view point with radius val.</value>
        [DataMember(Name = "aft_clip")]
        public double AftClip { get; set; } 
        /// <summary>
        /// An optional string to note the view group &#39;             &#39;to which the sensor is a part of. Views sharing the same &#39;             &#39;group_identifier will be written to the same subfolder in Radiance &#39;             &#39;folder (default: None).
        /// </summary>
        /// <value>An optional string to note the view group &#39;             &#39;to which the sensor is a part of. Views sharing the same &#39;             &#39;group_identifier will be written to the same subfolder in Radiance &#39;             &#39;folder (default: None).</value>
        [DataMember(Name = "group_identifier")]
        public string GroupIdentifier { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "View";
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
            sb.Append("View:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  RoomIdentifier: ").Append(RoomIdentifier).Append("\n");
            sb.Append("  LightPath: ").Append(LightPath).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  UpVector: ").Append(UpVector).Append("\n");
            sb.Append("  ViewType: ").Append(ViewType).Append("\n");
            sb.Append("  HSize: ").Append(HSize).Append("\n");
            sb.Append("  VSize: ").Append(VSize).Append("\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
            sb.Append("  Lift: ").Append(Lift).Append("\n");
            sb.Append("  ForeClip: ").Append(ForeClip).Append("\n");
            sb.Append("  AftClip: ").Append(AftClip).Append("\n");
            sb.Append("  GroupIdentifier: ").Append(GroupIdentifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>View object</returns>
        public static View FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<View>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>View object</returns>
        public virtual View DuplicateView()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateView();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override RadianceAsset DuplicateRadianceAsset()
        {
            return DuplicateView();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as View);
        }

        /// <summary>
        /// Returns true if View instances are equal
        /// </summary>
        /// <param name="input">Instance of View to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(View input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Position == input.Position ||
                    Extension.AllEquals(this.Position, input.Position)
                ) && base.Equals(input) && 
                (
                    this.Direction == input.Direction ||
                    Extension.AllEquals(this.Direction, input.Direction)
                ) && base.Equals(input) && 
                (
                    this.UpVector == input.UpVector ||
                    Extension.AllEquals(this.UpVector, input.UpVector)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.ViewType == input.ViewType ||
                    (this.ViewType != null &&
                    this.ViewType.Equals(input.ViewType))
                ) && base.Equals(input) && 
                (
                    this.HSize == input.HSize ||
                    (this.HSize != null &&
                    this.HSize.Equals(input.HSize))
                ) && base.Equals(input) && 
                (
                    this.VSize == input.VSize ||
                    (this.VSize != null &&
                    this.VSize.Equals(input.VSize))
                ) && base.Equals(input) && 
                (
                    this.Shift == input.Shift ||
                    (this.Shift != null &&
                    this.Shift.Equals(input.Shift))
                ) && base.Equals(input) && 
                (
                    this.Lift == input.Lift ||
                    (this.Lift != null &&
                    this.Lift.Equals(input.Lift))
                ) && base.Equals(input) && 
                (
                    this.ForeClip == input.ForeClip ||
                    (this.ForeClip != null &&
                    this.ForeClip.Equals(input.ForeClip))
                ) && base.Equals(input) && 
                (
                    this.AftClip == input.AftClip ||
                    (this.AftClip != null &&
                    this.AftClip.Equals(input.AftClip))
                ) && base.Equals(input) && 
                (
                    this.GroupIdentifier == input.GroupIdentifier ||
                    (this.GroupIdentifier != null &&
                    this.GroupIdentifier.Equals(input.GroupIdentifier))
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
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.UpVector != null)
                    hashCode = hashCode * 59 + this.UpVector.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewType != null)
                    hashCode = hashCode * 59 + this.ViewType.GetHashCode();
                if (this.HSize != null)
                    hashCode = hashCode * 59 + this.HSize.GetHashCode();
                if (this.VSize != null)
                    hashCode = hashCode * 59 + this.VSize.GetHashCode();
                if (this.Shift != null)
                    hashCode = hashCode * 59 + this.Shift.GetHashCode();
                if (this.Lift != null)
                    hashCode = hashCode * 59 + this.Lift.GetHashCode();
                if (this.ForeClip != null)
                    hashCode = hashCode * 59 + this.ForeClip.GetHashCode();
                if (this.AftClip != null)
                    hashCode = hashCode * 59 + this.AftClip.GetHashCode();
                if (this.GroupIdentifier != null)
                    hashCode = hashCode * 59 + this.GroupIdentifier.GetHashCode();
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
            Regex regexType = new Regex(@"^View$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
