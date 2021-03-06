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
    /// BudgetSummary
    /// </summary>
    [DataContract]
    public partial class BudgetSummary :  IEquatable<BudgetSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSummary" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="lastModifiedOn">The last time any changes were made to the budget from either a web or mobile client.</param>
        /// <param name="firstMonth">The earliest budget month.</param>
        /// <param name="lastMonth">The latest budget month.</param>
        /// <param name="dateFormat">dateFormat.</param>
        /// <param name="currencyFormat">currencyFormat.</param>
        /// <param name="accounts">The budget accounts (only included if &#x60;include_accounts&#x3D;true&#x60; specified as query parameter).</param>
        public BudgetSummary(Guid? id = default(Guid?), string name = default(string), DateTime? lastModifiedOn = default(DateTime?), DateTime? firstMonth = default(DateTime?), DateTime? lastMonth = default(DateTime?), DateFormat dateFormat = default(DateFormat), CurrencyFormat currencyFormat = default(CurrencyFormat), List<Account> accounts = default(List<Account>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BudgetSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BudgetSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.LastModifiedOn = lastModifiedOn;
            this.FirstMonth = firstMonth;
            this.LastMonth = lastMonth;
            this.DateFormat = dateFormat;
            this.CurrencyFormat = currencyFormat;
            this.Accounts = accounts;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The last time any changes were made to the budget from either a web or mobile client
        /// </summary>
        /// <value>The last time any changes were made to the budget from either a web or mobile client</value>
        [DataMember(Name="last_modified_on", EmitDefaultValue=false)]
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// The earliest budget month
        /// </summary>
        /// <value>The earliest budget month</value>
        [DataMember(Name="first_month", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstMonth { get; set; }

        /// <summary>
        /// The latest budget month
        /// </summary>
        /// <value>The latest budget month</value>
        [DataMember(Name="last_month", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastMonth { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name="date_format", EmitDefaultValue=false)]
        public DateFormat DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyFormat
        /// </summary>
        [DataMember(Name="currency_format", EmitDefaultValue=false)]
        public CurrencyFormat CurrencyFormat { get; set; }

        /// <summary>
        /// The budget accounts (only included if &#x60;include_accounts&#x3D;true&#x60; specified as query parameter)
        /// </summary>
        /// <value>The budget accounts (only included if &#x60;include_accounts&#x3D;true&#x60; specified as query parameter)</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
            sb.Append("  FirstMonth: ").Append(FirstMonth).Append("\n");
            sb.Append("  LastMonth: ").Append(LastMonth).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as BudgetSummary);
        }

        /// <summary>
        /// Returns true if BudgetSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetSummary input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastModifiedOn == input.LastModifiedOn ||
                    (this.LastModifiedOn != null &&
                    this.LastModifiedOn.Equals(input.LastModifiedOn))
                ) && 
                (
                    this.FirstMonth == input.FirstMonth ||
                    (this.FirstMonth != null &&
                    this.FirstMonth.Equals(input.FirstMonth))
                ) && 
                (
                    this.LastMonth == input.LastMonth ||
                    (this.LastMonth != null &&
                    this.LastMonth.Equals(input.LastMonth))
                ) && 
                (
                    this.DateFormat == input.DateFormat ||
                    (this.DateFormat != null &&
                    this.DateFormat.Equals(input.DateFormat))
                ) && 
                (
                    this.CurrencyFormat == input.CurrencyFormat ||
                    (this.CurrencyFormat != null &&
                    this.CurrencyFormat.Equals(input.CurrencyFormat))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LastModifiedOn != null)
                    hashCode = hashCode * 59 + this.LastModifiedOn.GetHashCode();
                if (this.FirstMonth != null)
                    hashCode = hashCode * 59 + this.FirstMonth.GetHashCode();
                if (this.LastMonth != null)
                    hashCode = hashCode * 59 + this.LastMonth.GetHashCode();
                if (this.DateFormat != null)
                    hashCode = hashCode * 59 + this.DateFormat.GetHashCode();
                if (this.CurrencyFormat != null)
                    hashCode = hashCode * 59 + this.CurrencyFormat.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                return hashCode;
            }
        }
    }

}
