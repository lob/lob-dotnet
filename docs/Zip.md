# lob.dotnet.Model.Zip

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ZipCode** | **string** | A 5-digit ZIP code. | [optional] 
**Id** | **string** | Unique identifier prefixed with &#x60;us_zip_&#x60;. | [optional] 
**Cities** | [**List&lt;ZipLookupCity&gt;**](ZipLookupCity.md) | An array of city objects containing valid cities for the &#x60;zip_code&#x60;. Multiple cities will be returned if more than one city is associated with the input ZIP code.  | [optional] 
**ZipCodeType** | [**ZipCodeType**](ZipCodeType.md) |  | [optional] 
**Object** | **string** |  | [optional] [default to ObjectEnum.UsZipLookup]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

