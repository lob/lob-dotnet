# lob.dotnet.Api.TemplateVersionsApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTemplateVersion**](TemplateVersionsApi.md#createtemplateversion) | **POST** /templates/{tmpl_id}/versions | create
[**TemplateVersionDelete**](TemplateVersionsApi.md#templateversiondelete) | **DELETE** /templates/{tmpl_id}/versions/{vrsn_id} | delete
[**TemplateVersionRetrieve**](TemplateVersionsApi.md#templateversionretrieve) | **GET** /templates/{tmpl_id}/versions/{vrsn_id} | get
[**TemplateVersionUpdate**](TemplateVersionsApi.md#templateversionupdate) | **POST** /templates/{tmpl_id}/versions/{vrsn_id} | update
[**TemplateVersionsList**](TemplateVersionsApi.md#templateversionslist) | **GET** /templates/{tmpl_id}/versions | list


<a name="createtemplateversion"></a>
# **CreateTemplateVersion**
> TemplateVersion CreateTemplateVersion (string tmplId, TemplateVersionWritable templateVersionWritable)

create

Creates a new template version attached to the specified template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class CreateTemplateVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TemplateVersionsApi(config);
            var tmplId = tmplId_example;  // string | The ID of the template the new version will be attached to
            var templateVersionWritable = new TemplateVersionWritable(); // TemplateVersionWritable | 

            try
            {
                // create
                TemplateVersion result = apiInstance.CreateTemplateVersion(tmplId, templateVersionWritable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateVersionsApi.CreateTemplateVersion: " + e.Message );
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
 **tmplId** | **string**| The ID of the template the new version will be attached to | 
 **templateVersionWritable** | [**TemplateVersionWritable**](TemplateVersionWritable.md)|  | 

### Return type

[**TemplateVersion**](TemplateVersion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the template version with the given template and version ids. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateversiondelete"></a>
# **TemplateVersionDelete**
> TemplateVersionDeletion TemplateVersionDelete (string tmplId, string vrsnId)

delete

Permanently deletes a template version. A template's `published_version` can not be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class TemplateVersionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TemplateVersionsApi(config);
            var tmplId = tmplId_example;  // string | The ID of the template to which the version belongs.
            var vrsnId = vrsnId_example;  // string | id of the template_version

            try
            {
                // delete
                TemplateVersionDeletion result = apiInstance.TemplateVersionDelete(tmplId, vrsnId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateVersionsApi.TemplateVersionDelete: " + e.Message );
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
 **tmplId** | **string**| The ID of the template to which the version belongs. | 
 **vrsnId** | **string**| id of the template_version | 

### Return type

[**TemplateVersionDeletion**](TemplateVersionDeletion.md)

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

<a name="templateversionretrieve"></a>
# **TemplateVersionRetrieve**
> TemplateVersion TemplateVersionRetrieve (string tmplId, string vrsnId)

get

Retrieves the template version with the given template and version ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class TemplateVersionRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TemplateVersionsApi(config);
            var tmplId = tmplId_example;  // string | The ID of the template to which the version belongs.
            var vrsnId = vrsnId_example;  // string | id of the template_version

            try
            {
                // get
                TemplateVersion result = apiInstance.TemplateVersionRetrieve(tmplId, vrsnId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateVersionsApi.TemplateVersionRetrieve: " + e.Message );
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
 **tmplId** | **string**| The ID of the template to which the version belongs. | 
 **vrsnId** | **string**| id of the template_version | 

### Return type

[**TemplateVersion**](TemplateVersion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the template version with the given template and version ids. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateversionupdate"></a>
# **TemplateVersionUpdate**
> TemplateVersion TemplateVersionUpdate (string tmplId, string vrsnId, TemplateVersionUpdatable templateVersionUpdatable)

update

Updates the template version with the given template and version ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class TemplateVersionUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TemplateVersionsApi(config);
            var tmplId = tmplId_example;  // string | The ID of the template to which the version belongs.
            var vrsnId = vrsnId_example;  // string | id of the template_version
            var templateVersionUpdatable = new TemplateVersionUpdatable(); // TemplateVersionUpdatable | 

            try
            {
                // update
                TemplateVersion result = apiInstance.TemplateVersionUpdate(tmplId, vrsnId, templateVersionUpdatable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateVersionsApi.TemplateVersionUpdate: " + e.Message );
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
 **tmplId** | **string**| The ID of the template to which the version belongs. | 
 **vrsnId** | **string**| id of the template_version | 
 **templateVersionUpdatable** | [**TemplateVersionUpdatable**](TemplateVersionUpdatable.md)|  | 

### Return type

[**TemplateVersion**](TemplateVersion.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the template version with the given template and version ids. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateversionslist"></a>
# **TemplateVersionsList**
> TemplateVersionList TemplateVersionsList (string tmplId, int? limit = null, string before = null, string after = null, List<string> include = null, Dictionary<string, string> dateCreated = null)

list

Returns a list of template versions for the given template ID. The template versions are sorted by creation date, with the most recently created appearing first. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class TemplateVersionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TemplateVersionsApi(config);
            var tmplId = tmplId_example;  // string | The ID of the template associated with the retrieved versions
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var before = before_example;  // string | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.  (optional) 
            var after = after_example;  // string | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.  (optional) 
            var include = new List<string>(); // List<string> | Request that the response include the total count by specifying `include[]=total_count`.  (optional) 
            var dateCreated = new Dictionary<string, string>(); // Dictionary<string, string> | Filter by date created. (optional) 

            try
            {
                // list
                TemplateVersionList result = apiInstance.TemplateVersionsList(tmplId, limit, before, after, include, dateCreated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateVersionsApi.TemplateVersionsList: " + e.Message );
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
 **tmplId** | **string**| The ID of the template associated with the retrieved versions | 
 **limit** | **int?**| How many results to return. | [optional] [default to 10]
 **before** | **string**| A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the &#x60;previous_url&#x60; field in the return response.  | [optional] 
 **after** | **string**| A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the &#x60;next_url&#x60; field in the return response.  | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| Request that the response include the total count by specifying &#x60;include[]&#x3D;total_count&#x60;.  | [optional] 
 **dateCreated** | [**Dictionary&lt;string, string&gt;**](string.md)| Filter by date created. | [optional] 

### Return type

[**TemplateVersionList**](TemplateVersionList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A dictionary with a data property that contains an array of up to &#x60;limit&#x60; template versions. Each entry in the array is a separate template version object. The previous and next page of template versions can be retrieved by calling the endpoint contained in the &#x60;previous_url&#x60; and &#x60;next_url&#x60; fields in the API response respectively.&lt;br&gt;If no more template versions are available beyond the current set of returned results, the &#x60;next_url&#x60; field will be empty. |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

