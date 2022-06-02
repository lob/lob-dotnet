# lob.dotnet.Model.Events

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier prefixed with &#x60;evt_&#x60;. | [optional] 
**Body** | **Object** | The body of the associated resource as they were at the time of the event, i.e. the [postcard object](#operation/postcard_retrieve), [the letter object](#operation/letter_retrieve), [the check object](#operation/check_retrieve), [the address object](#operation/address_retrieve), or [the bank account object](#operation/bank_account_retrieve). For &#x60;.deleted&#x60; events, the body matches the response for the corresponding delete endpoint for that resource (e.g. the [postcard delete response](#operation/postcard_delete)). | [optional] 
**ReferenceId** | **string** | Unique identifier of the related resource for the event. | [optional] 
**EventType** | [**EventType**](EventType.md) |  | [optional] 
**DateCreated** | **DateTime** | A timestamp in ISO 8601 format of the date the resource was created. | [optional] 
**Object** | **string** | Value is resource type. | [optional] [default to ObjectEnum.Event]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

