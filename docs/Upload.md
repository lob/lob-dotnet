# lob.dotnet.Model.Upload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;upl_&#x60;. | 
**AccountId** | **string** | Account ID that made the request | 
**Mode** | **string** | The environment in which the mailpieces were created. Today, will only be &#x60;live&#x60;. | 
**CampaignId** | **string** | Campaign ID associated with the upload | 
**FailuresUrl** | **string** | Url where your campaign mailpiece failures can be retrieved | [optional] 
**OriginalFilename** | **string** | Filename of the upload | [optional] 
**State** | [**UploadState**](UploadState.md) |  | 
**TotalMailpieces** | **int** | Total number of recipients for the campaign | 
**FailedMailpieces** | **int** | Number of mailpieces that failed to create | 
**ValidatedMailpieces** | **int** | Number of mailpieces that were successfully created | 
**BytesProcessed** | **int** | Number of bytes processed in your CSV | 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the upload was created | 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the upload was last modified | 
**RequiredAddressColumnMapping** | [**RequiredAddressColumnMapping**](RequiredAddressColumnMapping.md) |  | 
**OptionalAddressColumnMapping** | [**OptionalAddressColumnMapping**](OptionalAddressColumnMapping.md) |  | 
**Metadata** | [**UploadsMetadata**](UploadsMetadata.md) |  | 
**MergeVariableColumnMapping** | **Object** | The mapping of column headers in your file to the merge variables present in your creative. See our &lt;a href&#x3D;\&quot;https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Campaign Audience Guide&lt;/a&gt; for additional details. &lt;br /&gt;If a merge variable has the same \&quot;name\&quot; as a \&quot;key\&quot; in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the &#x60;requiredAddressColumnMapping&#x60; or &#x60;optionalAddressColumnMapping&#x60; objects. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

