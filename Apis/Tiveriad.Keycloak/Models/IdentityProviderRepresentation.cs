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
    /// IdentityProviderRepresentation
    /// </summary>
    [DataContract]
        public partial class IdentityProviderRepresentation :  IEquatable<IdentityProviderRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderRepresentation" /> class.
        /// </summary>
        /// <param name="addReadTokenRoleOnCreate">addReadTokenRoleOnCreate.</param>
        /// <param name="alias">alias.</param>
        /// <param name="config">config.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="firstBrokerLoginFlowAlias">firstBrokerLoginFlowAlias.</param>
        /// <param name="internalId">internalId.</param>
        /// <param name="linkOnly">linkOnly.</param>
        /// <param name="postBrokerLoginFlowAlias">postBrokerLoginFlowAlias.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="storeToken">storeToken.</param>
        /// <param name="trustEmail">trustEmail.</param>
        public IdentityProviderRepresentation(bool? addReadTokenRoleOnCreate = default(bool?), string alias = default(string), Dictionary<string, Object> config = default(Dictionary<string, Object>), string displayName = default(string), bool? enabled = default(bool?), string firstBrokerLoginFlowAlias = default(string), string internalId = default(string), bool? linkOnly = default(bool?), string postBrokerLoginFlowAlias = default(string), string providerId = default(string), bool? storeToken = default(bool?), bool? trustEmail = default(bool?))
        {
            this.AddReadTokenRoleOnCreate = addReadTokenRoleOnCreate;
            this.Alias = alias;
            this.Config = config;
            this.DisplayName = displayName;
            this.Enabled = enabled;
            this.FirstBrokerLoginFlowAlias = firstBrokerLoginFlowAlias;
            this.InternalId = internalId;
            this.LinkOnly = linkOnly;
            this.PostBrokerLoginFlowAlias = postBrokerLoginFlowAlias;
            this.ProviderId = providerId;
            this.StoreToken = storeToken;
            this.TrustEmail = trustEmail;
        }
        
        /// <summary>
        /// Gets or Sets AddReadTokenRoleOnCreate
        /// </summary>
        [DataMember(Name="addReadTokenRoleOnCreate", EmitDefaultValue=false)]
        public bool? AddReadTokenRoleOnCreate { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public Dictionary<string, Object> Config { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets FirstBrokerLoginFlowAlias
        /// </summary>
        [DataMember(Name="firstBrokerLoginFlowAlias", EmitDefaultValue=false)]
        public string FirstBrokerLoginFlowAlias { get; set; }

        /// <summary>
        /// Gets or Sets InternalId
        /// </summary>
        [DataMember(Name="internalId", EmitDefaultValue=false)]
        public string InternalId { get; set; }

        /// <summary>
        /// Gets or Sets LinkOnly
        /// </summary>
        [DataMember(Name="linkOnly", EmitDefaultValue=false)]
        public bool? LinkOnly { get; set; }

        /// <summary>
        /// Gets or Sets PostBrokerLoginFlowAlias
        /// </summary>
        [DataMember(Name="postBrokerLoginFlowAlias", EmitDefaultValue=false)]
        public string PostBrokerLoginFlowAlias { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name="providerId", EmitDefaultValue=false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets StoreToken
        /// </summary>
        [DataMember(Name="storeToken", EmitDefaultValue=false)]
        public bool? StoreToken { get; set; }

        /// <summary>
        /// Gets or Sets TrustEmail
        /// </summary>
        [DataMember(Name="trustEmail", EmitDefaultValue=false)]
        public bool? TrustEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProviderRepresentation {\n");
            sb.Append("  AddReadTokenRoleOnCreate: ").Append(AddReadTokenRoleOnCreate).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FirstBrokerLoginFlowAlias: ").Append(FirstBrokerLoginFlowAlias).Append("\n");
            sb.Append("  InternalId: ").Append(InternalId).Append("\n");
            sb.Append("  LinkOnly: ").Append(LinkOnly).Append("\n");
            sb.Append("  PostBrokerLoginFlowAlias: ").Append(PostBrokerLoginFlowAlias).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  StoreToken: ").Append(StoreToken).Append("\n");
            sb.Append("  TrustEmail: ").Append(TrustEmail).Append("\n");
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
            return this.Equals(input as IdentityProviderRepresentation);
        }

        /// <summary>
        /// Returns true if IdentityProviderRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityProviderRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddReadTokenRoleOnCreate == input.AddReadTokenRoleOnCreate ||
                    (this.AddReadTokenRoleOnCreate != null &&
                    this.AddReadTokenRoleOnCreate.Equals(input.AddReadTokenRoleOnCreate))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FirstBrokerLoginFlowAlias == input.FirstBrokerLoginFlowAlias ||
                    (this.FirstBrokerLoginFlowAlias != null &&
                    this.FirstBrokerLoginFlowAlias.Equals(input.FirstBrokerLoginFlowAlias))
                ) && 
                (
                    this.InternalId == input.InternalId ||
                    (this.InternalId != null &&
                    this.InternalId.Equals(input.InternalId))
                ) && 
                (
                    this.LinkOnly == input.LinkOnly ||
                    (this.LinkOnly != null &&
                    this.LinkOnly.Equals(input.LinkOnly))
                ) && 
                (
                    this.PostBrokerLoginFlowAlias == input.PostBrokerLoginFlowAlias ||
                    (this.PostBrokerLoginFlowAlias != null &&
                    this.PostBrokerLoginFlowAlias.Equals(input.PostBrokerLoginFlowAlias))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.StoreToken == input.StoreToken ||
                    (this.StoreToken != null &&
                    this.StoreToken.Equals(input.StoreToken))
                ) && 
                (
                    this.TrustEmail == input.TrustEmail ||
                    (this.TrustEmail != null &&
                    this.TrustEmail.Equals(input.TrustEmail))
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
                if (this.AddReadTokenRoleOnCreate != null)
                    hashCode = hashCode * 59 + this.AddReadTokenRoleOnCreate.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FirstBrokerLoginFlowAlias != null)
                    hashCode = hashCode * 59 + this.FirstBrokerLoginFlowAlias.GetHashCode();
                if (this.InternalId != null)
                    hashCode = hashCode * 59 + this.InternalId.GetHashCode();
                if (this.LinkOnly != null)
                    hashCode = hashCode * 59 + this.LinkOnly.GetHashCode();
                if (this.PostBrokerLoginFlowAlias != null)
                    hashCode = hashCode * 59 + this.PostBrokerLoginFlowAlias.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.StoreToken != null)
                    hashCode = hashCode * 59 + this.StoreToken.GetHashCode();
                if (this.TrustEmail != null)
                    hashCode = hashCode * 59 + this.TrustEmail.GetHashCode();
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
