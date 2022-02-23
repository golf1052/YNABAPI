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
    /// BudgetDetail
    /// </summary>
    [DataContract]
    public partial class BudgetDetail : BudgetSummary,  IEquatable<BudgetDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDetail" /> class.
        /// </summary>
        /// <param name="accounts">accounts.</param>
        /// <param name="payees">payees.</param>
        /// <param name="payeeLocations">payeeLocations.</param>
        /// <param name="categoryGroups">categoryGroups.</param>
        /// <param name="categories">categories.</param>
        /// <param name="months">months.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="subtransactions">subtransactions.</param>
        /// <param name="scheduledTransactions">scheduledTransactions.</param>
        /// <param name="scheduledSubtransactions">scheduledSubtransactions.</param>
        public BudgetDetail(List<Account> accounts = default(List<Account>), List<Payee> payees = default(List<Payee>), List<PayeeLocation> payeeLocations = default(List<PayeeLocation>), List<CategoryGroup> categoryGroups = default(List<CategoryGroup>), List<Category> categories = default(List<Category>), List<MonthDetail> months = default(List<MonthDetail>), List<TransactionSummary> transactions = default(List<TransactionSummary>), List<SubTransaction> subtransactions = default(List<SubTransaction>), List<ScheduledTransactionSummary> scheduledTransactions = default(List<ScheduledTransactionSummary>), List<ScheduledSubTransaction> scheduledSubtransactions = default(List<ScheduledSubTransaction>), Guid? id = default(Guid?), string name = default(string), DateTime? lastModifiedOn = default(DateTime?), DateTime? firstMonth = default(DateTime?), DateTime? lastMonth = default(DateTime?), DateFormat dateFormat = default(DateFormat), CurrencyFormat currencyFormat = default(CurrencyFormat)) : base(id, name, lastModifiedOn, firstMonth, lastMonth, dateFormat, currencyFormat)
        {
            this.Accounts = accounts;
            this.Payees = payees;
            this.PayeeLocations = payeeLocations;
            this.CategoryGroups = categoryGroups;
            this.Categories = categories;
            this.Months = months;
            this.Transactions = transactions;
            this.Subtransactions = subtransactions;
            this.ScheduledTransactions = scheduledTransactions;
            this.ScheduledSubtransactions = scheduledSubtransactions;
        }
        
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Payees
        /// </summary>
        [DataMember(Name="payees", EmitDefaultValue=false)]
        public List<Payee> Payees { get; set; }

        /// <summary>
        /// Gets or Sets PayeeLocations
        /// </summary>
        [DataMember(Name="payee_locations", EmitDefaultValue=false)]
        public List<PayeeLocation> PayeeLocations { get; set; }

        /// <summary>
        /// Gets or Sets CategoryGroups
        /// </summary>
        [DataMember(Name="category_groups", EmitDefaultValue=false)]
        public List<CategoryGroup> CategoryGroups { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Months
        /// </summary>
        [DataMember(Name="months", EmitDefaultValue=false)]
        public List<MonthDetail> Months { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<TransactionSummary> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Subtransactions
        /// </summary>
        [DataMember(Name="subtransactions", EmitDefaultValue=false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledTransactions
        /// </summary>
        [DataMember(Name="scheduled_transactions", EmitDefaultValue=false)]
        public List<ScheduledTransactionSummary> ScheduledTransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledSubtransactions
        /// </summary>
        [DataMember(Name="scheduled_subtransactions", EmitDefaultValue=false)]
        public List<ScheduledSubTransaction> ScheduledSubtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Payees: ").Append(Payees).Append("\n");
            sb.Append("  PayeeLocations: ").Append(PayeeLocations).Append("\n");
            sb.Append("  CategoryGroups: ").Append(CategoryGroups).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
            sb.Append("  ScheduledTransactions: ").Append(ScheduledTransactions).Append("\n");
            sb.Append("  ScheduledSubtransactions: ").Append(ScheduledSubtransactions).Append("\n");
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
            return this.Equals(input as BudgetDetail);
        }

        /// <summary>
        /// Returns true if BudgetDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && base.Equals(input) && 
                (
                    this.Payees == input.Payees ||
                    this.Payees != null &&
                    this.Payees.SequenceEqual(input.Payees)
                ) && base.Equals(input) && 
                (
                    this.PayeeLocations == input.PayeeLocations ||
                    this.PayeeLocations != null &&
                    this.PayeeLocations.SequenceEqual(input.PayeeLocations)
                ) && base.Equals(input) && 
                (
                    this.CategoryGroups == input.CategoryGroups ||
                    this.CategoryGroups != null &&
                    this.CategoryGroups.SequenceEqual(input.CategoryGroups)
                ) && base.Equals(input) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && base.Equals(input) && 
                (
                    this.Months == input.Months ||
                    this.Months != null &&
                    this.Months.SequenceEqual(input.Months)
                ) && base.Equals(input) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && base.Equals(input) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
                ) && base.Equals(input) && 
                (
                    this.ScheduledTransactions == input.ScheduledTransactions ||
                    this.ScheduledTransactions != null &&
                    this.ScheduledTransactions.SequenceEqual(input.ScheduledTransactions)
                ) && base.Equals(input) && 
                (
                    this.ScheduledSubtransactions == input.ScheduledSubtransactions ||
                    this.ScheduledSubtransactions != null &&
                    this.ScheduledSubtransactions.SequenceEqual(input.ScheduledSubtransactions)
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Payees != null)
                    hashCode = hashCode * 59 + this.Payees.GetHashCode();
                if (this.PayeeLocations != null)
                    hashCode = hashCode * 59 + this.PayeeLocations.GetHashCode();
                if (this.CategoryGroups != null)
                    hashCode = hashCode * 59 + this.CategoryGroups.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Months != null)
                    hashCode = hashCode * 59 + this.Months.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
                if (this.ScheduledTransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledTransactions.GetHashCode();
                if (this.ScheduledSubtransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledSubtransactions.GetHashCode();
                return hashCode;
            }
        }
    }

}