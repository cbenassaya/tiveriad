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
    /// UserConsentRepresentation
    /// </summary>
    [DataContract]
        public partial class UserConsentRepresentation :  IEquatable<UserConsentRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConsentRepresentation" /> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="grantedClientScopes">grantedClientScopes.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        public UserConsentRepresentation(string clientId = default(string), long? createdDate = default(long?), List<string> grantedClientScopes = default(List<string>), long? lastUpdatedDate = default(long?))
        {
            this.ClientId = clientId;
            this.CreatedDate = createdDate;
            this.GrantedClientScopes = grantedClientScopes;
            this.LastUpdatedDate = lastUpdatedDate;
        }
        
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets GrantedClientScopes
        /// </summary>
        [DataMember(Name="grantedClientScopes", EmitDefaultValue=false)]
        public List<string> GrantedClientScopes { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public long? LastUpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConsentRepresentation {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  GrantedClientScopes: ").Append(GrantedClientScopes).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
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
            return this.Equals(input as UserConsentRepresentation);
        }

        /// <summary>
        /// Returns true if UserConsentRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of UserConsentRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConsentRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.GrantedClientScopes == input.GrantedClientScopes ||
                    this.GrantedClientScopes != null &&
                    input.GrantedClientScopes != null &&
                    this.GrantedClientScopes.SequenceEqual(input.GrantedClientScopes)
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.GrantedClientScopes != null)
                    hashCode = hashCode * 59 + this.GrantedClientScopes.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
