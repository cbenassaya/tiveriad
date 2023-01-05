/* 
 * Keycloak Admin REST API
 *
 * This is a REST API reference for the Keycloak Admin
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Tiveriad.Keycloak.Models
{
    /// <summary>
    /// ProfileInfoRepresentation
    /// </summary>
    [DataContract]
        public partial class ProfileInfoRepresentation :  IEquatable<ProfileInfoRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileInfoRepresentation" /> class.
        /// </summary>
        /// <param name="disabledFeatures">disabledFeatures.</param>
        /// <param name="experimentalFeatures">experimentalFeatures.</param>
        /// <param name="name">name.</param>
        /// <param name="previewFeatures">previewFeatures.</param>
        public ProfileInfoRepresentation(List<string> disabledFeatures = default(List<string>), List<string> experimentalFeatures = default(List<string>), string name = default(string), List<string> previewFeatures = default(List<string>))
        {
            this.DisabledFeatures = disabledFeatures;
            this.ExperimentalFeatures = experimentalFeatures;
            this.Name = name;
            this.PreviewFeatures = previewFeatures;
        }
        
        /// <summary>
        /// Gets or Sets DisabledFeatures
        /// </summary>
        [DataMember(Name="disabledFeatures", EmitDefaultValue=false)]
        public List<string> DisabledFeatures { get; set; }

        /// <summary>
        /// Gets or Sets ExperimentalFeatures
        /// </summary>
        [DataMember(Name="experimentalFeatures", EmitDefaultValue=false)]
        public List<string> ExperimentalFeatures { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PreviewFeatures
        /// </summary>
        [DataMember(Name="previewFeatures", EmitDefaultValue=false)]
        public List<string> PreviewFeatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileInfoRepresentation {\n");
            sb.Append("  DisabledFeatures: ").Append(DisabledFeatures).Append("\n");
            sb.Append("  ExperimentalFeatures: ").Append(ExperimentalFeatures).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PreviewFeatures: ").Append(PreviewFeatures).Append("\n");
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
            return this.Equals(input as ProfileInfoRepresentation);
        }

        /// <summary>
        /// Returns true if ProfileInfoRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileInfoRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileInfoRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisabledFeatures == input.DisabledFeatures ||
                    this.DisabledFeatures != null &&
                    input.DisabledFeatures != null &&
                    this.DisabledFeatures.SequenceEqual(input.DisabledFeatures)
                ) && 
                (
                    this.ExperimentalFeatures == input.ExperimentalFeatures ||
                    this.ExperimentalFeatures != null &&
                    input.ExperimentalFeatures != null &&
                    this.ExperimentalFeatures.SequenceEqual(input.ExperimentalFeatures)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PreviewFeatures == input.PreviewFeatures ||
                    this.PreviewFeatures != null &&
                    input.PreviewFeatures != null &&
                    this.PreviewFeatures.SequenceEqual(input.PreviewFeatures)
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
                if (this.DisabledFeatures != null)
                    hashCode = hashCode * 59 + this.DisabledFeatures.GetHashCode();
                if (this.ExperimentalFeatures != null)
                    hashCode = hashCode * 59 + this.ExperimentalFeatures.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PreviewFeatures != null)
                    hashCode = hashCode * 59 + this.PreviewFeatures.GetHashCode();
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
            yield break;
        }
    }
}
