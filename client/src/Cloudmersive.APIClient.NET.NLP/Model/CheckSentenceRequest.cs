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
    /// Input object for spell checking
    /// </summary>
    [DataContract]
    public partial class CheckSentenceRequest :  IEquatable<CheckSentenceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSentenceRequest" /> class.
        /// </summary>
        /// <param name="sentence">Input sentence for spell check.</param>
        public CheckSentenceRequest(string sentence = default(string))
        {
            this.Sentence = sentence;
        }
        
        /// <summary>
        /// Input sentence for spell check
        /// </summary>
        /// <value>Input sentence for spell check</value>
        [DataMember(Name="Sentence", EmitDefaultValue=false)]
        public string Sentence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckSentenceRequest {\n");
            sb.Append("  Sentence: ").Append(Sentence).Append("\n");
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
            return this.Equals(input as CheckSentenceRequest);
        }

        /// <summary>
        /// Returns true if CheckSentenceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckSentenceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckSentenceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sentence == input.Sentence ||
                    (this.Sentence != null &&
                    this.Sentence.Equals(input.Sentence))
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
                if (this.Sentence != null)
                    hashCode = hashCode * 59 + this.Sentence.GetHashCode();
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
