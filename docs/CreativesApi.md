# lob.dotnet.Api.CreativesApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreativeCreate**](CreativesApi.md#creativecreate) | **POST** /creatives | create
[**CreativeRetrieve**](CreativesApi.md#creativeretrieve) | **GET** /creatives/{crv_id} | get
[**CreativeUpdate**](CreativesApi.md#creativeupdate) | **PATCH** /creatives/{crv_id} | update


<a name="creativecreate"></a>
# **CreativeCreate**
> CreativeResponse CreativeCreate (CreativeWritable creativeWritable, string xLangOutput = null)

create

Creates a new creative with the provided properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class CreativeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CreativesApi(config);
            var creativeWritable = new CreativeWritable(); // CreativeWritable | 
            var xLangOutput = xLangOutput_example;  // string | * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English.  (optional) 

            try
            {
                // create
                CreativeResponse result = apiInstance.CreativeCreate(creativeWritable, xLangOutput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreativesApi.CreativeCreate: " + e.Message );
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
 **creativeWritable** | [**CreativeWritable**](CreativeWritable.md)|  | 
 **xLangOutput** | **string**| * &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  | [optional] 

### Return type

[**CreativeResponse**](CreativeResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Creative created successfully |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creativeretrieve"></a>
# **CreativeRetrieve**
> CreativeResponse CreativeRetrieve (string crvId)

get

Retrieves the details of an existing creative. You need only supply the unique creative identifier that was returned upon creative creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class CreativeRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CreativesApi(config);
            var crvId = crvId_example;  // string | id of the creative

            try
            {
                // get
                CreativeResponse result = apiInstance.CreativeRetrieve(crvId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreativesApi.CreativeRetrieve: " + e.Message );
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
 **crvId** | **string**| id of the creative | 

### Return type

[**CreativeResponse**](CreativeResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a creative object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creativeupdate"></a>
# **CreativeUpdate**
> CreativeResponse CreativeUpdate (string crvId, CreativePatch creativePatch)

update

Update the details of an existing creative. You need only supply the unique identifier that was returned upon creative creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class CreativeUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CreativesApi(config);
            var crvId = crvId_example;  // string | id of the creative
            var creativePatch = new CreativePatch(); // CreativePatch | 

            try
            {
                // update
                CreativeResponse result = apiInstance.CreativeUpdate(crvId, creativePatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreativesApi.CreativeUpdate: " + e.Message );
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
 **crvId** | **string**| id of the creative | 
 **creativePatch** | [**CreativePatch**](CreativePatch.md)|  | 

### Return type

[**CreativeResponse**](CreativeResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a creative object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

