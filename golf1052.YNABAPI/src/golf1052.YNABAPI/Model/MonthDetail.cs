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
    /// MonthDetail
    /// </summary>
    [DataContract]
    public partial class MonthDetail : MonthSummary,  IEquatable<MonthDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MonthDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthDetail" /> class.
        /// </summary>
        /// <param name="categories">The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified. (required).</param>
        public MonthDetail(List<Category> categories = default(List<Category>), DateTime? month = default(DateTime?), string note = default(string), long? income = default(long?), long? budgeted = default(long?), long? activity = default(long?), long? toBeBudgeted = default(long?), int? ageOfMoney = default(int?), bool? deleted = default(bool?)) : base(month, note, income, budgeted, activity, toBeBudgeted, ageOfMoney, deleted)
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for MonthDetail and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
        }
        
        /// <summary>
        /// The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified.
        /// </summary>
        /// <value>The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonthDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as MonthDetail);
        }

        /// <summary>
        /// Returns true if MonthDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                return hashCode;
            }
        }
    }

}
