# lob.dotnet.Model.CreativeResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;crv_&#x60;. | [optional] 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**From** | **Object** | Must either be an address ID or an inline object with correct address parameters. | [optional] 
**ResourceType** | **string** | Mailpiece type for the creative | [optional] 
**Details** | **Object** | Either PostcardDetailsReturned or LetterDetailsReturned | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 
**TemplatePreviewUrls** | **Object** | Preview URLs associated with a creative&#39;s artwork asset(s) if the creative uses HTML templates as assets. | [optional] 
**TemplatePreviews** | **List&lt;Object&gt;** | A list of template preview objects if the creative uses HTML template(s) as artwork asset(s). | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Campaigns** | [**List&lt;Campaign&gt;**](Campaign.md) | Array of campaigns associated with the creative ID | [optional] 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | [optional] 
**Object** | **string** | Value is resource type. | [optional] [default to ObjectEnum.Creative]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

