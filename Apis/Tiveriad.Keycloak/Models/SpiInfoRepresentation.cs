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
    /// SpiInfoRepresentation
    /// </summary>
    [DataContract]
        public partial class SpiInfoRepresentation :  IEquatable<SpiInfoRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpiInfoRepresentation" /> class.
        /// </summary>
        /// <param name="_internal">_internal.</param>
        /// <param name="providers">providers.</param>
        public SpiInfoRepresentation(bool? _internal = default(bool?), Dictionary<string, Object> providers = default(Dictionary<string, Object>))
        {
            this._Internal = _internal;
            this.Providers = providers;
        }
        
        /// <summary>
        /// Gets or Sets _Internal
        /// </summary>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public bool? _Internal { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public Dictionary<string, Object> Providers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpiInfoRepresentation {\n");
            sb.Append("  _Internal: ").Append(_Internal).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return this.Equals(input as SpiInfoRepresentation);
        }

        /// <summary>
        /// Returns true if SpiInfoRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of SpiInfoRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpiInfoRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Internal == input._Internal ||
                    (this._Internal != null &&
                    this._Internal.Equals(input._Internal))
                ) && 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
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
                if (this._Internal != null)
                    hashCode = hashCode * 59 + this._Internal.GetHashCode();
                if (this.Providers != null)
                    hashCode = hashCode * 59 + this.Providers.GetHashCode();
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
