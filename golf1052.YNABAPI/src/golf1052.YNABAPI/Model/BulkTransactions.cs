/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = golf1052.YNABAPI.Client.SwaggerDateConverter;

namespace golf1052.YNABAPI.Model
{
    /// <summary>
    /// BulkTransactions
    /// </summary>
    [DataContract]
    public partial class BulkTransactions :  IEquatable<BulkTransactions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTransactions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkTransactions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTransactions" /> class.
        /// </summary>
        /// <param name="transactions">transactions (required).</param>
        public BulkTransactions(List<SaveTransaction> transactions = default(List<SaveTransaction>))
        {
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new InvalidDataException("transactions is a required property for BulkTransactions and cannot be null");
            }
            else
            {
                this.Transactions = transactions;
            }
        }
        
        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<SaveTransaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkTransactions {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as BulkTransactions);
        }

        /// <summary>
        /// Returns true if BulkTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkTransactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                return hashCode;
            }
        }
    }

}
