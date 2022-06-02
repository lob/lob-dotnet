# lob.dotnet.Model.Card

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;card_&#x60;. | [optional] 
**Url** | **string** | The signed link for the card. | [optional] 
**AutoReorder** | **bool** | True if the cards should be auto-reordered. | [optional] [default to false]
**ReorderQuantity** | **int?** | The number of cards to be reordered. | [optional] 
**RawUrl** | **string** | The raw URL of the card. | [optional] 
**FrontOriginalUrl** | **string** | The original URL of the front template. | [optional] 
**BackOriginalUrl** | **string** | The original URL of the back template. | [optional] 
**Thumbnails** | [**List&lt;Thumbnail&gt;**](Thumbnail.md) |  | [optional] 
**AvailableQuantity** | **int** | The available quantity of cards. | [optional] [default to 0]
**PendingQuantity** | **int** | The pending quantity of cards. | [optional] [default to 0]
**Status** | **string** |  | [optional] 
**Orientation** | **string** | The orientation of the card. | [optional] [default to OrientationEnum.Horizontal]
**ThresholdAmount** | **int** | The threshold amount of the card | [optional] [default to 0]
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | [optional] 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | object | [optional] [default to ObjectEnum.Card]
**Description** | **string** | Description of the card. | [optional] 
**Size** | **string** | The size of the card | [optional] [default to SizeEnum._2125x3375]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

