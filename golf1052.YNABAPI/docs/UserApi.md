# golf1052.YNABAPI.Api.UserApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUser**](UserApi.md#getuser) | **GET** /user | User info


<a name="getuser"></a>
# **GetUser**
> UserResponse GetUser ()

User info

Returns authenticated user information

### Example
```csharp
using System;
using System.Diagnostics;
using golf1052.YNABAPI.Api;
using golf1052.YNABAPI.Client;
using golf1052.YNABAPI.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // User info
                UserResponse result = apiInstance.GetUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

