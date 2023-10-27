# lob.dotnet.Model.LetterDetailsWritable
Properties that the letters in your Creative should have.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressPlacement** | **string** | Specifies the location of the address information that will show through the double-window envelope.  | [optional] [default to AddressPlacementEnum.TopFirstPage]
**Cards** | **List&lt;string&gt;** | A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information. | 
**Color** | **bool** | Set this key to &#x60;true&#x60; if you would like to print in color. Set to &#x60;false&#x60; if you would like to print in black and white. | 
**DoubleSided** | **bool** | Set this attribute to &#x60;true&#x60; for double sided printing, or &#x60;false&#x60; for for single sided printing. Defaults to &#x60;true&#x60;. | [optional] [default to true]
**ExtraService** | **string** | Add an extra service to your letter. | [optional] 
**MailType** | [**MailType**](MailType.md) |  | [optional] 
**ReturnEnvelope** | **bool** |  | [optional] [default to false]
**CustomEnvelope** | **string** | Accepts an envelope ID for any customized envelope with available inventory. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

