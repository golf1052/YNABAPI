# golf1052.YNABAPI.Api.ScheduledTransactionsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetScheduledTransactionById**](ScheduledTransactionsApi.md#getscheduledtransactionbyid) | **GET** /budgets/{budget_id}/scheduled_transactions/{scheduled_transaction_id} | Single scheduled transaction
[**GetScheduledTransactions**](ScheduledTransactionsApi.md#getscheduledtransactions) | **GET** /budgets/{budget_id}/scheduled_transactions | List scheduled transactions


<a name="getscheduledtransactionbyid"></a>
# **GetScheduledTransactionById**
> ScheduledTransactionResponse GetScheduledTransactionById (string budgetId, string scheduledTransactionId)

Single scheduled transaction

Returns a single scheduled transaction

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetScheduledTransactionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledTransactionsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var scheduledTransactionId = scheduledTransactionId_example;  // string | The id of the scheduled transaction

            try
            {
                // Single scheduled transaction
                ScheduledTransactionResponse result = apiInstance.GetScheduledTransactionById(budgetId, scheduledTransactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledTransactionsApi.GetScheduledTransactionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **scheduledTransactionId** | **string**| The id of the scheduled transaction | 

### Return type

[**ScheduledTransactionResponse**](ScheduledTransactionResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledtransactions"></a>
# **GetScheduledTransactions**
> ScheduledTransactionsResponse GetScheduledTransactions (string budgetId, long? lastKnowledgeOfServer = null)

List scheduled transactions

Returns all scheduled transactions

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetScheduledTransactionsExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledTransactionsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var lastKnowledgeOfServer = 789;  // long? | The starting server knowledge.  If provided, only entities that have changed since `last_knowledge_of_server` will be included. (optional) 

            try
            {
                // List scheduled transactions
                ScheduledTransactionsResponse result = apiInstance.GetScheduledTransactions(budgetId, lastKnowledgeOfServer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledTransactionsApi.GetScheduledTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **lastKnowledgeOfServer** | **long?**| The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. | [optional] 

### Return type

[**ScheduledTransactionsResponse**](ScheduledTransactionsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

