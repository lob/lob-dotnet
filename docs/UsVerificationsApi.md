# lob.dotnet.Api.UsVerificationsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkUsVerifications**](UsVerificationsApi.md#bulkusverifications) | **POST** /bulk/us_verifications | verifyBulk
[**UsVerification**](UsVerificationsApi.md#usverification) | **POST** /us_verifications | verifySingle


<a name="bulkusverifications"></a>
# **BulkUsVerifications**
> UsVerifications BulkUsVerifications (MultipleComponentsList multipleComponentsList, string _case = null)

verifyBulk

Verify a list of US or US territory addresses with a live API key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BulkUsVerificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UsVerificationsApi(config);
            var multipleComponentsList = new MultipleComponentsList(); // MultipleComponentsList | 
            var _case = _case_example;  // string | Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. \"PO BOX\") and proper-cased (e.g. \"PO Box\"), respectively. (optional)  (default to upper)

            try
            {
                // verifyBulk
                UsVerifications result = apiInstance.BulkUsVerifications(multipleComponentsList, _case);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsVerificationsApi.BulkUsVerifications: " + e.Message );
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
 **multipleComponentsList** | [**MultipleComponentsList**](MultipleComponentsList.md)|  | 
 **_case** | **string**| Casing of the verified address. Possible values are &#x60;upper&#x60; and &#x60;proper&#x60; for uppercased (e.g. \&quot;PO BOX\&quot;) and proper-cased (e.g. \&quot;PO Box\&quot;), respectively. | [optional] [default to upper]

### Return type

[**UsVerifications**](UsVerifications.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of US verification objects. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usverification"></a>
# **UsVerification**
> UsVerification UsVerification (UsVerificationsWritable usVerificationsWritable, string _case = null)

verifySingle

Verify a US or US territory address with a live API key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class UsVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UsVerificationsApi(config);
            var usVerificationsWritable = new UsVerificationsWritable(); // UsVerificationsWritable | 
            var _case = _case_example;  // string | Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. \"PO BOX\") and proper-cased (e.g. \"PO Box\"), respectively. (optional)  (default to upper)

            try
            {
                // verifySingle
                UsVerification result = apiInstance.UsVerification(usVerificationsWritable, _case);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsVerificationsApi.UsVerification: " + e.Message );
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
 **usVerificationsWritable** | [**UsVerificationsWritable**](UsVerificationsWritable.md)|  | 
 **_case** | **string**| Casing of the verified address. Possible values are &#x60;upper&#x60; and &#x60;proper&#x60; for uppercased (e.g. \&quot;PO BOX\&quot;) and proper-cased (e.g. \&quot;PO Box\&quot;), respectively. | [optional] [default to upper]

### Return type

[**UsVerification**](UsVerification.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a US verification object. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

