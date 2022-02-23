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
    /// ScheduledTransactionSummary
    /// </summary>
    [DataContract]
    public partial class ScheduledTransactionSummary :  IEquatable<ScheduledTransactionSummary>
    {
        /// <summary>
        /// Defines Frequency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum Never for value: never
            /// </summary>
            [EnumMember(Value = "never")]
            Never = 1,
            
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 2,
            
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 3,
            
            /// <summary>
            /// Enum EveryOtherWeek for value: everyOtherWeek
            /// </summary>
            [EnumMember(Value = "everyOtherWeek")]
            EveryOtherWeek = 4,
            
            /// <summary>
            /// Enum TwiceAMonth for value: twiceAMonth
            /// </summary>
            [EnumMember(Value = "twiceAMonth")]
            TwiceAMonth = 5,
            
            /// <summary>
            /// Enum Every4Weeks for value: every4Weeks
            /// </summary>
            [EnumMember(Value = "every4Weeks")]
            Every4Weeks = 6,
            
            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 7,
            
            /// <summary>
            /// Enum EveryOtherMonth for value: everyOtherMonth
            /// </summary>
            [EnumMember(Value = "everyOtherMonth")]
            EveryOtherMonth = 8,
            
            /// <summary>
            /// Enum Every3Months for value: every3Months
            /// </summary>
            [EnumMember(Value = "every3Months")]
            Every3Months = 9,
            
            /// <summary>
            /// Enum Every4Months for value: every4Months
            /// </summary>
            [EnumMember(Value = "every4Months")]
            Every4Months = 10,
            
            /// <summary>
            /// Enum TwiceAYear for value: twiceAYear
            /// </summary>
            [EnumMember(Value = "twiceAYear")]
            TwiceAYear = 11,
            
            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 12,
            
            /// <summary>
            /// Enum EveryOtherYear for value: everyOtherYear
            /// </summary>
            [EnumMember(Value = "everyOtherYear")]
            EveryOtherYear = 13
        }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum Frequency { get; set; }
        /// <summary>
        /// The scheduled transaction flag
        /// </summary>
        /// <value>The scheduled transaction flag</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagColorEnum
        {
            
            /// <summary>
            /// Enum Red for value: red
            /// </summary>
            [EnumMember(Value = "red")]
            Red = 1,
            
            /// <summary>
            /// Enum Orange for value: orange
            /// </summary>
            [EnumMember(Value = "orange")]
            Orange = 2,
            
            /// <summary>
            /// Enum Yellow for value: yellow
            /// </summary>
            [EnumMember(Value = "yellow")]
            Yellow = 3,
            
            /// <summary>
            /// Enum Green for value: green
            /// </summary>
            [EnumMember(Value = "green")]
            Green = 4,
            
            /// <summary>
            /// Enum Blue for value: blue
            /// </summary>
            [EnumMember(Value = "blue")]
            Blue = 5,
            
            /// <summary>
            /// Enum Purple for value: purple
            /// </summary>
            [EnumMember(Value = "purple")]
            Purple = 6
        }

        /// <summary>
        /// The scheduled transaction flag
        /// </summary>
        /// <value>The scheduled transaction flag</value>
        [DataMember(Name="flag_color", EmitDefaultValue=false)]
        public FlagColorEnum? FlagColor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledTransactionSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionSummary" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="dateFirst">The first date for which the Scheduled Transaction was scheduled. (required).</param>
        /// <param name="dateNext">The next date for which the Scheduled Transaction is scheduled. (required).</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="amount">The scheduled transaction amount in milliunits format (required).</param>
        /// <param name="memo">memo.</param>
        /// <param name="flagColor">The scheduled transaction flag.</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="payeeId">payeeId.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="transferAccountId">If a transfer, the account_id which the scheduled transaction transfers to.</param>
        /// <param name="deleted">Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests. (required).</param>
        public ScheduledTransactionSummary(Guid? id = default(Guid?), DateTime? dateFirst = default(DateTime?), DateTime? dateNext = default(DateTime?), FrequencyEnum frequency = default(FrequencyEnum), long? amount = default(long?), string memo = default(string), FlagColorEnum? flagColor = default(FlagColorEnum?), Guid? accountId = default(Guid?), Guid? payeeId = default(Guid?), Guid? categoryId = default(Guid?), Guid? transferAccountId = default(Guid?), bool? deleted = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "dateFirst" is required (not null)
            if (dateFirst == null)
            {
                throw new InvalidDataException("dateFirst is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.DateFirst = dateFirst;
            }
            // to ensure "dateNext" is required (not null)
            if (dateNext == null)
            {
                throw new InvalidDataException("dateNext is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.DateNext = dateNext;
            }
            // to ensure "frequency" is required (not null)
            if (frequency == null)
            {
                throw new InvalidDataException("frequency is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.Frequency = frequency;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for ScheduledTransactionSummary and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }
            this.Memo = memo;
            this.FlagColor = flagColor;
            this.PayeeId = payeeId;
            this.CategoryId = categoryId;
            this.TransferAccountId = transferAccountId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The first date for which the Scheduled Transaction was scheduled.
        /// </summary>
        /// <value>The first date for which the Scheduled Transaction was scheduled.</value>
        [DataMember(Name="date_first", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateFirst { get; set; }

        /// <summary>
        /// The next date for which the Scheduled Transaction is scheduled.
        /// </summary>
        /// <value>The next date for which the Scheduled Transaction is scheduled.</value>
        [DataMember(Name="date_next", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateNext { get; set; }


        /// <summary>
        /// The scheduled transaction amount in milliunits format
        /// </summary>
        /// <value>The scheduled transaction amount in milliunits format</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }


        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets PayeeId
        /// </summary>
        [DataMember(Name="payee_id", EmitDefaultValue=false)]
        public Guid? PayeeId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// If a transfer, the account_id which the scheduled transaction transfers to
        /// </summary>
        /// <value>If a transfer, the account_id which the scheduled transaction transfers to</value>
        [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
        public Guid? TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTransactionSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateFirst: ").Append(DateFirst).Append("\n");
            sb.Append("  DateNext: ").Append(DateNext).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
            return this.Equals(input as ScheduledTransactionSummary);
        }

        /// <summary>
        /// Returns true if ScheduledTransactionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledTransactionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledTransactionSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DateFirst == input.DateFirst ||
                    (this.DateFirst != null &&
                    this.DateFirst.Equals(input.DateFirst))
                ) && 
                (
                    this.DateNext == input.DateNext ||
                    (this.DateNext != null &&
                    this.DateNext.Equals(input.DateNext))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.FlagColor == input.FlagColor ||
                    (this.FlagColor != null &&
                    this.FlagColor.Equals(input.FlagColor))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.TransferAccountId == input.TransferAccountId ||
                    (this.TransferAccountId != null &&
                    this.TransferAccountId.Equals(input.TransferAccountId))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DateFirst != null)
                    hashCode = hashCode * 59 + this.DateFirst.GetHashCode();
                if (this.DateNext != null)
                    hashCode = hashCode * 59 + this.DateNext.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.FlagColor != null)
                    hashCode = hashCode * 59 + this.FlagColor.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.TransferAccountId != null)
                    hashCode = hashCode * 59 + this.TransferAccountId.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                return hashCode;
            }
        }
    }

}
