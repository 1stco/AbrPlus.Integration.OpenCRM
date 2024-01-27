# CustomerBalance Event

Get the details of the invoice creation in AloVoip.

**URL** : `/identity/balance`

**Method** : `GET`

**Auth required** : `true`


## Data Constraints
With the following parameters you can send your request:

|Parameter|Type|Mandatory|Description|
|-|-|-|-| 
|CustomerRequest | |Yes|  یک درخواست که شامل CustomerNo:شماره مشتری and CustomerId:شناسه منحصر به فرد مشتری است|



## Success Response
If successful, you will receive back this response:

**Code** : `200 OK`

```json
{
    "Balance": ""
}

```
With the following parameters:

|Parameter|Type|Mandatory|Description|
|-|-|-|-| 
|Balance|? |? | ? |
## Error Response

**Condition** : 
**Code** : `400 BAD REQUEST`










