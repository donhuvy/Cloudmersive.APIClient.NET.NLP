/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.NLP.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.NLP.Model
{
    /// <summary>
    /// Part of speech tag result
    /// </summary>
    [DataContract]
    public partial class PosResponse :  IEquatable<PosResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PosResponse" /> class.
        /// </summary>
        /// <param name="taggedSentences">Sentences in the string.</param>
        public PosResponse(List<PosSentence> taggedSentences = default(List<PosSentence>))
        {
            this.TaggedSentences = taggedSentences;
        }
        
        /// <summary>
        /// Sentences in the string
        /// </summary>
        /// <value>Sentences in the string</value>
        [DataMember(Name="TaggedSentences", EmitDefaultValue=false)]
        public List<PosSentence> TaggedSentences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PosResponse {\n");
            sb.Append("  TaggedSentences: ").Append(TaggedSentences).Append("\n");
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
            return this.Equals(input as PosResponse);
        }

        /// <summary>
        /// Returns true if PosResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PosResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaggedSentences == input.TaggedSentences ||
                    this.TaggedSentences != null &&
                    this.TaggedSentences.SequenceEqual(input.TaggedSentences)
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
                if (this.TaggedSentences != null)
                    hashCode = hashCode * 59 + this.TaggedSentences.GetHashCode();
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
