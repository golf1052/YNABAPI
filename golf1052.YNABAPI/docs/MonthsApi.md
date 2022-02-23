# golf1052.YNABAPI.Api.MonthsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBudgetMonth**](MonthsApi.md#getbudgetmonth) | **GET** /budgets/{budget_id}/months/{month} | Single budget month
[**GetBudgetMonths**](MonthsApi.md#getbudgetmonths) | **GET** /budgets/{budget_id}/months | List budget months


<a name="getbudgetmonth"></a>
# **GetBudgetMonth**
> MonthDetailResponse GetBudgetMonth (string budgetId, DateTime? month)

Single budget month

Returns a single budget month

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetBudgetMonthExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonthsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var month = 2013-10-20;  // DateTime? | The budget month in ISO format (e.g. 2016-12-01) (\"current\" can also be used to specify the current calendar month (UTC))

            try
            {
                // Single budget month
                MonthDetailResponse result = apiInstance.GetBudgetMonth(budgetId, month);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonthsApi.GetBudgetMonth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **month** | **DateTime?**| The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC)) | 

### Return type

[**MonthDetailResponse**](MonthDetailResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgetmonths"></a>
# **GetBudgetMonths**
> MonthSummariesResponse GetBudgetMonths (string budgetId, long? lastKnowledgeOfServer = null)

List budget months

Returns all budget months

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetBudgetMonthsExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonthsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var lastKnowledgeOfServer = 789;  // long? | The starting server knowledge.  If provided, only entities that have changed since `last_knowledge_of_server` will be included. (optional) 

            try
            {
                // List budget months
                MonthSummariesResponse result = apiInstance.GetBudgetMonths(budgetId, lastKnowledgeOfServer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonthsApi.GetBudgetMonths: " + e.Message );
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

[**MonthSummariesResponse**](MonthSummariesResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

