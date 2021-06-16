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
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Used to specify sky conditions on a design day.
    /// </summary>
    [DataContract(Name = "ASHRAETau")]
    public partial class ASHRAETau : SkyCondition, IEquatable<ASHRAETau>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASHRAETau" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ASHRAETau() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ASHRAETau";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ASHRAETau" /> class.
        /// </summary>
        /// <param name="tauB">Value for the beam optical depth. Typically found in .stat files. (required).</param>
        /// <param name="tauD">Value for the diffuse optical depth. Typically found in .stat files. (required).</param>
        /// <param name="date">A list of two integers for [month, day], representing the date for the day of the year on which the design day occurs. A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case). (required).</param>
        /// <param name="daylightSavings">Boolean to indicate whether daylight savings time is active on the design day. (default to false).</param>
        public ASHRAETau
        (
            List<int> date, double tauB, double tauD, // Required parameters
            bool daylightSavings = false // Optional parameters
        ) : base(date: date, daylightSavings: daylightSavings)// BaseClass
        {
            this.TauB = tauB;
            this.TauD = tauD;

            // Set non-required readonly properties with defaultValue
            this.Type = "ASHRAETau";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ASHRAETau))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ASHRAETau";

        /// <summary>
        /// Value for the beam optical depth. Typically found in .stat files.
        /// </summary>
        /// <value>Value for the beam optical depth. Typically found in .stat files.</value>
        [DataMember(Name = "tau_b", IsRequired = true)]
        public double TauB { get; set; } 
        /// <summary>
        /// Value for the diffuse optical depth. Typically found in .stat files.
        /// </summary>
        /// <value>Value for the diffuse optical depth. Typically found in .stat files.</value>
        [DataMember(Name = "tau_d", IsRequired = true)]
        public double TauD { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ASHRAETau";
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
            sb.Append("ASHRAETau:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DaylightSavings: ").Append(DaylightSavings).Append("\n");
            sb.Append("  TauB: ").Append(TauB).Append("\n");
            sb.Append("  TauD: ").Append(TauD).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ASHRAETau object</returns>
        public static ASHRAETau FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ASHRAETau>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ASHRAETau object</returns>
        public virtual ASHRAETau DuplicateASHRAETau()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateASHRAETau();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override SkyCondition DuplicateSkyCondition()
        {
            return DuplicateASHRAETau();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ASHRAETau);
        }

        /// <summary>
        /// Returns true if ASHRAETau instances are equal
        /// </summary>
        /// <param name="input">Instance of ASHRAETau to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ASHRAETau input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.TauB == input.TauB ||
                    (this.TauB != null &&
                    this.TauB.Equals(input.TauB))
                ) && base.Equals(input) && 
                (
                    this.TauD == input.TauD ||
                    (this.TauD != null &&
                    this.TauD.Equals(input.TauD))
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
                if (this.TauB != null)
                    hashCode = hashCode * 59 + this.TauB.GetHashCode();
                if (this.TauD != null)
                    hashCode = hashCode * 59 + this.TauD.GetHashCode();
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

            
            // TauB (double) maximum
            if(this.TauB > (double)1.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TauB, must be a value less than or equal to 1.2.", new [] { "TauB" });
            }

            // TauB (double) minimum
            if(this.TauB < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TauB, must be a value greater than or equal to 0.", new [] { "TauB" });
            }


            
            // TauD (double) maximum
            if(this.TauD > (double)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TauD, must be a value less than or equal to 3.", new [] { "TauD" });
            }

            // TauD (double) minimum
            if(this.TauD < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TauD, must be a value greater than or equal to 0.", new [] { "TauD" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ASHRAETau$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
