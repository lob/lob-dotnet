# lob.dotnet.Model.IntlSuggestions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryNumberRange** | **string** | The primary number range of the address that identifies a building at street level.  | 
**PrimaryLine** | **string** | The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60; (primary number &amp; secondary information may be missing or inaccurate): * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60;  | 
**City** | **string** |  | 
**State** | **string** | The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state.  | 
**Country** | [**CountryExtended**](CountryExtended.md) |  | 
**ZipCode** | **string** | A 5-digit zip code. Left empty if a test key is used. | 
**Object** | **string** | Value is resource type. | [optional] [default to ObjectEnum.IntlAutocompletion]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

