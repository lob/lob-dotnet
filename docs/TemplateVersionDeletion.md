# lob.dotnet.Model.TemplateVersionDeletion
Lob uses RESTful HTTP response codes to indicate success or failure of an API request. In general, 2xx indicates success, 4xx indicate an input error, and 5xx indicates an error on Lob's end.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;vrsn_&#x60;. | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | Value is type of resource. | [optional] [default to ObjectEnum.deleted]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

