# lob.dotnet.Api.autocompletesApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**autocomplete**](autocompletesApi.md#autocomplete) | **POST** /intl_autocompletions | autocomplete


<a name="autocomplete"></a>
# **autocomplete**
> autocompletes autocomplete (autocompletesWritable autocompletesWritable, string xLangOutput = null)

autocomplete

Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they'll need to be [verified](#operation/intl_verification).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class autocompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new autocompletesApi(config);
            var autocompletesWritable = new autocompletesWritable(); // autocompletesWritable | 
            var xLangOutput = xLangOutput_example;  // string | * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English.  (optional) 

            try
            {
                // autocomplete
                autocompletes result = apiInstance.autocomplete(autocompletesWritable, xLangOutput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling autocompletesApi.autocomplete: " + e.Message );
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
 **autocompletesWritable** | [**autocompletesWritable**](autocompletesWritable.md)|  | 
 **xLangOutput** | **string**| * &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  | [optional] 

### Return type

[**autocompletes**](autocompletes.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an international autocompletions object. |  * ratelimit-limit -  <br>  * ratelimit-remaining -  <br>  * ratelimit-reset -  <br>  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

