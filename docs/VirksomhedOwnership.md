# Org.OpenAPITools.Model.VirksomhedOwnership
Ejerskabsrelation mellem en enhed (person eller virksomhed) og en virksomhed. Enheden ejer virksomheden. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EjerEnhedsnummer** | **long** | Ejerens enhedsnummer | [optional] 
**EjerNavn** | **string** | Ejerens navn | [optional] 
**EjerCvrNummer** | **long?** | Ejerens CVR-nummer, hvis enheden er en virksomhed. Vil være null for enheder, der ikke er virksomheder | [optional] 
**EjerEnhedstype** | **string** | Ejerens enhedstype: VIRKSOMHED, PERSON eller ANDEN_DELTAGER | [optional] 
**Ejerforhold** | **string** | Ejerforhold: &#39;Reel ejer&#39; eller &#39;Legal ejer&#39; | [optional] 
**VirksomhedEnhedsnummer** | **int** | Virksomhedens enhedsnummer | [optional] 
**VirksomhedNavn** | **string** | Virksomhedens navn | [optional] 
**VirksomhedCvrNummer** | **long** | Virksomhedens CVR nummer | [optional] 
**Virksomhedsform** | **string** | Virksomhedens virksomhedsform, e.g. APS, A/S | [optional] 
**Ejerandel** | **string** | Andel af ejerskab, angivet i intervallet [0;1] | [optional] 
**EjerandelGyldigFra** | **DateTime** | Dato hvor nyeste ejerskab startede | [optional] 
**EjerandelGyldigTil** | **DateTime?** | Dato hvor nyeste ejerskab sluttede. Vil være null ved igangværende ejerskab | [optional] 
**Stemmeret** | **string** | Andel af stemmerettigheder, angivet i intervallet [0;1] | [optional] 
**StemmeretGyldigFra** | **DateTime** | Dato hvor nyeste stemmerettigheder startede | [optional] 
**StemmeretGyldigTil** | **DateTime?** | Dato hvor stemmerettigheder sluttede. Vil være null ved igangværende stemmerettigheder | [optional] 
**Distance** | **int** | Ejerskabsdistancen mellem enheden, der blev slået op, og ejerskabet af denne virksomhed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

