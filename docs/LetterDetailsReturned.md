# lob.dotnet.Model.LetterDetailsReturned
Properties that the letters in your Creative should have.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Color** | **bool** | Set this key to &#x60;true&#x60; if you would like to print in color, false for black and white. | 
**Cards** | **List&lt;string&gt;** | A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information. | 
**AddressPlacement** | **string** | Specifies the location of the address information that will show through the double-window envelope.  | [optional] [default to AddressPlacementEnum.TopFirstPage]
**CustomEnvelope** | [**CustomEnvelopeReturned**](CustomEnvelopeReturned.md) |  | [optional] 
**DoubleSided** | **bool** | Set this attribute to &#x60;true&#x60; for double sided printing,  &#x60;false&#x60; for for single sided printing. | [optional] [default to true]
**ExtraService** | **string** | Add an extra service to your letter. | [optional] 
**MailType** | [**MailType**](MailType.md) |  | [optional] 
**ReturnEnvelope** | **Object** |  | [optional] 
**Bleed** | **bool** | Allows for letter bleed. Enabled only with specific feature flags. | [optional] [default to false]
**FileOriginalUrl** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

