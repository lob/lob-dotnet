# lob.dotnet.Model.BuckslipOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | Value is type of resource. | 
**Id** | **string** | Unique identifier prefixed with &#x60;bo_&#x60;. | [optional] 
**BuckslipId** | **string** | Unique identifier prefixed with &#x60;bck_&#x60;. | [optional] 
**Status** | **string** | The status of the buckslip order. | [optional] 
**QuantityOrdered** | **decimal** | The quantity of buckslips ordered. | [optional] [default to 0M]
**UnitPrice** | **decimal** | The unit price for the buckslip order. | [optional] [default to 0M]
**Inventory** | **decimal** | The inventory of the buckslip order. | [optional] [default to 0M]
**CancelledReason** | **string** | The reason for cancellation. | [optional] 
**AvailabilityDate** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**ExpectedAvailabilityDate** | **DateTime** | The fixed deadline for the buckslips to be printed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

