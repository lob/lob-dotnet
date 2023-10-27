# lob.dotnet.Model.Export

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;ex_&#x60;. | 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the export was created | 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the export was last modified | 
**Deleted** | **bool** | Returns as &#x60;true&#x60; if the resource has been successfully deleted. | 
**S3Url** | **string** | The URL for the generated export file. | [optional] 
**State** | **string** | The state of the export file, which can be &#x60;in_progress&#x60;, &#x60;failed&#x60; or &#x60;succeeded&#x60;. | 
**Type** | **string** | The export file type, which can be &#x60;all&#x60;, &#x60;failures&#x60; or &#x60;successes&#x60;. | 
**UploadId** | **string** | Unique identifier prefixed with &#x60;upl_&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

