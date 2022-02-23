# golf1052.YNABAPI.Api.PayeeLocationsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPayeeLocationById**](PayeeLocationsApi.md#getpayeelocationbyid) | **GET** /budgets/{budget_id}/payee_locations/{payee_location_id} | Single payee location
[**GetPayeeLocations**](PayeeLocationsApi.md#getpayeelocations) | **GET** /budgets/{budget_id}/payee_locations | List payee locations
[**GetPayeeLocationsByPayee**](PayeeLocationsApi.md#getpayeelocationsbypayee) | **GET** /budgets/{budget_id}/payees/{payee_id}/payee_locations | List locations for a payee


<a name="getpayeelocationbyid"></a>
# **GetPayeeLocationById**
> PayeeLocationResponse GetPayeeLocationById (string budgetId, string payeeLocationId)

Single payee location

Returns a single payee location

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetPayeeLocationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PayeeLocationsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var payeeLocationId = payeeLocationId_example;  // string | id of payee location

            try
            {
                // Single payee location
                PayeeLocationResponse result = apiInstance.GetPayeeLocationById(budgetId, payeeLocationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayeeLocationsApi.GetPayeeLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **payeeLocationId** | **string**| id of payee location | 

### Return type

[**PayeeLocationResponse**](PayeeLocationResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayeelocations"></a>
# **GetPayeeLocations**
> PayeeLocationsResponse GetPayeeLocations (string budgetId)

List payee locations

Returns all payee locations

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetPayeeLocationsExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PayeeLocationsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).

            try
            {
                // List payee locations
                PayeeLocationsResponse result = apiInstance.GetPayeeLocations(budgetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayeeLocationsApi.GetPayeeLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 

### Return type

[**PayeeLocationsResponse**](PayeeLocationsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayeelocationsbypayee"></a>
# **GetPayeeLocationsByPayee**
> PayeeLocationsResponse GetPayeeLocationsByPayee (string budgetId, string payeeId)

List locations for a payee

Returns all payee locations for a specified payee

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetPayeeLocationsByPayeeExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PayeeLocationsApi();
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var payeeId = payeeId_example;  // string | id of payee

            try
            {
                // List locations for a payee
                PayeeLocationsResponse result = apiInstance.GetPayeeLocationsByPayee(budgetId, payeeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayeeLocationsApi.GetPayeeLocationsByPayee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **payeeId** | **string**| id of payee | 

### Return type

[**PayeeLocationsResponse**](PayeeLocationsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

