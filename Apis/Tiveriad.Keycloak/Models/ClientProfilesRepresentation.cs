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
    /// ClientProfilesRepresentation
    /// </summary>
    [DataContract]
        public partial class ClientProfilesRepresentation :  IEquatable<ClientProfilesRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfilesRepresentation" /> class.
        /// </summary>
        /// <param name="globalProfiles">globalProfiles.</param>
        /// <param name="profiles">profiles.</param>
        public ClientProfilesRepresentation(List<ClientProfileRepresentation> globalProfiles = default(List<ClientProfileRepresentation>), List<ClientProfileRepresentation> profiles = default(List<ClientProfileRepresentation>))
        {
            this.GlobalProfiles = globalProfiles;
            this.Profiles = profiles;
        }
        
        /// <summary>
        /// Gets or Sets GlobalProfiles
        /// </summary>
        [DataMember(Name="globalProfiles", EmitDefaultValue=false)]
        public List<ClientProfileRepresentation> GlobalProfiles { get; set; }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<ClientProfileRepresentation> Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientProfilesRepresentation {\n");
            sb.Append("  GlobalProfiles: ").Append(GlobalProfiles).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
            return this.Equals(input as ClientProfilesRepresentation);
        }

        /// <summary>
        /// Returns true if ClientProfilesRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProfilesRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProfilesRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlobalProfiles == input.GlobalProfiles ||
                    this.GlobalProfiles != null &&
                    input.GlobalProfiles != null &&
                    this.GlobalProfiles.SequenceEqual(input.GlobalProfiles)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
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
                if (this.GlobalProfiles != null)
                    hashCode = hashCode * 59 + this.GlobalProfiles.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
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
