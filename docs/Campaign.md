# lob.dotnet.Model.Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingGroupId** | **string** | Unique identifier prefixed with &#x60;bg_&#x60;. | [optional] 
**Name** | **string** | Name of the campaign. | 
**Description** | **string** | An internal description that identifies this resource. Must be no longer than 255 characters.  | [optional] 
**ScheduleType** | [**CmpScheduleType**](CmpScheduleType.md) |  | 
**TargetDeliveryDate** | **DateTime?** | If &#x60;schedule_type&#x60; is &#x60;target_delivery_date&#x60;, provide a targeted delivery date for mail pieces in this campaign. | [optional] 
**SendDate** | **DateTime?** | If &#x60;schedule_type&#x60; is &#x60;scheduled_send_date&#x60;, provide a date to send this campaign. | [optional] 
**CancelWindowCampaignMinutes** | **int?** | A window, in minutes, within which the campaign can be canceled. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. | [optional] 
**UseType** | [**CmpUseType**](CmpUseType.md) |  | 
**AutoCancelIfNcoa** | **bool** | Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA. | 
**Id** | **string** | Unique identifier prefixed with &#x60;cmp_&#x60;. | 
**AccountId** | **string** | Account ID that this campaign is associated with. | [optional] 
**IsDraft** | **bool** | Whether or not the campaign is still a draft. | [default to true]
**Creatives** | [**List&lt;CampaignCreative&gt;**](CampaignCreative.md) | An array of creatives that have been associated with this campaign. | 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | 
**DateModified** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was last modified. | 
**Deleted** | **bool** | Only returned if the resource has been successfully deleted. | [optional] 
**Object** | **string** | Value is resource type. | [default to ObjectEnum.Campaign]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

