# lob.dotnet.Api.BillingGroupsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingGroupCreate**](BillingGroupsApi.md#billinggroupcreate) | **POST** /billing_groups | create
[**BillingGroupRetrieve**](BillingGroupsApi.md#billinggroupretrieve) | **GET** /billing_groups/{bg_id} | get
[**BillingGroupUpdate**](BillingGroupsApi.md#billinggroupupdate) | **POST** /billing_groups/{bg_id} | update
[**BillingGroupsList**](BillingGroupsApi.md#billinggroupslist) | **GET** /billing_groups | list


<a name="billinggroupcreate"></a>
# **BillingGroupCreate**
> BillingGroup BillingGroupCreate (BillingGroupEditable billingGroupEditable)

create

Creates a new billing_group with the provided properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BillingGroupCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BillingGroupsApi(config);
            var billingGroupEditable = new BillingGroupEditable(); // BillingGroupEditable | 

            try
            {
                // create
                BillingGroup result = apiInstance.BillingGroupCreate(billingGroupEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingGroupsApi.BillingGroupCreate: " + e.Message );
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
 **billingGroupEditable** | [**BillingGroupEditable**](BillingGroupEditable.md)|  | 

### Return type

[**BillingGroup**](BillingGroup.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a billing group object |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggroupretrieve"></a>
# **BillingGroupRetrieve**
> BillingGroup BillingGroupRetrieve (string bgId)

get

Retrieves the details of an existing billing_group. You need only supply the unique billing_group identifier that was returned upon billing_group creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BillingGroupRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BillingGroupsApi(config);
            var bgId = bgId_example;  // string | id of the billing_group

            try
            {
                // get
                BillingGroup result = apiInstance.BillingGroupRetrieve(bgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingGroupsApi.BillingGroupRetrieve: " + e.Message );
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
 **bgId** | **string**| id of the billing_group | 

### Return type

[**BillingGroup**](BillingGroup.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a billing_group object. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggroupupdate"></a>
# **BillingGroupUpdate**
> BillingGroup BillingGroupUpdate (string bgId, BillingGroupEditable billingGroupEditable)

update

Updates all editable attributes of the billing_group with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BillingGroupUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BillingGroupsApi(config);
            var bgId = bgId_example;  // string | id of the billing_group
            var billingGroupEditable = new BillingGroupEditable(); // BillingGroupEditable | 

            try
            {
                // update
                BillingGroup result = apiInstance.BillingGroupUpdate(bgId, billingGroupEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingGroupsApi.BillingGroupUpdate: " + e.Message );
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
 **bgId** | **string**| id of the billing_group | 
 **billingGroupEditable** | [**BillingGroupEditable**](BillingGroupEditable.md)|  | 

### Return type

[**BillingGroup**](BillingGroup.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a billing group object |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggroupslist"></a>
# **BillingGroupsList**
> BillingGroupList BillingGroupsList (int? limit = null, int? offset = null, List<string> include = null, Dictionary<string, DateTime> dateCreated = null, Dictionary<string, string> dateModified = null, SortByDateModified sortByDateModified = null)

list

Returns a list of your billing_groups. The billing_groups are returned sorted by creation date, with the most recently created billing_groups appearing first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class BillingGroupsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BillingGroupsApi(config);
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var offset = 56;  // int? | An integer that designates the offset at which to begin returning results. Defaults to 0. (optional)  (default to 0)
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 
            var dateCreated = new Dictionary<string, DateTime>(); // Dictionary<string, DateTime> | Filter by date created. (optional) 
            var dateModified = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date modified. (optional) 
            var sortByDateModified = new SortByDateModified(); // SortByDateModified | Sorts items by ascending or descending dates. Use either `date_created` or `date_modfied`, not both.  (optional) 

            try
            {
                // list
                BillingGroupList result = apiInstance.BillingGroupsList(limit, offset, include, dateCreated, dateModified, sortByDateModified);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingGroupsApi.BillingGroupsList: " + e.Message );
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
 **offset** | **int?**| An integer that designates the offset at which to begin returning results. Defaults to 0. | [optional] [default to 0]
 **include** | [**List&lt;string&gt;**](string.md)| Request that the response include the total count by specifying &#x60;include[]&#x3D;total_count&#x60;.  | [optional] 
 **dateCreated** | [**Dictionary&lt;string, DateTime&gt;**](DateTime.md)| Filter by date created. | [optional] 
 **dateModified** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by date modified. | [optional] 
 **sortByDateModified** | [**SortByDateModified**](SortByDateModified.md)| Sorts items by ascending or descending dates. Use either &#x60;date_created&#x60; or &#x60;date_modfied&#x60;, not both.  | [optional] 

### Return type

[**BillingGroupList**](BillingGroupList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of billing_groups. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

