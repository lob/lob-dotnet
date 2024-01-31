# lob.dotnet.Model.UsVerificationOrError
A model used to represent an entry in a result list where the entry can either be a us_verification or an Error. The SDK will perform necessary casting into the correct corresponding type. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;us_ver_&#x60;. | [optional] 
**Recipient** | **string** | The intended recipient, typically a person&#39;s or firm&#39;s name. | [optional] 
**PrimaryLine** | **string** | The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60;  | [optional] 
**SecondaryLine** | **string** | The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long.  | [optional] 
**Urbanization** | **string** | Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification.  | [optional] 
**LastLine** | **string** |  | [optional] 
**Deliverability** | **string** |  | [optional] 
**Components** | [**UsComponents**](UsComponents.md) |  | [optional] 
**DeliverabilityAnalysis** | [**DeliverabilityAnalysis**](DeliverabilityAnalysis.md) |  | [optional] 
**LobConfidenceScore** | [**LobConfidenceScore**](LobConfidenceScore.md) |  | [optional] 
**Object** | **string** |  | [optional] [default to ObjectEnum.UsVerification]
**TransientId** | **string** | ID that is returned in the response body for the verification  | [optional] 
**Error** | [**BulkError**](BulkError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

