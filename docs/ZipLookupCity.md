# lob.dotnet.Model.ZipLookupCity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**City** | **string** |  | [optional] 
**State** | **string** | The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state.  | [optional] 
**County** | **string** | County name of the address city. | [optional] 
**CountyFips** | **string** | A 5-digit [FIPS county code](https://en.wikipedia.org/wiki/FIPS_county_code) which uniquely identifies &#x60;components[county]&#x60;. It consists of a 2-digit state code and a 3-digit county code.  | [optional] 
**Preferred** | **bool** | Indicates whether or not the city is the [USPS default city](https://en.wikipedia.org/wiki/ZIP_Code#ZIP_Codes_and_previous_zoning_lines) (preferred city) of a ZIP code. There is only one preferred city per ZIP code, which will always be in position 0 in the array of cities.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

