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
    /// ServerInfoRepresentation
    /// </summary>
    [DataContract]
        public partial class ServerInfoRepresentation :  IEquatable<ServerInfoRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoRepresentation" /> class.
        /// </summary>
        /// <param name="builtinProtocolMappers">builtinProtocolMappers.</param>
        /// <param name="clientImporters">clientImporters.</param>
        /// <param name="clientInstallations">clientInstallations.</param>
        /// <param name="componentTypes">componentTypes.</param>
        /// <param name="enums">enums.</param>
        /// <param name="identityProviders">identityProviders.</param>
        /// <param name="memoryInfo">memoryInfo.</param>
        /// <param name="passwordPolicies">passwordPolicies.</param>
        /// <param name="profileInfo">profileInfo.</param>
        /// <param name="protocolMapperTypes">protocolMapperTypes.</param>
        /// <param name="providers">providers.</param>
        /// <param name="socialProviders">socialProviders.</param>
        /// <param name="systemInfo">systemInfo.</param>
        /// <param name="themes">themes.</param>
        public ServerInfoRepresentation(Dictionary<string, Object> builtinProtocolMappers = default(Dictionary<string, Object>), List<Dictionary<string, Object>> clientImporters = default(List<Dictionary<string, Object>>), Dictionary<string, Object> clientInstallations = default(Dictionary<string, Object>), Dictionary<string, Object> componentTypes = default(Dictionary<string, Object>), Dictionary<string, Object> enums = default(Dictionary<string, Object>), List<Dictionary<string, Object>> identityProviders = default(List<Dictionary<string, Object>>), MemoryInfoRepresentation memoryInfo = default(MemoryInfoRepresentation), List<PasswordPolicyTypeRepresentation> passwordPolicies = default(List<PasswordPolicyTypeRepresentation>), ProfileInfoRepresentation profileInfo = default(ProfileInfoRepresentation), Dictionary<string, Object> protocolMapperTypes = default(Dictionary<string, Object>), Dictionary<string, Object> providers = default(Dictionary<string, Object>), List<Dictionary<string, Object>> socialProviders = default(List<Dictionary<string, Object>>), SystemInfoRepresentation systemInfo = default(SystemInfoRepresentation), Dictionary<string, Object> themes = default(Dictionary<string, Object>))
        {
            this.BuiltinProtocolMappers = builtinProtocolMappers;
            this.ClientImporters = clientImporters;
            this.ClientInstallations = clientInstallations;
            this.ComponentTypes = componentTypes;
            this.Enums = enums;
            this.IdentityProviders = identityProviders;
            this.MemoryInfo = memoryInfo;
            this.PasswordPolicies = passwordPolicies;
            this.ProfileInfo = profileInfo;
            this.ProtocolMapperTypes = protocolMapperTypes;
            this.Providers = providers;
            this.SocialProviders = socialProviders;
            this.SystemInfo = systemInfo;
            this.Themes = themes;
        }
        
        /// <summary>
        /// Gets or Sets BuiltinProtocolMappers
        /// </summary>
        [DataMember(Name="builtinProtocolMappers", EmitDefaultValue=false)]
        public Dictionary<string, Object> BuiltinProtocolMappers { get; set; }

        /// <summary>
        /// Gets or Sets ClientImporters
        /// </summary>
        [DataMember(Name="clientImporters", EmitDefaultValue=false)]
        public List<Dictionary<string, Object>> ClientImporters { get; set; }

        /// <summary>
        /// Gets or Sets ClientInstallations
        /// </summary>
        [DataMember(Name="clientInstallations", EmitDefaultValue=false)]
        public Dictionary<string, Object> ClientInstallations { get; set; }

        /// <summary>
        /// Gets or Sets ComponentTypes
        /// </summary>
        [DataMember(Name="componentTypes", EmitDefaultValue=false)]
        public Dictionary<string, Object> ComponentTypes { get; set; }

        /// <summary>
        /// Gets or Sets Enums
        /// </summary>
        [DataMember(Name="enums", EmitDefaultValue=false)]
        public Dictionary<string, Object> Enums { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviders
        /// </summary>
        [DataMember(Name="identityProviders", EmitDefaultValue=false)]
        public List<Dictionary<string, Object>> IdentityProviders { get; set; }

        /// <summary>
        /// Gets or Sets MemoryInfo
        /// </summary>
        [DataMember(Name="memoryInfo", EmitDefaultValue=false)]
        public MemoryInfoRepresentation MemoryInfo { get; set; }

        /// <summary>
        /// Gets or Sets PasswordPolicies
        /// </summary>
        [DataMember(Name="passwordPolicies", EmitDefaultValue=false)]
        public List<PasswordPolicyTypeRepresentation> PasswordPolicies { get; set; }

        /// <summary>
        /// Gets or Sets ProfileInfo
        /// </summary>
        [DataMember(Name="profileInfo", EmitDefaultValue=false)]
        public ProfileInfoRepresentation ProfileInfo { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolMapperTypes
        /// </summary>
        [DataMember(Name="protocolMapperTypes", EmitDefaultValue=false)]
        public Dictionary<string, Object> ProtocolMapperTypes { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public Dictionary<string, Object> Providers { get; set; }

        /// <summary>
        /// Gets or Sets SocialProviders
        /// </summary>
        [DataMember(Name="socialProviders", EmitDefaultValue=false)]
        public List<Dictionary<string, Object>> SocialProviders { get; set; }

        /// <summary>
        /// Gets or Sets SystemInfo
        /// </summary>
        [DataMember(Name="systemInfo", EmitDefaultValue=false)]
        public SystemInfoRepresentation SystemInfo { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public Dictionary<string, Object> Themes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerInfoRepresentation {\n");
            sb.Append("  BuiltinProtocolMappers: ").Append(BuiltinProtocolMappers).Append("\n");
            sb.Append("  ClientImporters: ").Append(ClientImporters).Append("\n");
            sb.Append("  ClientInstallations: ").Append(ClientInstallations).Append("\n");
            sb.Append("  ComponentTypes: ").Append(ComponentTypes).Append("\n");
            sb.Append("  Enums: ").Append(Enums).Append("\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
            sb.Append("  MemoryInfo: ").Append(MemoryInfo).Append("\n");
            sb.Append("  PasswordPolicies: ").Append(PasswordPolicies).Append("\n");
            sb.Append("  ProfileInfo: ").Append(ProfileInfo).Append("\n");
            sb.Append("  ProtocolMapperTypes: ").Append(ProtocolMapperTypes).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  SocialProviders: ").Append(SocialProviders).Append("\n");
            sb.Append("  SystemInfo: ").Append(SystemInfo).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
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
            return this.Equals(input as ServerInfoRepresentation);
        }

        /// <summary>
        /// Returns true if ServerInfoRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerInfoRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerInfoRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuiltinProtocolMappers == input.BuiltinProtocolMappers ||
                    this.BuiltinProtocolMappers != null &&
                    input.BuiltinProtocolMappers != null &&
                    this.BuiltinProtocolMappers.SequenceEqual(input.BuiltinProtocolMappers)
                ) && 
                (
                    this.ClientImporters == input.ClientImporters ||
                    this.ClientImporters != null &&
                    input.ClientImporters != null &&
                    this.ClientImporters.SequenceEqual(input.ClientImporters)
                ) && 
                (
                    this.ClientInstallations == input.ClientInstallations ||
                    this.ClientInstallations != null &&
                    input.ClientInstallations != null &&
                    this.ClientInstallations.SequenceEqual(input.ClientInstallations)
                ) && 
                (
                    this.ComponentTypes == input.ComponentTypes ||
                    this.ComponentTypes != null &&
                    input.ComponentTypes != null &&
                    this.ComponentTypes.SequenceEqual(input.ComponentTypes)
                ) && 
                (
                    this.Enums == input.Enums ||
                    this.Enums != null &&
                    input.Enums != null &&
                    this.Enums.SequenceEqual(input.Enums)
                ) && 
                (
                    this.IdentityProviders == input.IdentityProviders ||
                    this.IdentityProviders != null &&
                    input.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(input.IdentityProviders)
                ) && 
                (
                    this.MemoryInfo == input.MemoryInfo ||
                    (this.MemoryInfo != null &&
                    this.MemoryInfo.Equals(input.MemoryInfo))
                ) && 
                (
                    this.PasswordPolicies == input.PasswordPolicies ||
                    this.PasswordPolicies != null &&
                    input.PasswordPolicies != null &&
                    this.PasswordPolicies.SequenceEqual(input.PasswordPolicies)
                ) && 
                (
                    this.ProfileInfo == input.ProfileInfo ||
                    (this.ProfileInfo != null &&
                    this.ProfileInfo.Equals(input.ProfileInfo))
                ) && 
                (
                    this.ProtocolMapperTypes == input.ProtocolMapperTypes ||
                    this.ProtocolMapperTypes != null &&
                    input.ProtocolMapperTypes != null &&
                    this.ProtocolMapperTypes.SequenceEqual(input.ProtocolMapperTypes)
                ) && 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
                ) && 
                (
                    this.SocialProviders == input.SocialProviders ||
                    this.SocialProviders != null &&
                    input.SocialProviders != null &&
                    this.SocialProviders.SequenceEqual(input.SocialProviders)
                ) && 
                (
                    this.SystemInfo == input.SystemInfo ||
                    (this.SystemInfo != null &&
                    this.SystemInfo.Equals(input.SystemInfo))
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
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
                if (this.BuiltinProtocolMappers != null)
                    hashCode = hashCode * 59 + this.BuiltinProtocolMappers.GetHashCode();
                if (this.ClientImporters != null)
                    hashCode = hashCode * 59 + this.ClientImporters.GetHashCode();
                if (this.ClientInstallations != null)
                    hashCode = hashCode * 59 + this.ClientInstallations.GetHashCode();
                if (this.ComponentTypes != null)
                    hashCode = hashCode * 59 + this.ComponentTypes.GetHashCode();
                if (this.Enums != null)
                    hashCode = hashCode * 59 + this.Enums.GetHashCode();
                if (this.IdentityProviders != null)
                    hashCode = hashCode * 59 + this.IdentityProviders.GetHashCode();
                if (this.MemoryInfo != null)
                    hashCode = hashCode * 59 + this.MemoryInfo.GetHashCode();
                if (this.PasswordPolicies != null)
                    hashCode = hashCode * 59 + this.PasswordPolicies.GetHashCode();
                if (this.ProfileInfo != null)
                    hashCode = hashCode * 59 + this.ProfileInfo.GetHashCode();
                if (this.ProtocolMapperTypes != null)
                    hashCode = hashCode * 59 + this.ProtocolMapperTypes.GetHashCode();
                if (this.Providers != null)
                    hashCode = hashCode * 59 + this.Providers.GetHashCode();
                if (this.SocialProviders != null)
                    hashCode = hashCode * 59 + this.SocialProviders.GetHashCode();
                if (this.SystemInfo != null)
                    hashCode = hashCode * 59 + this.SystemInfo.GetHashCode();
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
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
