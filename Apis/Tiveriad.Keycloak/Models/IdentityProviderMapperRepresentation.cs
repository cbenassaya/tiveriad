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
    /// IdentityProviderMapperRepresentation
    /// </summary>
    [DataContract]
        public partial class IdentityProviderMapperRepresentation :  IEquatable<IdentityProviderMapperRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderMapperRepresentation" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="id">id.</param>
        /// <param name="identityProviderAlias">identityProviderAlias.</param>
        /// <param name="identityProviderMapper">identityProviderMapper.</param>
        /// <param name="name">name.</param>
        public IdentityProviderMapperRepresentation(Dictionary<string, Object> config = default(Dictionary<string, Object>), string id = default(string), string identityProviderAlias = default(string), string identityProviderMapper = default(string), string name = default(string))
        {
            this.Config = config;
            this.Id = id;
            this.IdentityProviderAlias = identityProviderAlias;
            this.IdentityProviderMapper = identityProviderMapper;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public Dictionary<string, Object> Config { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviderAlias
        /// </summary>
        [DataMember(Name="identityProviderAlias", EmitDefaultValue=false)]
        public string IdentityProviderAlias { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviderMapper
        /// </summary>
        [DataMember(Name="identityProviderMapper", EmitDefaultValue=false)]
        public string IdentityProviderMapper { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProviderMapperRepresentation {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentityProviderAlias: ").Append(IdentityProviderAlias).Append("\n");
            sb.Append("  IdentityProviderMapper: ").Append(IdentityProviderMapper).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as IdentityProviderMapperRepresentation);
        }

        /// <summary>
        /// Returns true if IdentityProviderMapperRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityProviderMapperRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderMapperRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdentityProviderAlias == input.IdentityProviderAlias ||
                    (this.IdentityProviderAlias != null &&
                    this.IdentityProviderAlias.Equals(input.IdentityProviderAlias))
                ) && 
                (
                    this.IdentityProviderMapper == input.IdentityProviderMapper ||
                    (this.IdentityProviderMapper != null &&
                    this.IdentityProviderMapper.Equals(input.IdentityProviderMapper))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdentityProviderAlias != null)
                    hashCode = hashCode * 59 + this.IdentityProviderAlias.GetHashCode();
                if (this.IdentityProviderMapper != null)
                    hashCode = hashCode * 59 + this.IdentityProviderMapper.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
