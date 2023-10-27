# lob.dotnet.Model.Buckslip

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;bck_&#x60;. | 
**AutoReorder** | **bool** | True if the buckslips should be auto-reordered. | [default to false]
**ReorderQuantity** | **int?** | The number of buckslips to be reordered. | 
**ThresholdAmount** | **int** | The threshold amount of the buckslip | [default to 0]
**Url** | **string** | The signed link for the buckslip. | 
**RawUrl** | **string** | The raw URL of the buckslip. | 
**FrontOriginalUrl** | **string** | The original URL of the front template. | 
**BackOriginalUrl** | **string** | The original URL of the back template. | 
**Thumbnails** | [**List&lt;Thumbnail&gt;**](Thumbnail.md) |  | 
**AvailableQuantity** | **decimal** | The available quantity of buckslips. | [default to 0M]
**AllocatedQuantity** | **decimal** | The allocated quantity of buckslips. | [default to 0M]
**OnhandQuantity** | **decimal** | The onhand quantity of buckslips. | [default to 0M]
**PendingQuantity** | **decimal** | The pending quantity of buckslips. | [default to 0M]
**ProjectedQuantity** | **decimal** | The sum of pending and onhand quantities of buckslips. | [default to 0M]
**BuckslipOrders** | [**List&lt;BuckslipOrder&gt;**](BuckslipOrder.md) | An array of buckslip orders that are associated with the buckslip. | 
**Stock** | **string** |  | 
**Weight** | **string** |  | 
**Finish** | **string** |  | 
**Status** | **string** |  | 
**Object** | **string** | object | [default to ObjectEnum.Buckslip]
**Description** | **string** | Description of the buckslip. | 
**Size** | **string** | The size of the buckslip | [optional] [default to SizeEnum._875x375]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

