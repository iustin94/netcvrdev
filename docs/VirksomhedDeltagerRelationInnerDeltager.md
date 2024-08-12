# Org.OpenAPITools.Model.VirksomhedDeltagerRelationInnerDeltager

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdresseHemmelig** | **bool?** |  | [optional] 
**AdresseHemmeligUndtagelse** | **bool?** |  | [optional] 
**AdresseOpdateringOphoert** | **bool?** |  | [optional] 
**Beliggenhedsadresse** | [**List&lt;Adresse&gt;**](Adresse.md) | Fysiske adresser, som oftest i Danmark  | [optional] 
**EnhedsNummer** | **long** | Et unikt id, der identificerer en given enhed i CVR. Enhedsnumre benyttes ofte til at indikere relationer mellem enheder. Dog benyttes CVR-numre og P-numre også  | 
**Enhedstype** | **string** | Typen af enhed, der er tale om. Kan være &#x60;ANDEN DELTAGER&#x60;, &#x60;PERSON&#x60;, &#x60;PRODUKTIONSENHED&#x60; og &#x60;VIRKSOMHED&#x60;  | 
**Forretningsnoegle** | **long?** |  | [optional] 
**Navne** | [**List&lt;Navn&gt;**](Navn.md) | Navne tilknyttet den givne enhed  | 
**Postadresse** | [**List&lt;Adresse&gt;**](Adresse.md) | Fysiske adresser, som oftest i Danmark  | [optional] 
**SidstIndlaest** | **DateTime?** | Seneste tidspunkt hvor dette objekt er blevet indlæst i Virks Elastic Search  | 
**SidstOpdateret** | **string** | Seneste tidspunkt hvor dette objekt blev opdateret  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

