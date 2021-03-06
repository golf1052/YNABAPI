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
    public interface IMonthsApi : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>Task of MonthDetailResponse</returns>
        System.Threading.Tasks.Task<MonthDetailResponse> GetBudgetMonthAsync (string budgetId, DateTime? month);

        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>Task of ApiResponse (MonthDetailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MonthDetailResponse>> GetBudgetMonthAsyncWithHttpInfo (string budgetId, DateTime? month);
        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of MonthSummariesResponse</returns>
        System.Threading.Tasks.Task<MonthSummariesResponse> GetBudgetMonthsAsync (string budgetId, long? lastKnowledgeOfServer = null);

        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of ApiResponse (MonthSummariesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MonthSummariesResponse>> GetBudgetMonthsAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MonthsApi : IMonthsApi
    {
        private golf1052.YNABAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthsApi(String basePath)
        {
            this.Configuration = new golf1052.YNABAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = golf1052.YNABAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MonthsApi(golf1052.YNABAPI.Client.Configuration configuration = null)
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
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>Task of MonthDetailResponse</returns>
        public async System.Threading.Tasks.Task<MonthDetailResponse> GetBudgetMonthAsync (string budgetId, DateTime? month)
        {
             ApiResponse<MonthDetailResponse> localVarResponse = await GetBudgetMonthAsyncWithHttpInfo(budgetId, month);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>Task of ApiResponse (MonthDetailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MonthDetailResponse>> GetBudgetMonthAsyncWithHttpInfo (string budgetId, DateTime? month)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonth");
            // verify the required parameter 'month' is set
            if (month == null)
                throw new ApiException(400, "Missing required parameter 'month' when calling MonthsApi->GetBudgetMonth");

            var localVarPath = "./budgets/{budget_id}/months/{month}";
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
            if (month != null) localVarPathParams.Add("month", this.Configuration.ApiClient.ParameterToString(month)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBudgetMonth", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MonthDetailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MonthDetailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MonthDetailResponse)));
        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of MonthSummariesResponse</returns>
        public async System.Threading.Tasks.Task<MonthSummariesResponse> GetBudgetMonthsAsync (string budgetId, long? lastKnowledgeOfServer = null)
        {
             ApiResponse<MonthSummariesResponse> localVarResponse = await GetBudgetMonthsAsyncWithHttpInfo(budgetId, lastKnowledgeOfServer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of ApiResponse (MonthSummariesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MonthSummariesResponse>> GetBudgetMonthsAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonths");

            var localVarPath = "./budgets/{budget_id}/months";
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
            if (lastKnowledgeOfServer != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "last_knowledge_of_server", lastKnowledgeOfServer)); // query parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBudgetMonths", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MonthSummariesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MonthSummariesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MonthSummariesResponse)));
        }

    }
}
