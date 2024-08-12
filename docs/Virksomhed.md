# Org.OpenAPITools.Model.Virksomhed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aarsbeskaeftigelse** | [**List&lt;Aarsbeskaeftigelse&gt;**](Aarsbeskaeftigelse.md) | Information vedr. antallet af tilknyttede årsværk og ansatte for et givent år  | 
**Attributter** | [**List&lt;Attribut&gt;**](Attribut.md) | Værdier, der er tilknyttet en entitet. Det kan være næsten hvad som helst; kontaktoplysninger, adresser, numeriske værdier, selskabers formål mv. Betydningen af de forskellige attributter bør kunne tydes fra konteksten  | 
**Beliggenhedsadresse** | [**List&lt;Adresse&gt;**](Adresse.md) | Fysiske adresser, som oftest i Danmark  | 
**Bibranche1** | [**List&lt;Branche&gt;**](Branche.md) | Information om eksisterende branchekoder kan findes på: https://erst.virk.dk/branchekode/kategori/indexKategori  | 
**Bibranche2** | [**List&lt;Branche&gt;**](Branche.md) | Information om eksisterende branchekoder kan findes på: https://erst.virk.dk/branchekode/kategori/indexKategori  | 
**Bibranche3** | [**List&lt;Branche&gt;**](Branche.md) | Information om eksisterende branchekoder kan findes på: https://erst.virk.dk/branchekode/kategori/indexKategori  | 
**Binavne** | [**List&lt;Navn&gt;**](Navn.md) | Navne tilknyttet den givne enhed  | 
**BrancheAnsvarskode** | **long?** | Værdier som Danmarks Statistik kan anføre på virksomheder, der falder ind under forskellige interessekategorier  | 
**CvrNummer** | **long** | Det offentligt benyttede id, der unikt identificerer en virksomhed  | 
**DataAdgang** | **int** | Beskriver hvorvidt enheden bliver replikeret gennem myndighedskanaler til SKAT og Danmarks Statistik  | 
**DeltagerRelation** | [**List&lt;VirksomhedDeltagerRelationInner&gt;**](VirksomhedDeltagerRelationInner.md) | Beskriver relationer som virksomheden har  | 
**ElektroniskPost** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) | Kontaktoplysninger. Vær opmærksom på at disse ligger under for kravet om reklamebeskyttelse. [Se afsnittet om reklamebeskyttelse](/#tag/Reklamebeskyttelse)  | 
**EnhedsNummer** | **long** | Et unikt id, der identificerer en given enhed i CVR. Enhedsnumre benyttes ofte til at indikere relationer mellem enheder. Dog benyttes CVR-numre og P-numre også  | 
**Enhedstype** | **string** | Enhedstypen bør altid være VIRKSOMHED for virksomheder  | 
**FejlBeskrivelse** | **string** |  | 
**FejlRegistreret** | **bool** | Er sat hvis virksomheden er indlæst grundet en systemfejl hos Virk  | 
**FejlVedIndlaesning** | **bool** | Er sat hvis der under indlæsning i Virk&#39;s indeks opstod en fejl  | 
**Fusioner** | [**List&lt;Fusion&gt;**](Fusion.md) |  | 
**Hjemmeside** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) | Kontaktoplysninger. Vær opmærksom på at disse ligger under for kravet om reklamebeskyttelse. [Se afsnittet om reklamebeskyttelse](/#tag/Reklamebeskyttelse)  | 
**Hovedbranche** | [**List&lt;Branche&gt;**](Branche.md) | Information om eksisterende branchekoder kan findes på: https://erst.virk.dk/branchekode/kategori/indexKategori  | 
**Kvartalsbeskaeftigelse** | [**List&lt;Kvartalsbeskaeftigelse&gt;**](Kvartalsbeskaeftigelse.md) | Information vedr. antallet af tilknyttede årsværk og ansatte for et givent kvartal  | 
**Livsforloeb** | [**List&lt;Livsforloeb&gt;**](Livsforloeb.md) |  | 
**Maanedsbeskaeftigelse** | [**List&lt;Maanedsbeskaeftigelse&gt;**](Maanedsbeskaeftigelse.md) | Information vedr. antallet af tilknyttede årsværk og ansatte for en given måned  | 
**NaermesteFremtidigeDato** | **string** |  | 
**Navne** | [**List&lt;Navn&gt;**](Navn.md) | Navne tilknyttet den givne enhed  | 
**ObligatoriskEmail** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) | Kontaktoplysninger. Vær opmærksom på at disse ligger under for kravet om reklamebeskyttelse. [Se afsnittet om reklamebeskyttelse](/#tag/Reklamebeskyttelse)  | 
**Penheder** | [**List&lt;VirksomhedPenhederInner&gt;**](VirksomhedPenhederInner.md) | Indeholder information om virksomhedens tilknyttede produktionsenheder  | 
**Postadresse** | [**List&lt;Adresse&gt;**](Adresse.md) | Fysiske adresser, som oftest i Danmark  | 
**RegNummer** | [**List&lt;RegNummer&gt;**](RegNummer.md) |  | 
**Reklamebeskyttet** | **bool** | Hvorvidt enheden er reklamebeskyttet. Det er ulovligt lave reklamehenvendelser til virksomheder hvor denne værdi er sat. Læs mere: https://datacvr.virk.dk/artikel/vilkaar-og-betingelser#accordion-5-button  | 
**SamtId** | **long** |  | 
**SekundaertTelefaxNummer** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) |  | 
**SekundaertTelefonNummer** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) |  | 
**SidstIndlaest** | **DateTime?** | Seneste tidspunkt hvor dette objekt er blevet indlæst i Virks Elastic Search  | 
**SidstOpdateret** | **string** | Seneste tidspunkt hvor dette objekt blev opdateret  | 
**Spaltninger** | [**List&lt;Spaltning&gt;**](Spaltning.md) |  | 
**Status** | [**List&lt;VirksomhedStatusInner&gt;**](VirksomhedStatusInner.md) |  | 
**TelefaxNummer** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) |  | 
**TelefonNummer** | [**List&lt;Kontaktoplysning&gt;**](Kontaktoplysning.md) |  | 
**VirkningsAktoer** | **string** |  | 
**VirksomhedMetadata** | [**VirksomhedVirksomhedMetadata**](VirksomhedVirksomhedMetadata.md) |  | 
**Virksomhedsstatus** | [**List&lt;VirksomhedVirksomhedsstatusInner&gt;**](VirksomhedVirksomhedsstatusInner.md) | Beskriver en virksomheds selskabsretlige status, der kan være eksempelvis: \&quot;UNDER FRIVILLIG LIKVIDATION\&quot;, \&quot;OPLØST EFTER FUSION\&quot;, \&quot;SLETTET\&quot;, \&quot;UNDER KONKURS\&quot;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

