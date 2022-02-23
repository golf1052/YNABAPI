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
    /// TransactionDetail
    /// </summary>
    [DataContract]
    public partial class TransactionDetail : TransactionSummary,  IEquatable<TransactionDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetail" /> class.
        /// </summary>
        /// <param name="accountName">accountName (required).</param>
        /// <param name="payeeName">payeeName.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="subtransactions">If a split transaction, the subtransactions. (required).</param>
        public TransactionDetail(string accountName = default(string), string payeeName = default(string), string categoryName = default(string), List<SubTransaction> subtransactions = default(List<SubTransaction>), string id = default(string), DateTime? date = default(DateTime?), long? amount = default(long?), string memo = default(string), HelperMethods.ClearedEnum cleared = default(HelperMethods.ClearedEnum), bool? approved = default(bool?), HelperMethods.FlagColorEnum? flagColor = default(HelperMethods.FlagColorEnum?), Guid? accountId = default(Guid?), Guid? payeeId = default(Guid?), Guid? categoryId = default(Guid?), Guid? transferAccountId = default(Guid?), string transferTransactionId = default(string), string matchedTransactionId = default(string), string importId = default(string), bool? deleted = default(bool?)) : base(id, date, amount, memo, cleared, approved, flagColor, accountId, payeeId, categoryId, transferAccountId, transferTransactionId, matchedTransactionId, importId, deleted)
        {
            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new InvalidDataException("accountName is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.AccountName = accountName;
            }
            // to ensure "subtransactions" is required (not null)
            if (subtransactions == null)
            {
                throw new InvalidDataException("subtransactions is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Subtransactions = subtransactions;
            }
            this.PayeeName = payeeName;
            this.CategoryName = categoryName;
        }
        
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
        /// If a split transaction, the subtransactions.
        /// </summary>
        /// <value>If a split transaction, the subtransactions.</value>
        [DataMember(Name="subtransactions", EmitDefaultValue=false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
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
            return this.Equals(input as TransactionDetail);
        }

        /// <summary>
        /// Returns true if TransactionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                ) && base.Equals(input) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
                return hashCode;
            }
        }
    }

}
