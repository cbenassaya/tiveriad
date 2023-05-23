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
    /// ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation
    /// </summary>
    [DataContract]
        public partial class ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation :  IEquatable<ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation" /> class.
        /// </summary>
        /// <param name="containerId">containerId.</param>
        /// <param name="containerName">containerName.</param>
        /// <param name="containerType">containerType.</param>
        /// <param name="mapperId">mapperId.</param>
        /// <param name="mapperName">mapperName.</param>
        /// <param name="protocolMapper">protocolMapper.</param>
        public ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation(string containerId = default(string), string containerName = default(string), string containerType = default(string), string mapperId = default(string), string mapperName = default(string), string protocolMapper = default(string))
        {
            this.ContainerId = containerId;
            this.ContainerName = containerName;
            this.ContainerType = containerType;
            this.MapperId = mapperId;
            this.MapperName = mapperName;
            this.ProtocolMapper = protocolMapper;
        }
        
        /// <summary>
        /// Gets or Sets ContainerId
        /// </summary>
        [DataMember(Name="containerId", EmitDefaultValue=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or Sets ContainerName
        /// </summary>
        [DataMember(Name="containerName", EmitDefaultValue=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or Sets ContainerType
        /// </summary>
        [DataMember(Name="containerType", EmitDefaultValue=false)]
        public string ContainerType { get; set; }

        /// <summary>
        /// Gets or Sets MapperId
        /// </summary>
        [DataMember(Name="mapperId", EmitDefaultValue=false)]
        public string MapperId { get; set; }

        /// <summary>
        /// Gets or Sets MapperName
        /// </summary>
        [DataMember(Name="mapperName", EmitDefaultValue=false)]
        public string MapperName { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolMapper
        /// </summary>
        [DataMember(Name="protocolMapper", EmitDefaultValue=false)]
        public string ProtocolMapper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation {\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
            sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
            sb.Append("  MapperId: ").Append(MapperId).Append("\n");
            sb.Append("  MapperName: ").Append(MapperName).Append("\n");
            sb.Append("  ProtocolMapper: ").Append(ProtocolMapper).Append("\n");
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
            return this.Equals(input as ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation);
        }

        /// <summary>
        /// Returns true if ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
                ) && 
                (
                    this.ContainerName == input.ContainerName ||
                    (this.ContainerName != null &&
                    this.ContainerName.Equals(input.ContainerName))
                ) && 
                (
                    this.ContainerType == input.ContainerType ||
                    (this.ContainerType != null &&
                    this.ContainerType.Equals(input.ContainerType))
                ) && 
                (
                    this.MapperId == input.MapperId ||
                    (this.MapperId != null &&
                    this.MapperId.Equals(input.MapperId))
                ) && 
                (
                    this.MapperName == input.MapperName ||
                    (this.MapperName != null &&
                    this.MapperName.Equals(input.MapperName))
                ) && 
                (
                    this.ProtocolMapper == input.ProtocolMapper ||
                    (this.ProtocolMapper != null &&
                    this.ProtocolMapper.Equals(input.ProtocolMapper))
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
                if (this.ContainerId != null)
                    hashCode = hashCode * 59 + this.ContainerId.GetHashCode();
                if (this.ContainerName != null)
                    hashCode = hashCode * 59 + this.ContainerName.GetHashCode();
                if (this.ContainerType != null)
                    hashCode = hashCode * 59 + this.ContainerType.GetHashCode();
                if (this.MapperId != null)
                    hashCode = hashCode * 59 + this.MapperId.GetHashCode();
                if (this.MapperName != null)
                    hashCode = hashCode * 59 + this.MapperName.GetHashCode();
                if (this.ProtocolMapper != null)
                    hashCode = hashCode * 59 + this.ProtocolMapper.GetHashCode();
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
