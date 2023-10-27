# lob.dotnet.Model.CreativeWritable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **Object** | Must either be an address ID or an inline object with correct address parameters. | 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 
**ResourceType** | **string** | Mailpiece type for the creative | 
**CampaignId** | **string** | Unique identifier prefixed with &#x60;cmp_&#x60;. | 
**Details** | **Object** | Either PostcardDetailsWritable or LetterDetailsWritable | [optional] 
**File** | **string** | PDF file containing the letter&#39;s formatting. Do not include for resource_type &#x3D; postcard. | [optional] 
**Front** | **string** | The artwork to use as the front of your postcard. Do not include for resource_type &#x3D; letter.  | [optional] 
**Back** | **string** | The artwork to use as the back of your postcard. Do not include for resource_type &#x3D; letter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

