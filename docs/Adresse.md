# Org.OpenAPITools.Model.Adresse
Beskrivelse af en fysisk adresse 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdresseId** | **string** | DAWA adresse id. Vil kun eksistere for danske adresser. Se https://dawadocs.dataforsyningen.dk/dok/api/adresse#opslag for mere information. Bonus information: DAWA id&#39;er er unikke for _den givne fysiske lokation_ og ændrer sig ikke, hvis eksempelvis vejen omdøbes eller bliver tilknyttet en ny kommune.  | [optional] 
**BogstavFra** | **string** |  | 
**BogstavTil** | **string** |  | 
**Bynavn** | **string** |  | 
**Conavn** | **string** |  | 
**Etage** | **string** |  | 
**Fritekst** | **string** |  | 
**HusnummerFra** | **int?** |  | 
**HusnummerTil** | **int?** |  | 
**Kommune** | [**AdresseKommune**](AdresseKommune.md) |  | 
**Landekode** | **string** |  | 
**Periode** | [**Periode**](Periode.md) |  | 
**Postboks** | **string** |  | 
**Postdistrikt** | **string** |  | 
**Postnummer** | **int?** |  | 
**Sidedoer** | **string** |  | 
**SidstOpdateret** | **string** | Seneste tidspunkt hvor dette objekt blev opdateret  | 
**SidstValideret** | **DateTime?** |  | [optional] 
**Vejkode** | **int?** |  | 
**Vejnavn** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

