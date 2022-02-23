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
    /// HybridTransaction
    /// </summary>
    [DataContract]
    public partial class HybridTransaction : TransactionSummary,  IEquatable<HybridTransaction>
    {
        /// <summary>
        /// Whether the hybrid transaction represents a regular transaction or a subtransaction
        /// </summary>
        /// <value>Whether the hybrid transaction represents a regular transaction or a subtransaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Transaction for value: transaction
            /// </summary>
            [EnumMember(Value = "transaction")]
            Transaction = 1,
            
            /// <summary>
            /// Enum Subtransaction for value: subtransaction
            /// </summary>
            [EnumMember(Value = "subtransaction")]
            Subtransaction = 2
        }

        /// <summary>
        /// Whether the hybrid transaction represents a regular transaction or a subtransaction
        /// </summary>
        /// <value>Whether the hybrid transaction represents a regular transaction or a subtransaction</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HybridTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HybridTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HybridTransaction" /> class.
        /// </summary>
        /// <param name="type">Whether the hybrid transaction represents a regular transaction or a subtransaction (required).</param>
        /// <param name="parentTransactionId">For subtransaction types, this is the id of the parent transaction.  For transaction types, this id will be always be null..</param>
        /// <param name="accountName">accountName (required).</param>
        /// <param name="payeeName">payeeName.</param>
        /// <param name="categoryName">categoryName.</param>
        public HybridTransaction(TypeEnum type = default(TypeEnum), string parentTransactionId = default(string), string accountName = default(string), string payeeName = default(string), string categoryName = default(string), string id = default(string), DateTime? date = default(DateTime?), long? amount = default(long?), string memo = default(string), HelperMethods.ClearedEnum cleared = default(HelperMethods.ClearedEnum), bool? approved = default(bool?), HelperMethods.FlagColorEnum? flagColor = default(HelperMethods.FlagColorEnum?), Guid? accountId = default(Guid?), Guid? payeeId = default(Guid?), Guid? categoryId = default(Guid?), Guid? transferAccountId = default(Guid?), string transferTransactionId = default(string), string matchedTransactionId = default(string), string importId = default(string), bool? deleted = default(bool?)) : base(id, date, amount, memo, cleared, approved, flagColor, accountId, payeeId, categoryId, transferAccountId, transferTransactionId, matchedTransactionId, importId, deleted)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for HybridTransaction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new InvalidDataException("accountName is a required property for HybridTransaction and cannot be null");
            }
            else
            {
                this.AccountName = accountName;
            }
            this.ParentTransactionId = parentTransactionId;
            this.PayeeName = payeeName;
            this.CategoryName = categoryName;
        }
        

        /// <summary>
        /// For subtransaction types, this is the id of the parent transaction.  For transaction types, this id will be always be null.
        /// </summary>
        /// <value>For subtransaction types, this is the id of the parent transaction.  For transaction types, this id will be always be null.</value>
        [DataMember(Name="parent_transaction_id", EmitDefaultValue=false)]
        public string ParentTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="account_name", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets PayeeName
        /// </summary>
        [DataMember(Name="payee_name", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="category_name", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HybridTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ParentTransactionId: ").Append(ParentTransactionId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as HybridTransaction);
        }

        /// <summary>
        /// Returns true if HybridTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of HybridTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HybridTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.ParentTransactionId == input.ParentTransactionId ||
                    (this.ParentTransactionId != null &&
                    this.ParentTransactionId.Equals(input.ParentTransactionId))
                ) && base.Equals(input) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && base.Equals(input) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && base.Equals(input) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ParentTransactionId != null)
                    hashCode = hashCode * 59 + this.ParentTransactionId.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                return hashCode;
            }
        }
    }

}