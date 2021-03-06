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
using golf1052.YNABAPI;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace golf1052.YNABAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <remarks>
        /// Creates a new account
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="data">The account to create.</param>
        /// <returns>Task of AccountResponse</returns>
        System.Threading.Tasks.Task<AccountResponse> CreateAccountAsync (string budgetId, SaveAccountWrapper data);

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <remarks>
        /// Creates a new account
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="data">The account to create.</param>
        /// <returns>Task of ApiResponse (AccountResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountResponse>> CreateAccountAsyncWithHttpInfo (string budgetId, SaveAccountWrapper data);
        /// <summary>
        /// Single account
        /// </summary>
        /// <remarks>
        /// Returns a single account
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="accountId">The id of the account</param>
        /// <returns>Task of AccountResponse</returns>
        System.Threading.Tasks.Task<AccountResponse> GetAccountByIdAsync (string budgetId, Guid? accountId);

        /// <summary>
        /// Single account
        /// </summary>
        /// <remarks>
        /// Returns a single account
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="accountId">The id of the account</param>
        /// <returns>Task of ApiResponse (AccountResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountResponse>> GetAccountByIdAsyncWithHttpInfo (string budgetId, Guid? accountId);
        /// <summary>
        /// Account list
        /// </summary>
        /// <remarks>
        /// Returns all accounts
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of AccountsResponse</returns>
        System.Threading.Tasks.Task<AccountsResponse> GetAccountsAsync (string budgetId, long? lastKnowledgeOfServer = null);

        /// <summary>
        /// Account list
        /// </summary>
        /// <remarks>
        /// Returns all accounts
        /// </remarks>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of ApiResponse (AccountsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<YNABResponse<AccountsResponse>>> GetAccountsAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private golf1052.YNABAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = new golf1052.YNABAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = golf1052.YNABAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(golf1052.YNABAPI.Client.Configuration configuration = null)
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
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClientOptions.BaseUrl.ToString();
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
        /// Create a new account Creates a new account
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="data">The account to create.</param>
        /// <returns>Task of AccountResponse</returns>
        public async System.Threading.Tasks.Task<AccountResponse> CreateAccountAsync (string budgetId, SaveAccountWrapper data)
        {
             ApiResponse<AccountResponse> localVarResponse = await CreateAccountAsyncWithHttpInfo(budgetId, data);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new account Creates a new account
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="data">The account to create.</param>
        /// <returns>Task of ApiResponse (AccountResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountResponse>> CreateAccountAsyncWithHttpInfo (string budgetId, SaveAccountWrapper data)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling AccountsApi->CreateAccount");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling AccountsApi->CreateAccount");

            var localVarPath = "./budgets/{budget_id}/accounts";
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
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
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
                Exception exception = ExceptionFactory("CreateAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountResponse)));
        }

        /// <summary>
        /// Single account Returns a single account
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="accountId">The id of the account</param>
        /// <returns>Task of AccountResponse</returns>
        public async System.Threading.Tasks.Task<AccountResponse> GetAccountByIdAsync (string budgetId, Guid? accountId)
        {
             ApiResponse<AccountResponse> localVarResponse = await GetAccountByIdAsyncWithHttpInfo(budgetId, accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Single account Returns a single account
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="accountId">The id of the account</param>
        /// <returns>Task of ApiResponse (AccountResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountResponse>> GetAccountByIdAsyncWithHttpInfo (string budgetId, Guid? accountId)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling AccountsApi->GetAccountById");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling AccountsApi->GetAccountById");

            var localVarPath = "./budgets/{budget_id}/accounts/{account_id}";
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
            if (accountId != null) localVarPathParams.Add("account_id", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAccountById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountResponse)));
        }

        /// <summary>
        /// Account list Returns all accounts
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of AccountsResponse</returns>
        public async System.Threading.Tasks.Task<AccountsResponse> GetAccountsAsync (string budgetId, long? lastKnowledgeOfServer = null)
        {
             ApiResponse<YNABResponse<AccountsResponse>> localVarResponse = await GetAccountsAsyncWithHttpInfo(budgetId, lastKnowledgeOfServer);
             return localVarResponse.Data.Data;

        }

        /// <summary>
        /// Account list Returns all accounts
        /// </summary>
        /// <exception cref="golf1052.YNABAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>Task of ApiResponse (AccountsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<YNABResponse<AccountsResponse>>> GetAccountsAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new ApiException(400, "Missing required parameter 'budgetId' when calling AccountsApi->GetAccounts");

            var localVarPath = "./budgets/{budget_id}/accounts";
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
                Exception exception = ExceptionFactory("GetAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<YNABResponse<AccountsResponse>>(localVarStatusCode,
                localVarResponse.Headers.HeadersToDictionary(),
                (YNABResponse<AccountsResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(YNABResponse<AccountsResponse>)));
        }
    }
}
