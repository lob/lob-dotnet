# lob.dotnet.Model.UsAutocompletionsWritable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressPrefix** | **string** | Only accepts numbers and street names in an alphanumeric format.  | 
**City** | **string** | An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations.  | [optional] 
**State** | **string** | An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations.  | [optional] 
**ZipCode** | **string** | An optional ZIP Code input used to filter suggestions. Matches partial entries.  | [optional] 
**GeoIpSort** | **bool** | If &#x60;true&#x60;, sort suggestions by proximity to the IP set in the &#x60;X-Forwarded-For&#x60; header.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

