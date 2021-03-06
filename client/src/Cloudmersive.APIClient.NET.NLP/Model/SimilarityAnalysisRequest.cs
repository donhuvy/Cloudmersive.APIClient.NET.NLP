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
    /// Input to a similarity analysis operation
    /// </summary>
    [DataContract]
    public partial class SimilarityAnalysisRequest :  IEquatable<SimilarityAnalysisRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityAnalysisRequest" /> class.
        /// </summary>
        /// <param name="textToAnalyze1">First text to analyze.</param>
        /// <param name="textToAnalyze2">Second text to analyze.</param>
        public SimilarityAnalysisRequest(string textToAnalyze1 = default(string), string textToAnalyze2 = default(string))
        {
            this.TextToAnalyze1 = textToAnalyze1;
            this.TextToAnalyze2 = textToAnalyze2;
        }
        
        /// <summary>
        /// First text to analyze
        /// </summary>
        /// <value>First text to analyze</value>
        [DataMember(Name="TextToAnalyze1", EmitDefaultValue=false)]
        public string TextToAnalyze1 { get; set; }

        /// <summary>
        /// Second text to analyze
        /// </summary>
        /// <value>Second text to analyze</value>
        [DataMember(Name="TextToAnalyze2", EmitDefaultValue=false)]
        public string TextToAnalyze2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimilarityAnalysisRequest {\n");
            sb.Append("  TextToAnalyze1: ").Append(TextToAnalyze1).Append("\n");
            sb.Append("  TextToAnalyze2: ").Append(TextToAnalyze2).Append("\n");
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
            return this.Equals(input as SimilarityAnalysisRequest);
        }

        /// <summary>
        /// Returns true if SimilarityAnalysisRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SimilarityAnalysisRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimilarityAnalysisRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextToAnalyze1 == input.TextToAnalyze1 ||
                    (this.TextToAnalyze1 != null &&
                    this.TextToAnalyze1.Equals(input.TextToAnalyze1))
                ) && 
                (
                    this.TextToAnalyze2 == input.TextToAnalyze2 ||
                    (this.TextToAnalyze2 != null &&
                    this.TextToAnalyze2.Equals(input.TextToAnalyze2))
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
                if (this.TextToAnalyze1 != null)
                    hashCode = hashCode * 59 + this.TextToAnalyze1.GetHashCode();
                if (this.TextToAnalyze2 != null)
                    hashCode = hashCode * 59 + this.TextToAnalyze2.GetHashCode();
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
