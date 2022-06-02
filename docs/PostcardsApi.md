# lob.dotnet.Api.PostcardsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostcardCreate**](PostcardsApi.md#postcardcreate) | **POST** /postcards | create
[**PostcardDelete**](PostcardsApi.md#postcarddelete) | **DELETE** /postcards/{psc_id} | cancel
[**PostcardRetrieve**](PostcardsApi.md#postcardretrieve) | **GET** /postcards/{psc_id} | get
[**PostcardsList**](PostcardsApi.md#postcardslist) | **GET** /postcards | list


<a name="postcardcreate"></a>
# **PostcardCreate**
> Postcard PostcardCreate (PostcardEditable postcardEditable, string idempotencyKey = null)

create

Creates a new postcard given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class PostcardCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PostcardsApi(config);
            var postcardEditable = new PostcardEditable(); // PostcardEditable | 
            var idempotencyKey = idempotencyKey_example;  // string | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our [implementation guide](https://www.lob.com/guides#idempotent_request).  (optional) 

            try
            {
                // create
                Postcard result = apiInstance.PostcardCreate(postcardEditable, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostcardsApi.PostcardCreate: " + e.Message );
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
 **postcardEditable** | [**PostcardEditable**](PostcardEditable.md)|  | 
 **idempotencyKey** | **string**| A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our [implementation guide](https://www.lob.com/guides#idempotent_request).  | [optional] 

### Return type

[**Postcard**](Postcard.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a postcard object |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcarddelete"></a>
# **PostcardDelete**
> PostcardDeletion PostcardDelete (string pscId)

cancel

Completely removes a postcard from production. This can only be done if the postcard has a `send_date` and the `send_date` has not yet passed. If the postcard is successfully canceled, you will not be charged for it. Read more on [cancellation windows](#section/Cancellation-Windows) and [scheduling](#section/Scheduled-Mailings). Scheduling and cancellation is a premium feature. Upgrade to the appropriate [Print & Mail Edition](https://dashboard.lob.com/#/settings/editions) to gain access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class PostcardDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PostcardsApi(config);
            var pscId = pscId_example;  // string | id of the postcard

            try
            {
                // cancel
                PostcardDeletion result = apiInstance.PostcardDelete(pscId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostcardsApi.PostcardDelete: " + e.Message );
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
 **pscId** | **string**| id of the postcard | 

### Return type

[**PostcardDeletion**](PostcardDeletion.md)

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

<a name="postcardretrieve"></a>
# **PostcardRetrieve**
> Postcard PostcardRetrieve (string pscId)

get

Retrieves the details of an existing postcard. You need only supply the unique customer identifier that was returned upon postcard creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class PostcardRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PostcardsApi(config);
            var pscId = pscId_example;  // string | id of the postcard

            try
            {
                // get
                Postcard result = apiInstance.PostcardRetrieve(pscId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostcardsApi.PostcardRetrieve: " + e.Message );
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
 **pscId** | **string**| id of the postcard | 

### Return type

[**Postcard**](Postcard.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a postcard object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardslist"></a>
# **PostcardsList**
> PostcardList PostcardsList (int? limit = null, string before = null, string after = null, List<string> include = null, Dictionary<string, string> dateCreated = null, Dictionary<string, string> metadata = null, PostcardSize? size = null, bool? scheduled = null, Dictionary<string, string> sendDate = null, MailType? mailType = null, SortBy5 sortBy = null)

list

Returns a list of your postcards. The addresses are returned sorted by creation date, with the most recently created addresses appearing first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class PostcardsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PostcardsApi(config);
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var before = before_example;  // string | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.  (optional) 
            var after = after_example;  // string | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.  (optional) 
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 
            var dateCreated = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date created. (optional) 
            var metadata = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by metadata key-value pair`. (optional) 
            var size = ;  // PostcardSize? | Specifies the size of the postcard. Only `4x6` postcards can be sent to international destinations. (optional) 
            var scheduled = true;  // bool? | * `true` - only return orders (past or future) where `send_date` is greater than `date_created` * `false` - only return orders where `send_date` is equal to `date_created`  (optional) 
            var sendDate = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date sent. (optional) 
            var mailType = ;  // MailType? | A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a [cheaper option](https://lob.com/pricing/print-mail#compare) which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States.  (optional) 
            var sortBy = new SortBy5(); // SortBy5 | Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both.  (optional) 

            try
            {
                // list
                PostcardList result = apiInstance.PostcardsList(limit, before, after, include, dateCreated, metadata, size, scheduled, sendDate, mailType, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostcardsApi.PostcardsList: " + e.Message );
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
 **size** | **PostcardSize?**| Specifies the size of the postcard. Only &#x60;4x6&#x60; postcards can be sent to international destinations. | [optional] 
 **scheduled** | **bool?**| * &#x60;true&#x60; - only return orders (past or future) where &#x60;send_date&#x60; is greater than &#x60;date_created&#x60; * &#x60;false&#x60; - only return orders where &#x60;send_date&#x60; is equal to &#x60;date_created&#x60;  | [optional] 
 **sendDate** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by date sent. | [optional] 
 **mailType** | **MailType?**| A string designating the mail postage type: * &#x60;usps_first_class&#x60; - (default) * &#x60;usps_standard&#x60; - a [cheaper option](https://lob.com/pricing/print-mail#compare) which is less predictable and takes longer to deliver. &#x60;usps_standard&#x60; cannot be used with &#x60;4x6&#x60; postcards or for any postcards sent outside of the United States.  | [optional] 
 **sortBy** | [**SortBy5**](SortBy5.md)| Sorts items by ascending or descending dates. Use either &#x60;date_created&#x60; or &#x60;send_date&#x60;, not both.  | [optional] 

### Return type

[**PostcardList**](PostcardList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A dictionary with a data property that contains an array of up to &#x60;limit&#x60; postcards. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

