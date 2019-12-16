/* 
 * Harmony Connect
 *
 * An easy to use API that helps you access the Factom blockchain.
 *
 * OpenAPI spec version: 1.0.19
 * Contact: harmony-support@factom.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = harmony-connect-client.Client.OpenAPIDateConverter;

namespace harmony-connect-client.Model
{
    /// <summary>
    /// A single factoid transaction.
    /// </summary>
    [DataContract]
    public partial class TransactionLink :  IEquatable<TransactionLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLink" /> class.
        /// </summary>
        /// <param name="txId">The transaction ID for this transaction..</param>
        /// <param name="createdAt">The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;.</param>
        /// <param name="href">An API link to obtain all data for this transaction..</param>
        /// <param name="fctTotalInputs">The number of factoids coming in from the sender..</param>
        /// <param name="fctTotalOutputs">The number of factoids going out to the receiver..</param>
        /// <param name="ecCreated">The number of entry credits that have been purchased in this transaction..</param>
        /// <param name="fctFee">The fee paid to the processor of this transaction..</param>
        public TransactionLink(string txId = default(string), string createdAt = default(string), string href = default(string), string fctTotalInputs = default(string), string fctTotalOutputs = default(string), string ecCreated = default(string), string fctFee = default(string))
        {
            this.TxId = txId;
            this.CreatedAt = createdAt;
            this.Href = href;
            this.FctTotalInputs = fctTotalInputs;
            this.FctTotalOutputs = fctTotalOutputs;
            this.EcCreated = ecCreated;
            this.FctFee = fctFee;
        }
        
        /// <summary>
        /// The transaction ID for this transaction.
        /// </summary>
        /// <value>The transaction ID for this transaction.</value>
        [DataMember(Name="tx_id", EmitDefaultValue=false)]
        public string TxId { get; set; }

        /// <summary>
        /// The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// An API link to obtain all data for this transaction.
        /// </summary>
        /// <value>An API link to obtain all data for this transaction.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// The number of factoids coming in from the sender.
        /// </summary>
        /// <value>The number of factoids coming in from the sender.</value>
        [DataMember(Name="fct_total_inputs", EmitDefaultValue=false)]
        public string FctTotalInputs { get; set; }

        /// <summary>
        /// The number of factoids going out to the receiver.
        /// </summary>
        /// <value>The number of factoids going out to the receiver.</value>
        [DataMember(Name="fct_total_outputs", EmitDefaultValue=false)]
        public string FctTotalOutputs { get; set; }

        /// <summary>
        /// The number of entry credits that have been purchased in this transaction.
        /// </summary>
        /// <value>The number of entry credits that have been purchased in this transaction.</value>
        [DataMember(Name="ec_created", EmitDefaultValue=false)]
        public string EcCreated { get; set; }

        /// <summary>
        /// The fee paid to the processor of this transaction.
        /// </summary>
        /// <value>The fee paid to the processor of this transaction.</value>
        [DataMember(Name="fct_fee", EmitDefaultValue=false)]
        public string FctFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionLink {\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  FctTotalInputs: ").Append(FctTotalInputs).Append("\n");
            sb.Append("  FctTotalOutputs: ").Append(FctTotalOutputs).Append("\n");
            sb.Append("  EcCreated: ").Append(EcCreated).Append("\n");
            sb.Append("  FctFee: ").Append(FctFee).Append("\n");
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
            return this.Equals(input as TransactionLink);
        }

        /// <summary>
        /// Returns true if TransactionLink instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.FctTotalInputs == input.FctTotalInputs ||
                    (this.FctTotalInputs != null &&
                    this.FctTotalInputs.Equals(input.FctTotalInputs))
                ) && 
                (
                    this.FctTotalOutputs == input.FctTotalOutputs ||
                    (this.FctTotalOutputs != null &&
                    this.FctTotalOutputs.Equals(input.FctTotalOutputs))
                ) && 
                (
                    this.EcCreated == input.EcCreated ||
                    (this.EcCreated != null &&
                    this.EcCreated.Equals(input.EcCreated))
                ) && 
                (
                    this.FctFee == input.FctFee ||
                    (this.FctFee != null &&
                    this.FctFee.Equals(input.FctFee))
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
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.FctTotalInputs != null)
                    hashCode = hashCode * 59 + this.FctTotalInputs.GetHashCode();
                if (this.FctTotalOutputs != null)
                    hashCode = hashCode * 59 + this.FctTotalOutputs.GetHashCode();
                if (this.EcCreated != null)
                    hashCode = hashCode * 59 + this.EcCreated.GetHashCode();
                if (this.FctFee != null)
                    hashCode = hashCode * 59 + this.FctFee.GetHashCode();
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