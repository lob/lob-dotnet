# lob.dotnet.Model.UsVerification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;us_ver_&#x60;. | [optional] 
**Recipient** | **string** | The intended recipient, typically a person&#39;s or firm&#39;s name. | [optional] 
**PrimaryLine** | **string** | The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60;  | [optional] 
**SecondaryLine** | **string** | The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long.  | [optional] 
**Urbanization** | **string** | Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification.  | [optional] 
**LastLine** | **string** | Combination of the following applicable &#x60;components&#x60;: * City (&#x60;city&#x60;) * State (&#x60;state&#x60;) * ZIP code (&#x60;zip_code&#x60;) * ZIP+4 (&#x60;zip_code_plus_4&#x60;)  | [optional] 
**Deliverability** | **string** | Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS.  | [optional] 
**ValidAddress** | **bool** | This field indicates whether an address was found in a more comprehensive address dataset that includes sources from the USPS, open source mapping data, and our proprietary mail delivery data. This field can be interpreted as a representation of whether an address is a real location or not. Additionally a valid address may contradict the deliverability field since an address can be a real valid location but the USPS may not deliver to that address.  | [optional] 
**Components** | [**UsComponents**](UsComponents.md) |  | [optional] 
**DeliverabilityAnalysis** | [**DeliverabilityAnalysis**](DeliverabilityAnalysis.md) |  | [optional] 
**LobConfidenceScore** | [**LobConfidenceScore**](LobConfidenceScore.md) |  | [optional] 
**Object** | **string** |  | [optional] [default to ObjectEnum.UsVerification]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

