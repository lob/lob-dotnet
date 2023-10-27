# lob.dotnet.Api.SelfMailersApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SelfMailerCreate**](SelfMailersApi.md#selfmailercreate) | **POST** /self_mailers | create
[**SelfMailerDelete**](SelfMailersApi.md#selfmailerdelete) | **DELETE** /self_mailers/{sfm_id} | delete
[**SelfMailerRetrieve**](SelfMailersApi.md#selfmailerretrieve) | **GET** /self_mailers/{sfm_id} | get
[**SelfMailersList**](SelfMailersApi.md#selfmailerslist) | **GET** /self_mailers | list


<a name="selfmailercreate"></a>
# **SelfMailerCreate**
> SelfMailer SelfMailerCreate (SelfMailerEditable selfMailerEditable, string idempotencyKey = null)

create

Creates a new self_mailer given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class SelfMailerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SelfMailersApi(config);
            var selfMailerEditable = new SelfMailerEditable(); // SelfMailerEditable | 
            var idempotencyKey = idempotencyKey_example;  // string | A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our [implementation guide](https://www.lob.com/guides#idempotent_request).  (optional) 

            try
            {
                // create
                SelfMailer result = apiInstance.SelfMailerCreate(selfMailerEditable, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelfMailersApi.SelfMailerCreate: " + e.Message );
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
 **selfMailerEditable** | [**SelfMailerEditable**](SelfMailerEditable.md)|  | 
 **idempotencyKey** | **string**| A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our [implementation guide](https://www.lob.com/guides#idempotent_request).  | [optional] 

### Return type

[**SelfMailer**](SelfMailer.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a self_mailer object |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfmailerdelete"></a>
# **SelfMailerDelete**
> SelfMailerDeletion SelfMailerDelete (string sfmId)

delete

Completely removes a self mailer from production. This can only be done if the self mailer's `send_date` has not yet passed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class SelfMailerDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SelfMailersApi(config);
            var sfmId = sfmId_example;  // string | id of the self_mailer

            try
            {
                // delete
                SelfMailerDeletion result = apiInstance.SelfMailerDelete(sfmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelfMailersApi.SelfMailerDelete: " + e.Message );
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
 **sfmId** | **string**| id of the self_mailer | 

### Return type

[**SelfMailerDeletion**](SelfMailerDeletion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted the card |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfmailerretrieve"></a>
# **SelfMailerRetrieve**
> SelfMailer SelfMailerRetrieve (string sfmId)

get

Retrieves the details of an existing self_mailer. You need only supply the unique self_mailer identifier that was returned upon self_mailer creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class SelfMailerRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SelfMailersApi(config);
            var sfmId = sfmId_example;  // string | id of the self_mailer

            try
            {
                // get
                SelfMailer result = apiInstance.SelfMailerRetrieve(sfmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelfMailersApi.SelfMailerRetrieve: " + e.Message );
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
 **sfmId** | **string**| id of the self_mailer | 

### Return type

[**SelfMailer**](SelfMailer.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a self_mailer object |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfmailerslist"></a>
# **SelfMailersList**
> SelfMailerList SelfMailersList (int? limit = null, string before = null, string after = null, List<string> include = null, Dictionary<string, DateTime> dateCreated = null, Dictionary<string, string> metadata = null, List<SelfMailerSize> size = null, bool? scheduled = null, Dictionary<string, string> sendDate = null, MailType? mailType = null, SortBy3 sortBy = null)

list

Returns a list of your self_mailers. The self_mailers are returned sorted by creation date, with the most recently created self_mailers appearing first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class SelfMailersListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SelfMailersApi(config);
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var before = before_example;  // string | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.  (optional) 
            var after = after_example;  // string | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.  (optional) 
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 
            var dateCreated = new Dictionary<string, DateTime>(); // Dictionary<string, DateTime> | Filter by date created. (optional) 
            var metadata = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by metadata key-value pair`. (optional) 
            var size = new List<SelfMailerSize>(); // List<SelfMailerSize> | The self mailer sizes to be returned. (optional) 
            var scheduled = true;  // bool? | * `true` - only return orders (past or future) where `send_date` is greater than `date_created` * `false` - only return orders where `send_date` is equal to `date_created`  (optional) 
            var sendDate = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date sent. (optional) 
            var mailType = ;  // MailType? | A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a [cheaper option](https://lob.com/pricing/print-mail#compare) which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States.  (optional) 
            var sortBy = new SortBy3(); // SortBy3 | Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both.  (optional) 

            try
            {
                // list
                SelfMailerList result = apiInstance.SelfMailersList(limit, before, after, include, dateCreated, metadata, size, scheduled, sendDate, mailType, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelfMailersApi.SelfMailersList: " + e.Message );
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
 **dateCreated** | [**Dictionary&lt;string, DateTime&gt;**](DateTime.md)| Filter by date created. | [optional] 
 **metadata** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by metadata key-value pair&#x60;. | [optional] 
 **size** | [**List&lt;SelfMailerSize&gt;**](SelfMailerSize.md)| The self mailer sizes to be returned. | [optional] 
 **scheduled** | **bool?**| * &#x60;true&#x60; - only return orders (past or future) where &#x60;send_date&#x60; is greater than &#x60;date_created&#x60; * &#x60;false&#x60; - only return orders where &#x60;send_date&#x60; is equal to &#x60;date_created&#x60;  | [optional] 
 **sendDate** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by date sent. | [optional] 
 **mailType** | **MailType?**| A string designating the mail postage type: * &#x60;usps_first_class&#x60; - (default) * &#x60;usps_standard&#x60; - a [cheaper option](https://lob.com/pricing/print-mail#compare) which is less predictable and takes longer to deliver. &#x60;usps_standard&#x60; cannot be used with &#x60;4x6&#x60; postcards or for any postcards sent outside of the United States.  | [optional] 
 **sortBy** | [**SortBy3**](SortBy3.md)| Sorts items by ascending or descending dates. Use either &#x60;date_created&#x60; or &#x60;send_date&#x60;, not both.  | [optional] 

### Return type

[**SelfMailerList**](SelfMailerList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A dictionary with a data property that contains an array of up to &#x60;limit&#x60; self_mailers. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

