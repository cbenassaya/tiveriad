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
    /// SynchronizationResult
    /// </summary>
    [DataContract]
        public partial class SynchronizationResult :  IEquatable<SynchronizationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizationResult" /> class.
        /// </summary>
        /// <param name="added">added.</param>
        /// <param name="failed">failed.</param>
        /// <param name="ignored">ignored.</param>
        /// <param name="removed">removed.</param>
        /// <param name="status">status.</param>
        /// <param name="updated">updated.</param>
        public SynchronizationResult(int? added = default(int?), int? failed = default(int?), bool? ignored = default(bool?), int? removed = default(int?), string status = default(string), int? updated = default(int?))
        {
            this.Added = added;
            this.Failed = failed;
            this.Ignored = ignored;
            this.Removed = removed;
            this.Status = status;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public int? Added { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or Sets Ignored
        /// </summary>
        [DataMember(Name="ignored", EmitDefaultValue=false)]
        public bool? Ignored { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [DataMember(Name="removed", EmitDefaultValue=false)]
        public int? Removed { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public int? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SynchronizationResult {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as SynchronizationResult);
        }

        /// <summary>
        /// Returns true if SynchronizationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SynchronizationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SynchronizationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Ignored == input.Ignored ||
                    (this.Ignored != null &&
                    this.Ignored.Equals(input.Ignored))
                ) && 
                (
                    this.Removed == input.Removed ||
                    (this.Removed != null &&
                    this.Removed.Equals(input.Removed))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Ignored != null)
                    hashCode = hashCode * 59 + this.Ignored.GetHashCode();
                if (this.Removed != null)
                    hashCode = hashCode * 59 + this.Removed.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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
