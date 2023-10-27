# lob.dotnet.Api.BuckslipOrdersApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuckslipOrderCreate**](BuckslipOrdersApi.md#buckslipordercreate) | **POST** /buckslips/{buckslip_id}/orders | create
[**BuckslipOrdersRetrieve**](BuckslipOrdersApi.md#buckslipordersretrieve) | **GET** /buckslips/{buckslip_id}/orders | get


<a name="buckslipordercreate"></a>
# **BuckslipOrderCreate**
> BuckslipOrder BuckslipOrderCreate (string buckslipId, BuckslipOrderEditable buckslipOrderEditable)

create

Creates a new buckslip order given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipOrderCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipOrdersApi(config);
            var buckslipId = buckslipId_example;  // string | The ID of the buckslip to which the buckslip orders belong.
            var buckslipOrderEditable = new BuckslipOrderEditable(); // BuckslipOrderEditable | 

            try
            {
                // create
                BuckslipOrder result = apiInstance.BuckslipOrderCreate(buckslipId, buckslipOrderEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipOrdersApi.BuckslipOrderCreate: " + e.Message );
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
 **buckslipId** | **string**| The ID of the buckslip to which the buckslip orders belong. | 
 **buckslipOrderEditable** | [**BuckslipOrderEditable**](BuckslipOrderEditable.md)|  | 

### Return type

[**BuckslipOrder**](BuckslipOrder.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Buckslip order created successfully |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buckslipordersretrieve"></a>
# **BuckslipOrdersRetrieve**
> BuckslipOrdersList BuckslipOrdersRetrieve (string buckslipId, int? limit = null, int? offset = null)

get

Retrieves the buckslip orders associated with the given buckslip id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipOrdersRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipOrdersApi(config);
            var buckslipId = buckslipId_example;  // string | The ID of the buckslip to which the buckslip orders belong.
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var offset = 56;  // int? | An integer that designates the offset at which to begin returning results. Defaults to 0. (optional)  (default to 0)

            try
            {
                // get
                BuckslipOrdersList result = apiInstance.BuckslipOrdersRetrieve(buckslipId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipOrdersApi.BuckslipOrdersRetrieve: " + e.Message );
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
 **buckslipId** | **string**| The ID of the buckslip to which the buckslip orders belong. | 
 **limit** | **int?**| How many results to return. | [optional] [default to 10]
 **offset** | **int?**| An integer that designates the offset at which to begin returning results. Defaults to 0. | [optional] [default to 0]

### Return type

[**BuckslipOrdersList**](BuckslipOrdersList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the buckslip orders associated with the given buckslip id |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

