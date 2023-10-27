# lob.dotnet.Model.BankAccountWritable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**RoutingNumber** | **string** | Must be a [valid US routing number](https://www.frbservices.org/index.html). | 
**AccountNumber** | **string** |  | 
**AccountType** | [**BankTypeEnum**](BankTypeEnum.md) |  | 
**Signatory** | **string** | The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the [Dashboard](https://dashboard.lob.com/#/login). | 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

