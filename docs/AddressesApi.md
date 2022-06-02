# lob.dotnet.Api.AddressesApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressCreate**](AddressesApi.md#addresscreate) | **POST** /addresses | create
[**AddressDelete**](AddressesApi.md#addressdelete) | **DELETE** /addresses/{adr_id} | delete
[**AddressRetrieve**](AddressesApi.md#addressretrieve) | **GET** /addresses/{adr_id} | get
[**AddressesList**](AddressesApi.md#addresseslist) | **GET** /addresses | list


<a name="addresscreate"></a>
# **AddressCreate**
> Address AddressCreate (AddressEditable addressEditable)

create

Creates a new address given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class AddressCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AddressesApi(config);
            var addressEditable = new AddressEditable(); // AddressEditable | 

            try
            {
                // create
                Address result = apiInstance.AddressCreate(addressEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.AddressCreate: " + e.Message );
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
 **addressEditable** | [**AddressEditable**](AddressEditable.md)|  | 

### Return type

[**Address**](Address.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Echos the writable fields of a newly created address object. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressdelete"></a>
# **AddressDelete**
> AddressDeletion AddressDelete (string adrId)

delete

Deletes the details of an existing address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class AddressDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AddressesApi(config);
            var adrId = adrId_example;  // string | id of the address

            try
            {
                // delete
                AddressDeletion result = apiInstance.AddressDelete(adrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.AddressDelete: " + e.Message );
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
 **adrId** | **string**| id of the address | 

### Return type

[**AddressDeletion**](AddressDeletion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressretrieve"></a>
# **AddressRetrieve**
> Address AddressRetrieve (string adrId)

get

Retrieves the details of an existing address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class AddressRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AddressesApi(config);
            var adrId = adrId_example;  // string | id of the address

            try
            {
                // get
                Address result = apiInstance.AddressRetrieve(adrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.AddressRetrieve: " + e.Message );
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
 **adrId** | **string**| id of the address | 

### Return type

[**Address**](Address.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an address object if a valid identifier was provided. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addresseslist"></a>
# **AddressesList**
> AddressList AddressesList (int? limit = null, string before = null, string after = null, List<string> include = null, Dictionary<string, string> dateCreated = null, Dictionary<string, string> metadata = null)

list

Returns a list of your addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class AddressesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AddressesApi(config);
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var before = before_example;  // string | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.  (optional) 
            var after = after_example;  // string | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.  (optional) 
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 
            var dateCreated = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date created. (optional) 
            var metadata = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by metadata key-value pair`. (optional) 

            try
            {
                // list
                AddressList result = apiInstance.AddressesList(limit, before, after, include, dateCreated, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.AddressesList: " + e.Message );
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
 **dateCreated** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by date created. | [optional] 
 **metadata** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by metadata key-value pair&#x60;. | [optional] 

### Return type

[**AddressList**](AddressList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A dictionary with a data property that contains an array of up to &#x60;limit&#x60; addresses. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

