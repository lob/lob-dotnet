# lob.dotnet.Api.BuckslipsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuckslipCreate**](BuckslipsApi.md#buckslipcreate) | **POST** /buckslips | create
[**BuckslipDelete**](BuckslipsApi.md#buckslipdelete) | **DELETE** /buckslips/{buckslip_id} | delete
[**BuckslipRetrieve**](BuckslipsApi.md#buckslipretrieve) | **GET** /buckslips/{buckslip_id} | get
[**BuckslipUpdate**](BuckslipsApi.md#buckslipupdate) | **PATCH** /buckslips/{buckslip_id} | update
[**BuckslipsList**](BuckslipsApi.md#buckslipslist) | **GET** /buckslips | List


<a name="buckslipcreate"></a>
# **BuckslipCreate**
> Buckslip BuckslipCreate (BuckslipEditable buckslipEditable, Object front = null)

create

Creates a new buckslip given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipsApi(config);
            var buckslipEditable = new BuckslipEditable(); // BuckslipEditable | 
            var front = new Object(); // Object | An optional file upload as either a byte array or file type.  (optional) 

            try
            {
                // create
                Buckslip result = apiInstance.BuckslipCreate(buckslipEditable, front);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipsApi.BuckslipCreate: " + e.Message );
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
 **buckslipEditable** | [**BuckslipEditable**](BuckslipEditable.md)|  | 
 **front** | [**Object**](Object.md)| An optional file upload as either a byte array or file type.  | [optional] 

### Return type

[**Buckslip**](Buckslip.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Buckslip created successfully |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buckslipdelete"></a>
# **BuckslipDelete**
> BuckslipDeletion BuckslipDelete (string buckslipId)

delete

Delete an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipsApi(config);
            var buckslipId = buckslipId_example;  // string | id of the buckslip

            try
            {
                // delete
                BuckslipDeletion result = apiInstance.BuckslipDelete(buckslipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipsApi.BuckslipDelete: " + e.Message );
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
 **buckslipId** | **string**| id of the buckslip | 

### Return type

[**BuckslipDeletion**](BuckslipDeletion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted the buckslip |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buckslipretrieve"></a>
# **BuckslipRetrieve**
> Buckslip BuckslipRetrieve (string buckslipId)

get

Retrieves the details of an existing buckslip. You need only supply the unique customer identifier that was returned upon buckslip creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipsApi(config);
            var buckslipId = buckslipId_example;  // string | id of the buckslip

            try
            {
                // get
                Buckslip result = apiInstance.BuckslipRetrieve(buckslipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipsApi.BuckslipRetrieve: " + e.Message );
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
 **buckslipId** | **string**| id of the buckslip | 

### Return type

[**Buckslip**](Buckslip.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a buckslip object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buckslipupdate"></a>
# **BuckslipUpdate**
> Buckslip BuckslipUpdate (string buckslipId, BuckslipUpdatable buckslipUpdatable)

update

Update the details of an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipsApi(config);
            var buckslipId = buckslipId_example;  // string | id of the buckslip
            var buckslipUpdatable = new BuckslipUpdatable(); // BuckslipUpdatable | 

            try
            {
                // update
                Buckslip result = apiInstance.BuckslipUpdate(buckslipId, buckslipUpdatable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipsApi.BuckslipUpdate: " + e.Message );
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
 **buckslipId** | **string**| id of the buckslip | 
 **buckslipUpdatable** | [**BuckslipUpdatable**](BuckslipUpdatable.md)|  | 

### Return type

[**Buckslip**](Buckslip.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a buckslip object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buckslipslist"></a>
# **BuckslipsList**
> BuckslipsList BuckslipsList (int? limit = null, string before = null, string after = null, List<string> include = null)

List

Returns a list of your buckslips. The buckslips are returned sorted by creation date, with the most recently created buckslips appearing first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BuckslipsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BuckslipsApi(config);
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var before = before_example;  // string | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.  (optional) 
            var after = after_example;  // string | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.  (optional) 
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 

            try
            {
                // List
                BuckslipsList result = apiInstance.BuckslipsList(limit, before, after, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuckslipsApi.BuckslipsList: " + e.Message );
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
 **limit** | **int?**| How many results to return. | [optional] [default to 10]
 **before** | **string**| A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the &#x60;previous_url&#x60; field in the return response.  | [optional] 
 **after** | **string**| A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the &#x60;next_url&#x60; field in the return response.  | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| Request that the response include the total count by specifying &#x60;include[]&#x3D;total_count&#x60;.  | [optional] 

### Return type

[**BuckslipsList**](BuckslipsList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | description: Returns a list of buckslip objects |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

