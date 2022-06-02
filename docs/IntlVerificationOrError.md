# lob.dotnet.Model.IntlVerificationOrError
A model used to represent an entry in a result list where the entry can either be a intl_verification or an Error. The SDK will perform necessary casting into the correct corresponding type. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;intl_ver_&#x60;. | [optional] 
**Recipient** | **string** | The intended recipient, typically a person&#39;s or firm&#39;s name. | [optional] 
**PrimaryLine** | **string** |  | [optional] 
**SecondaryLine** | **string** | The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long.  | [optional] 
**LastLine** | **string** |  | [optional] 
**Country** | **string** |  | [optional] 
**Coverage** | **string** |  | [optional] 
**Deliverability** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**Components** | [**IntlComponents**](IntlComponents.md) |  | [optional] 
**Object** | **string** |  | [optional] [default to ObjectEnum.IntlVerification]
**Error** | [**BulkError**](BulkError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

