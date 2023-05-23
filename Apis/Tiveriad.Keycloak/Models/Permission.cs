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
    /// Permission
    /// </summary>
    [DataContract]
        public partial class Permission :  IEquatable<Permission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="claims">claims.</param>
        /// <param name="rsid">rsid.</param>
        /// <param name="rsname">rsname.</param>
        /// <param name="scopes">scopes.</param>
        public Permission(Dictionary<string, Object> claims = default(Dictionary<string, Object>), string rsid = default(string), string rsname = default(string), List<string> scopes = default(List<string>))
        {
            this.Claims = claims;
            this.Rsid = rsid;
            this.Rsname = rsname;
            this.Scopes = scopes;
        }
        
        /// <summary>
        /// Gets or Sets Claims
        /// </summary>
        [DataMember(Name="claims", EmitDefaultValue=false)]
        public Dictionary<string, Object> Claims { get; set; }

        /// <summary>
        /// Gets or Sets Rsid
        /// </summary>
        [DataMember(Name="rsid", EmitDefaultValue=false)]
        public string Rsid { get; set; }

        /// <summary>
        /// Gets or Sets Rsname
        /// </summary>
        [DataMember(Name="rsname", EmitDefaultValue=false)]
        public string Rsname { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Claims: ").Append(Claims).Append("\n");
            sb.Append("  Rsid: ").Append(Rsid).Append("\n");
            sb.Append("  Rsname: ").Append(Rsname).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as Permission);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="input">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Claims == input.Claims ||
                    this.Claims != null &&
                    input.Claims != null &&
                    this.Claims.SequenceEqual(input.Claims)
                ) && 
                (
                    this.Rsid == input.Rsid ||
                    (this.Rsid != null &&
                    this.Rsid.Equals(input.Rsid))
                ) && 
                (
                    this.Rsname == input.Rsname ||
                    (this.Rsname != null &&
                    this.Rsname.Equals(input.Rsname))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
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
                if (this.Claims != null)
                    hashCode = hashCode * 59 + this.Claims.GetHashCode();
                if (this.Rsid != null)
                    hashCode = hashCode * 59 + this.Rsid.GetHashCode();
                if (this.Rsname != null)
                    hashCode = hashCode * 59 + this.Rsname.GetHashCode();
                if (this.Scopes != null)
                    hashCode = hashCode * 59 + this.Scopes.GetHashCode();
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
