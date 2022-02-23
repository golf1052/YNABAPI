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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace golf1052.YNABAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeprecatedApi : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Bulk create transactions
        /// </summary>
        /// <remarks>
        /// Creates multiple transactions.  Although this endpoint is still supported, it is recommended to use &#39;POST /budgets/{budget_id}/transactions&#39; to create multiple transactions.
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="transactions">The list of transactions to create</param>
        /// <returns>Task of BulkResponse</returns>
        System.Threading.Tasks.Task<BulkResponse> BulkCreateTransactionsAsync (string budgetId, BulkTransactions transactions);

        /// <summary>
        /// Bulk create transactions
        /// </summary>
        /// <remarks>
        /// Creates multiple transactions.  Although this endpoint is still supported, it is recommended to use &#39;POST /budgets/{budget_id}/transactions&#39; to create multiple transactions.
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="transactions">The list of transactions to create</param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkResponse>> BulkCreateTransactionsAsyncWithHttpInfo (string budgetId, BulkTransactions transactions);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeprecatedApi : IDeprecatedApi
    {
        private golf1052.YNABAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeprecatedApi(String basePath)
        {
            this.Configuration = new golf1052.YNABAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = golf1052.YNABAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeprecatedApi(golf1052.YNABAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = golf1052.YNABAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = golf1052.YNABAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClientOptions.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public golf1052.YNABAPI.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public golf1052.YNABAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Bulk create transactions Creates multiple transactions.  Although this endpoint is still supported, it is recommended to use &#39;POST /budgets/{budget_id}/transactions&#39; to create multiple transactions.
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="transactions">The list of transactions to create</param>
        /// <returns>Task of BulkResponse</returns>
        public async System.Threading.Tasks.Task<BulkResponse> BulkCreateTransactionsAsync (string budgetId, BulkTransactions transactions)
        {
             ApiResponse<BulkResponse> localVarResponse = await BulkCreateTransactionsAsyncWithHttpInfo(budgetId, transactions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk create transactions Creates multiple transactions.  Although this endpoint is still supported, it is recommended to use &#39;POST /budgets/{budget_id}/transactions&#39; to create multiple transactions.
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="transactions">The list of transactions to create</param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BulkResponse>> BulkCreateTransactionsAsyncWithHttpInfo (string budgetId, BulkTransactions transactions)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling DeprecatedApi->BulkCreateTransactions");
            // verify the required parameter 'transactions' is set
            if (transactions == null)
                throw new ApiException(400, "Missing required parameter 'transactions' when calling DeprecatedApi->BulkCreateTransactions");

            var localVarPath = "./budgets/{budget_id}/transactions/bulk";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (budgetId != null) localVarPathParams.Add("budget_id", this.Configuration.ApiClient.ParameterToString(budgetId)); // path parameter
            if (transactions != null && transactions.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactions; // byte array
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BulkCreateTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BulkResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)));
        }

    }
}