# lob.dotnet.Model.AddressDomestic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The building number, street name, street suffix, and any street directionals. For US addresses, the max length is 64 characters. | [optional] 
**AddressLine2** | **string** | The suite or apartment number of the recipient address, if applicable. For US addresses, the max length is 64 characters. | [optional] 
**AddressCity** | **string** |  | [optional] 
**AddressState** | **string** |  | [optional] 
**AddressZip** | **string** | Optional postal code. For US addresses, must be either 5 or 9 digits. | [optional] 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**Name** | **string** | Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. Must be no longer than 40 characters. If both &#x60;name&#x60; and &#x60;company&#x60; are provided, they will be printed on two separate lines above the rest of the address.  | [optional] 
**Company** | **string** | Either &#x60;name&#x60; or &#x60;company&#x60; is required, you may also add both. | [optional] 
**Phone** | **string** | Must be no longer than 40 characters. | [optional] 
**Email** | **string** | Must be no longer than 100 characters. | [optional] 
**AddressCountry** | **string** | The country associated with this address. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

