# lob.dotnet.Model.TemplateVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;vrsn_&#x60;. | [optional] 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**Html** | **string** | An HTML string of less than 100,000 characters to be used as the &#x60;published_version&#x60; of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details: - [Postcards](#operation/postcard_create) - &#x60;front&#x60; and &#x60;back&#x60; - [Self Mailers](#operation/self_mailer_create) - &#x60;inside&#x60; and &#x60;outside&#x60; - [Letters](#operation/letter_create) - &#x60;file&#x60; - [Checks](#operation/check_create) - &#x60;check_bottom&#x60; and &#x60;attachment&#x60; - [Cards](#operation/card_create) - &#x60;front&#x60; and &#x60;back&#x60;  If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a &#x60;{{#users}}&#x60; opening tag without the corresponding closing tag &#x60;{{/users}}&#x60;.  | [optional] 
**Engine** | [**EngineHtml**](EngineHtml.md) |  | [optional] 
**SuggestJsonEditor** | **bool** | Used by frontend, true if the template uses advanced features.  | [optional] 
**MergeVariables** | **Object** | Used by frontend, an object representing the keys of every merge variable present in the template. It has one key named &#39;keys&#39;, and its value is an array of strings.  | [optional] 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | Value is resource type. | [optional] [default to ObjectEnum.Version]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

