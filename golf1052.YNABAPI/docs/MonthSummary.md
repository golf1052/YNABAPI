# golf1052.YNABAPI.Model.MonthSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Month** | **DateTime?** |  | 
**Note** | **string** |  | [optional] 
**Income** | **long?** | The total amount of transactions categorized to &#39;Inflow: Ready to Assign&#39; in the month | 
**Budgeted** | **long?** | The total amount budgeted in the month | 
**Activity** | **long?** | The total amount of transactions in the month, excluding those categorized to &#39;Inflow: Ready to Assign&#39; | 
**ToBeBudgeted** | **long?** | The available amount for &#39;Ready to Assign&#39; | 
**AgeOfMoney** | **int?** | The Age of Money as of the month | [optional] 
**Deleted** | **bool?** | Whether or not the month has been deleted.  Deleted months will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

