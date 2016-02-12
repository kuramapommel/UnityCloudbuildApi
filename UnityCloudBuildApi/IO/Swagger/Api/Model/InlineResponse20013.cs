using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse20013 :  IEquatable<InlineResponse20013>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20013" /> class.
        /// </summary>
        public InlineResponse20013()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
  
        
        /// <summary>
        /// Gets or Sets XcodeVersions
        /// </summary>
        [DataMember(Name="xcode_versions", EmitDefaultValue=false)]
        public List<string> XcodeVersions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20013 {\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  XcodeVersions: ").Append(XcodeVersions).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20013);
        }

        /// <summary>
        /// Returns true if InlineResponse20013 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20013 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20013 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hidden == other.Hidden ||
                    this.Hidden != null &&
                    this.Hidden.Equals(other.Hidden)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.XcodeVersions == other.XcodeVersions ||
                    this.XcodeVersions != null &&
                    this.XcodeVersions.SequenceEqual(other.XcodeVersions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Hidden != null)
                    hash = hash * 59 + this.Hidden.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.XcodeVersions != null)
                    hash = hash * 59 + this.XcodeVersions.GetHashCode();
                
                return hash;
            }
        }

    }
}
