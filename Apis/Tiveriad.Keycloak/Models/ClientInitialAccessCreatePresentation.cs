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
    /// ClientInitialAccessCreatePresentation
    /// </summary>
    [DataContract]
        public partial class ClientInitialAccessCreatePresentation :  IEquatable<ClientInitialAccessCreatePresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessCreatePresentation" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="expiration">expiration.</param>
        public ClientInitialAccessCreatePresentation(int? count = default(int?), int? expiration = default(int?))
        {
            this.Count = count;
            this.Expiration = expiration;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public int? Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientInitialAccessCreatePresentation {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as ClientInitialAccessCreatePresentation);
        }

        /// <summary>
        /// Returns true if ClientInitialAccessCreatePresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientInitialAccessCreatePresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientInitialAccessCreatePresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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
