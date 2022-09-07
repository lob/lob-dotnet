# lob.dotnet.Api.CardOrdersApi

All URIs are relative to *https://api.lob.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](CardOrdersApi.md#create) | **POST** /cards/{card_id}/orders | create
[**get**](CardOrdersApi.md#get) | **GET** /cards/{card_id}/orders | get


<a name="create"></a>
# **create**
> CardOrder create (string cardId, CardOrderEditable cardOrderEditable)

create

Creates a new card order given information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class createExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CardOrdersApi(config);
            var cardId = cardId_example;  // string | The ID of the card to which the card orders belong.
            var cardOrderEditable = new CardOrderEditable(); // CardOrderEditable | 

            try
            {
                // create
                CardOrder result = apiInstance.create(cardId, cardOrderEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardOrdersApi.create: " + e.Message );
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
 **cardId** | **string**| The ID of the card to which the card orders belong. | 
 **cardOrderEditable** | [**CardOrderEditable**](CardOrderEditable.md)|  | 

### Return type

[**CardOrder**](CardOrder.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Card order created successfully |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **get**
> CardOrderList get (string cardId, int? limit = null, int? offset = null)

get

Retrieves the card orders associated with the given card id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lob.dotnet.Api;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace Example
{
    public class getExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lob.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CardOrdersApi(config);
            var cardId = cardId_example;  // string | The ID of the card to which the card orders belong.
            var limit = 56;  // int? | How many results to return. (optional)  (default to 10)
            var offset = 56;  // int? | An integer that designates the offset at which to begin returning results. Defaults to 0. (optional)  (default to 0)

            try
            {
                // get
                CardOrderList result = apiInstance.get(cardId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardOrdersApi.get: " + e.Message );
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
 **cardId** | **string**| The ID of the card to which the card orders belong. | 
 **limit** | **int?**| How many results to return. | [optional] [default to 10]
 **offset** | **int?**| An integer that designates the offset at which to begin returning results. Defaults to 0. | [optional] [default to 0]

### Return type

[**CardOrderList**](CardOrderList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the card orders associated with the given card id |  -  |
| **0** | Lob uses RESTful HTTP response codes to indicate success or failure of an API request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

