# lob.dotnet.Model.CardOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;co_&#x60;. | [optional] 
**CardId** | **string** | Unique identifier prefixed with &#x60;card_&#x60;. | [optional] 
**Status** | **string** | The status of the card order. | [optional] 
**Inventory** | **decimal** | The inventory of the card order. | [optional] [default to 0M]
**QuantityOrdered** | **decimal** | The quantity of cards ordered | [optional] [default to 0M]
**UnitPrice** | **decimal** | The unit price for the card order. | [optional] [default to 0M]
**CancelledReason** | **string** | The reason for cancellation. | [optional] 
**AvailabilityDate** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**ExpectedAvailabilityDate** | **DateTime** | The fixed deadline for the cards to be printed. | [optional] 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | Value is type of resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

