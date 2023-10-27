# lob.dotnet.Api.IdentityValidationApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IdentityValidation**](IdentityValidationApi.md#identityvalidation) | **POST** /identity_validation | validate


<a name="identityvalidation"></a>
# **IdentityValidation**
> IdentityValidation IdentityValidation (MultiLineAddress multiLineAddress)

validate

Validates whether a given name is associated with an address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class IdentityValidationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IdentityValidationApi(config);
            var multiLineAddress = new MultiLineAddress(); // MultiLineAddress | 

            try
            {
                // validate
                IdentityValidation result = apiInstance.IdentityValidation(multiLineAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityValidationApi.IdentityValidation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **multiLineAddress** | [**MultiLineAddress**](MultiLineAddress.md)|  | 

### Return type

[**IdentityValidation**](IdentityValidation.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the likelihood a given name is associated with an address. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

