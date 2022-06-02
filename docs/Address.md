# lob.dotnet.Model.Address

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;adr_&#x60;. | [optional] 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**Name** | **string** | name associated with address | [optional] 
**Company** | **string** | Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. | [optional] 
**Phone** | **string** | Must be no longer than 40 characters. | [optional] 
**Email** | **string** | Must be no longer than 100 characters. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 
**AddressLine1** | **string** |  | [optional] 
**AddressLine2** | **string** |  | [optional] 
**AddressCity** | **string** |  | [optional] 
**AddressState** | **string** | 2 letter state short-name code | [optional] 
**AddressZip** | **string** | Must follow the ZIP format of &#x60;12345&#x60; or ZIP+4 format of &#x60;12345-1234&#x60;.  | [optional] 
**AddressCountry** | [**CountryExtendedExpanded**](CountryExtendedExpanded.md) |  | [optional] 
**Object** | **string** |  | [optional] [default to ObjectEnum.Address]
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**RecipientMoved** | **bool?** | Only returned for accounts on certain &lt;a href&#x3D;\&quot;https://dashboard.lob.com/#/settings/editions\&quot;&gt;Print &amp;amp; Mail Editions&lt;/a&gt;. Value is &#x60;true&#x60; if the address was altered because the recipient filed for a &lt;a href&#x3D;\&quot;#ncoa\&quot;&gt;National Change of Address (NCOA)&lt;/a&gt;, &#x60;false&#x60; if the NCOA check was run but no altered address was found, and &#x60;null&#x60; if the NCOA check was not run. The NCOA check does not happen for non-US addresses, for non-deliverable US addresses, or for addresses created before the NCOA feature was added to your account.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

