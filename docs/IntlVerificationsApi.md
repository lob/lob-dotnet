# lob.dotnet.Api.IntlVerificationsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkIntlVerifications**](IntlVerificationsApi.md#bulkintlverifications) | **POST** /bulk/intl_verifications | verifyBulk
[**IntlVerification**](IntlVerificationsApi.md#intlverification) | **POST** /intl_verifications | verifySingle


<a name="bulkintlverifications"></a>
# **BulkIntlVerifications**
> IntlVerifications BulkIntlVerifications (IntlVerificationsPayload intlVerificationsPayload)

verifyBulk

Verify a list of international (except US or US territories) address with a live API key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BulkIntlVerificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IntlVerificationsApi(config);
            var intlVerificationsPayload = new IntlVerificationsPayload(); // IntlVerificationsPayload | 

            try
            {
                // verifyBulk
                IntlVerifications result = apiInstance.BulkIntlVerifications(intlVerificationsPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntlVerificationsApi.BulkIntlVerifications: " + e.Message );
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
 **intlVerificationsPayload** | [**IntlVerificationsPayload**](IntlVerificationsPayload.md)|  | 

### Return type

[**IntlVerifications**](IntlVerifications.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an array of international verification objects. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="intlverification"></a>
# **IntlVerification**
> IntlVerification IntlVerification (IntlVerificationWritable intlVerificationWritable, string xLangOutput = null)

verifySingle

Verify an international (except US or US territories) address with a live API key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class IntlVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IntlVerificationsApi(config);
            var intlVerificationWritable = new IntlVerificationWritable(); // IntlVerificationWritable | 
            var xLangOutput = xLangOutput_example;  // string | * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English.  (optional) 

            try
            {
                // verifySingle
                IntlVerification result = apiInstance.IntlVerification(intlVerificationWritable, xLangOutput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntlVerificationsApi.IntlVerification: " + e.Message );
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
 **intlVerificationWritable** | [**IntlVerificationWritable**](IntlVerificationWritable.md)|  | 
 **xLangOutput** | **string**| * &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  | [optional] 

### Return type

[**IntlVerification**](IntlVerification.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an international verification object. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

