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
    /// PasswordPolicyTypeRepresentation
    /// </summary>
    [DataContract]
        public partial class PasswordPolicyTypeRepresentation :  IEquatable<PasswordPolicyTypeRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyTypeRepresentation" /> class.
        /// </summary>
        /// <param name="configType">configType.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="id">id.</param>
        /// <param name="multipleSupported">multipleSupported.</param>
        public PasswordPolicyTypeRepresentation(string configType = default(string), string defaultValue = default(string), string displayName = default(string), string id = default(string), bool? multipleSupported = default(bool?))
        {
            this.ConfigType = configType;
            this.DefaultValue = defaultValue;
            this.DisplayName = displayName;
            this.Id = id;
            this.MultipleSupported = multipleSupported;
        }
        
        /// <summary>
        /// Gets or Sets ConfigType
        /// </summary>
        [DataMember(Name="configType", EmitDefaultValue=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MultipleSupported
        /// </summary>
        [DataMember(Name="multipleSupported", EmitDefaultValue=false)]
        public bool? MultipleSupported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyTypeRepresentation {\n");
            sb.Append("  ConfigType: ").Append(ConfigType).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MultipleSupported: ").Append(MultipleSupported).Append("\n");
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
            return this.Equals(input as PasswordPolicyTypeRepresentation);
        }

        /// <summary>
        /// Returns true if PasswordPolicyTypeRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyTypeRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyTypeRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigType == input.ConfigType ||
                    (this.ConfigType != null &&
                    this.ConfigType.Equals(input.ConfigType))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MultipleSupported == input.MultipleSupported ||
                    (this.MultipleSupported != null &&
                    this.MultipleSupported.Equals(input.MultipleSupported))
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
                if (this.ConfigType != null)
                    hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MultipleSupported != null)
                    hashCode = hashCode * 59 + this.MultipleSupported.GetHashCode();
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
