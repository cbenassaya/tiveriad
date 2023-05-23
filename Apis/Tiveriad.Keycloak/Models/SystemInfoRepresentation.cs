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
    /// SystemInfoRepresentation
    /// </summary>
    [DataContract]
        public partial class SystemInfoRepresentation :  IEquatable<SystemInfoRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoRepresentation" /> class.
        /// </summary>
        /// <param name="fileEncoding">fileEncoding.</param>
        /// <param name="javaHome">javaHome.</param>
        /// <param name="javaRuntime">javaRuntime.</param>
        /// <param name="javaVendor">javaVendor.</param>
        /// <param name="javaVersion">javaVersion.</param>
        /// <param name="javaVm">javaVm.</param>
        /// <param name="javaVmVersion">javaVmVersion.</param>
        /// <param name="osArchitecture">osArchitecture.</param>
        /// <param name="osName">osName.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="serverTime">serverTime.</param>
        /// <param name="uptime">uptime.</param>
        /// <param name="uptimeMillis">uptimeMillis.</param>
        /// <param name="userDir">userDir.</param>
        /// <param name="userLocale">userLocale.</param>
        /// <param name="userName">userName.</param>
        /// <param name="userTimezone">userTimezone.</param>
        /// <param name="version">version.</param>
        public SystemInfoRepresentation(string fileEncoding = default(string), string javaHome = default(string), string javaRuntime = default(string), string javaVendor = default(string), string javaVersion = default(string), string javaVm = default(string), string javaVmVersion = default(string), string osArchitecture = default(string), string osName = default(string), string osVersion = default(string), string serverTime = default(string), string uptime = default(string), long? uptimeMillis = default(long?), string userDir = default(string), string userLocale = default(string), string userName = default(string), string userTimezone = default(string), string version = default(string))
        {
            this.FileEncoding = fileEncoding;
            this.JavaHome = javaHome;
            this.JavaRuntime = javaRuntime;
            this.JavaVendor = javaVendor;
            this.JavaVersion = javaVersion;
            this.JavaVm = javaVm;
            this.JavaVmVersion = javaVmVersion;
            this.OsArchitecture = osArchitecture;
            this.OsName = osName;
            this.OsVersion = osVersion;
            this.ServerTime = serverTime;
            this.Uptime = uptime;
            this.UptimeMillis = uptimeMillis;
            this.UserDir = userDir;
            this.UserLocale = userLocale;
            this.UserName = userName;
            this.UserTimezone = userTimezone;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets FileEncoding
        /// </summary>
        [DataMember(Name="fileEncoding", EmitDefaultValue=false)]
        public string FileEncoding { get; set; }

        /// <summary>
        /// Gets or Sets JavaHome
        /// </summary>
        [DataMember(Name="javaHome", EmitDefaultValue=false)]
        public string JavaHome { get; set; }

        /// <summary>
        /// Gets or Sets JavaRuntime
        /// </summary>
        [DataMember(Name="javaRuntime", EmitDefaultValue=false)]
        public string JavaRuntime { get; set; }

        /// <summary>
        /// Gets or Sets JavaVendor
        /// </summary>
        [DataMember(Name="javaVendor", EmitDefaultValue=false)]
        public string JavaVendor { get; set; }

        /// <summary>
        /// Gets or Sets JavaVersion
        /// </summary>
        [DataMember(Name="javaVersion", EmitDefaultValue=false)]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Gets or Sets JavaVm
        /// </summary>
        [DataMember(Name="javaVm", EmitDefaultValue=false)]
        public string JavaVm { get; set; }

        /// <summary>
        /// Gets or Sets JavaVmVersion
        /// </summary>
        [DataMember(Name="javaVmVersion", EmitDefaultValue=false)]
        public string JavaVmVersion { get; set; }

        /// <summary>
        /// Gets or Sets OsArchitecture
        /// </summary>
        [DataMember(Name="osArchitecture", EmitDefaultValue=false)]
        public string OsArchitecture { get; set; }

        /// <summary>
        /// Gets or Sets OsName
        /// </summary>
        [DataMember(Name="osName", EmitDefaultValue=false)]
        public string OsName { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name="osVersion", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets ServerTime
        /// </summary>
        [DataMember(Name="serverTime", EmitDefaultValue=false)]
        public string ServerTime { get; set; }

        /// <summary>
        /// Gets or Sets Uptime
        /// </summary>
        [DataMember(Name="uptime", EmitDefaultValue=false)]
        public string Uptime { get; set; }

        /// <summary>
        /// Gets or Sets UptimeMillis
        /// </summary>
        [DataMember(Name="uptimeMillis", EmitDefaultValue=false)]
        public long? UptimeMillis { get; set; }

        /// <summary>
        /// Gets or Sets UserDir
        /// </summary>
        [DataMember(Name="userDir", EmitDefaultValue=false)]
        public string UserDir { get; set; }

        /// <summary>
        /// Gets or Sets UserLocale
        /// </summary>
        [DataMember(Name="userLocale", EmitDefaultValue=false)]
        public string UserLocale { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UserTimezone
        /// </summary>
        [DataMember(Name="userTimezone", EmitDefaultValue=false)]
        public string UserTimezone { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfoRepresentation {\n");
            sb.Append("  FileEncoding: ").Append(FileEncoding).Append("\n");
            sb.Append("  JavaHome: ").Append(JavaHome).Append("\n");
            sb.Append("  JavaRuntime: ").Append(JavaRuntime).Append("\n");
            sb.Append("  JavaVendor: ").Append(JavaVendor).Append("\n");
            sb.Append("  JavaVersion: ").Append(JavaVersion).Append("\n");
            sb.Append("  JavaVm: ").Append(JavaVm).Append("\n");
            sb.Append("  JavaVmVersion: ").Append(JavaVmVersion).Append("\n");
            sb.Append("  OsArchitecture: ").Append(OsArchitecture).Append("\n");
            sb.Append("  OsName: ").Append(OsName).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  ServerTime: ").Append(ServerTime).Append("\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  UptimeMillis: ").Append(UptimeMillis).Append("\n");
            sb.Append("  UserDir: ").Append(UserDir).Append("\n");
            sb.Append("  UserLocale: ").Append(UserLocale).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserTimezone: ").Append(UserTimezone).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as SystemInfoRepresentation);
        }

        /// <summary>
        /// Returns true if SystemInfoRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoRepresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileEncoding == input.FileEncoding ||
                    (this.FileEncoding != null &&
                    this.FileEncoding.Equals(input.FileEncoding))
                ) && 
                (
                    this.JavaHome == input.JavaHome ||
                    (this.JavaHome != null &&
                    this.JavaHome.Equals(input.JavaHome))
                ) && 
                (
                    this.JavaRuntime == input.JavaRuntime ||
                    (this.JavaRuntime != null &&
                    this.JavaRuntime.Equals(input.JavaRuntime))
                ) && 
                (
                    this.JavaVendor == input.JavaVendor ||
                    (this.JavaVendor != null &&
                    this.JavaVendor.Equals(input.JavaVendor))
                ) && 
                (
                    this.JavaVersion == input.JavaVersion ||
                    (this.JavaVersion != null &&
                    this.JavaVersion.Equals(input.JavaVersion))
                ) && 
                (
                    this.JavaVm == input.JavaVm ||
                    (this.JavaVm != null &&
                    this.JavaVm.Equals(input.JavaVm))
                ) && 
                (
                    this.JavaVmVersion == input.JavaVmVersion ||
                    (this.JavaVmVersion != null &&
                    this.JavaVmVersion.Equals(input.JavaVmVersion))
                ) && 
                (
                    this.OsArchitecture == input.OsArchitecture ||
                    (this.OsArchitecture != null &&
                    this.OsArchitecture.Equals(input.OsArchitecture))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.ServerTime == input.ServerTime ||
                    (this.ServerTime != null &&
                    this.ServerTime.Equals(input.ServerTime))
                ) && 
                (
                    this.Uptime == input.Uptime ||
                    (this.Uptime != null &&
                    this.Uptime.Equals(input.Uptime))
                ) && 
                (
                    this.UptimeMillis == input.UptimeMillis ||
                    (this.UptimeMillis != null &&
                    this.UptimeMillis.Equals(input.UptimeMillis))
                ) && 
                (
                    this.UserDir == input.UserDir ||
                    (this.UserDir != null &&
                    this.UserDir.Equals(input.UserDir))
                ) && 
                (
                    this.UserLocale == input.UserLocale ||
                    (this.UserLocale != null &&
                    this.UserLocale.Equals(input.UserLocale))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserTimezone == input.UserTimezone ||
                    (this.UserTimezone != null &&
                    this.UserTimezone.Equals(input.UserTimezone))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.FileEncoding != null)
                    hashCode = hashCode * 59 + this.FileEncoding.GetHashCode();
                if (this.JavaHome != null)
                    hashCode = hashCode * 59 + this.JavaHome.GetHashCode();
                if (this.JavaRuntime != null)
                    hashCode = hashCode * 59 + this.JavaRuntime.GetHashCode();
                if (this.JavaVendor != null)
                    hashCode = hashCode * 59 + this.JavaVendor.GetHashCode();
                if (this.JavaVersion != null)
                    hashCode = hashCode * 59 + this.JavaVersion.GetHashCode();
                if (this.JavaVm != null)
                    hashCode = hashCode * 59 + this.JavaVm.GetHashCode();
                if (this.JavaVmVersion != null)
                    hashCode = hashCode * 59 + this.JavaVmVersion.GetHashCode();
                if (this.OsArchitecture != null)
                    hashCode = hashCode * 59 + this.OsArchitecture.GetHashCode();
                if (this.OsName != null)
                    hashCode = hashCode * 59 + this.OsName.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ServerTime != null)
                    hashCode = hashCode * 59 + this.ServerTime.GetHashCode();
                if (this.Uptime != null)
                    hashCode = hashCode * 59 + this.Uptime.GetHashCode();
                if (this.UptimeMillis != null)
                    hashCode = hashCode * 59 + this.UptimeMillis.GetHashCode();
                if (this.UserDir != null)
                    hashCode = hashCode * 59 + this.UserDir.GetHashCode();
                if (this.UserLocale != null)
                    hashCode = hashCode * 59 + this.UserLocale.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserTimezone != null)
                    hashCode = hashCode * 59 + this.UserTimezone.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
