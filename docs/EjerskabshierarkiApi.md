# Org.OpenAPITools.Api.EjerskabshierarkiApi

All URIs are relative to *https://api.cvr.dev*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCvrDevVirksomhedDatterselskaber**](EjerskabshierarkiApi.md#getcvrdevvirksomheddatterselskaber) | **GET** /api/cvrdev/virksomhed/datterselskaber | Data om virksomheds datterselskaber |
| [**GetCvrDevVirksomhedEjere**](EjerskabshierarkiApi.md#getcvrdevvirksomhedejere) | **GET** /api/cvrdev/virksomhed/ejere | Data om virksomheds ejere |

<a id="getcvrdevvirksomheddatterselskaber"></a>
# **GetCvrDevVirksomhedDatterselskaber**
> List&lt;VirksomhedOwnership&gt; GetCvrDevVirksomhedDatterselskaber (string? cvrNummer = null, string? enhedsnummer = null)

Data om virksomheds datterselskaber

Dette endpoint returnerer hierarkiet af alle datterselskaber som enheden (person eller virksomhed) står noteret som ejer for i CVR-registret. Denne data inkluderer enhedens omtrentlige ejerskab og stemmerettigheder, som det er angivet i CVR.  ### Ejerskab og stemmeret udgør ikke altid 100% Den danske lovgivning gør, at det ikke altid er muligt at se ejerne af en virksomhed. Eksempelvis siger [Selskabslovens § 55](https://www.retsinformation.dk/eli/lta/2019/763#id806e59ff-9afb-4104-8249-2acf02cbaabc), at det kun er ejere med en kapitalandel eller stemmeret over 5%, der skal offentliggøres.  Der er andre tilfælde, hvor eksempelvis en virksomheds ledelse er noteret som ejere, hvor ejerskabet ikke fremgår direkte af CVRs data.  ### Query parametre **OBS**: *Sendes begge query parametre samtidig, vil kun enhedsnummer blive brugt.* 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCvrDevVirksomhedDatterselskaberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EjerskabshierarkiApi(config);
            var cvrNummer = 10582989;  // string? | CVR-nummer på virksomheden, hvis datterselskaber ønskes  (optional) 
            var enhedsnummer = 2337773;  // string? | Enhedsnummer på enheden (virksomhed eller person), hvis datterselskaber ønskes  (optional) 

            try
            {
                // Data om virksomheds datterselskaber
                List<VirksomhedOwnership> result = apiInstance.GetCvrDevVirksomhedDatterselskaber(cvrNummer, enhedsnummer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EjerskabshierarkiApi.GetCvrDevVirksomhedDatterselskaber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCvrDevVirksomhedDatterselskaberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Data om virksomheds datterselskaber
    ApiResponse<List<VirksomhedOwnership>> response = apiInstance.GetCvrDevVirksomhedDatterselskaberWithHttpInfo(cvrNummer, enhedsnummer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EjerskabshierarkiApi.GetCvrDevVirksomhedDatterselskaberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cvrNummer** | **string?** | CVR-nummer på virksomheden, hvis datterselskaber ønskes  | [optional]  |
| **enhedsnummer** | **string?** | Enhedsnummer på enheden (virksomhed eller person), hvis datterselskaber ønskes  | [optional]  |

### Return type

[**List&lt;VirksomhedOwnership&gt;**](VirksomhedOwnership.md)

### Authorization

[APIKey](../README.md#APIKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liste af virksomheder som ejes af den pågældende enhed |  -  |
| **401** | API key er ugyldig eller bliver ikke medsendt korrekt |  -  |
| **402** | Din API key er ikke tilknyttet et aktivt abonnement. Log ind på din profil og påbegynd et abonnement |  -  |
| **403** | Dette endpoint er ikke inkluderet i dit abonnement |  -  |
| **429** | Du har sendt flere requests end dit abonnement tillader. Vent lidt med at sende flere |  -  |
| **500** | Noget uventet gik galt. Vi har fået en notifikation og arbejder på at udbedre problemet |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcvrdevvirksomhedejere"></a>
# **GetCvrDevVirksomhedEjere**
> List&lt;VirksomhedOwnership&gt; GetCvrDevVirksomhedEjere (string? cvrNummer = null, string? enhedsnummer = null)

Data om virksomheds ejere

Dette endpoint returnerer hierarkiet af alle enheder der, direkte eller indirekte, er noteret som ejere af den givne virksomhed i CVR-registret. Denne data inkluderer enhedens omtrentlige ejerskab og stemmerettigheder, som det er angivet i CVR.  ### Ejerskab og stemmeret udgør ikke altid 100% Den danske lovgivning gør, at det ikke altid er muligt at se ejerne af en virksomhed. Eksempelvis siger [Selskabslovens § 55](https://www.retsinformation.dk/eli/lta/2019/763#id806e59ff-9afb-4104-8249-2acf02cbaabc), at det kun er ejere med en kapitalandel eller stemmeret over 5%, der skal offentliggøres.  Der er andre tilfælde, hvor eksempelvis en virksomheds ledelse er noteret som ejere, hvor ejerskabet ikke fremgår direkte af CVRs data.  ### Query parametre **OBS**: *Sendes begge query parametre samtidig, vil kun enhedsnummer blive brugt.* 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCvrDevVirksomhedEjereExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EjerskabshierarkiApi(config);
            var cvrNummer = 10582989;  // string? | CVR-nummer på virksomheden, hvis ejerhierarki ønskes  (optional) 
            var enhedsnummer = 2337773;  // string? | Enhedsnummer på virksomheden, hvis ejerhierarki ønskes  (optional) 

            try
            {
                // Data om virksomheds ejere
                List<VirksomhedOwnership> result = apiInstance.GetCvrDevVirksomhedEjere(cvrNummer, enhedsnummer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EjerskabshierarkiApi.GetCvrDevVirksomhedEjere: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCvrDevVirksomhedEjereWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Data om virksomheds ejere
    ApiResponse<List<VirksomhedOwnership>> response = apiInstance.GetCvrDevVirksomhedEjereWithHttpInfo(cvrNummer, enhedsnummer);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EjerskabshierarkiApi.GetCvrDevVirksomhedEjereWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cvrNummer** | **string?** | CVR-nummer på virksomheden, hvis ejerhierarki ønskes  | [optional]  |
| **enhedsnummer** | **string?** | Enhedsnummer på virksomheden, hvis ejerhierarki ønskes  | [optional]  |

### Return type

[**List&lt;VirksomhedOwnership&gt;**](VirksomhedOwnership.md)

### Authorization

[APIKey](../README.md#APIKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liste af enheder der, direkte eller indirekte, ejer den pågældende virksomhed |  -  |
| **401** | API key er ugyldig eller bliver ikke medsendt korrekt |  -  |
| **402** | Din API key er ikke tilknyttet et aktivt abonnement. Log ind på din profil og påbegynd et abonnement |  -  |
| **403** | Dette endpoint er ikke inkluderet i dit abonnement |  -  |
| **429** | Du har sendt flere requests end dit abonnement tillader. Vent lidt med at sende flere |  -  |
| **500** | Noget uventet gik galt. Vi har fået en notifikation og arbejder på at udbedre problemet |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

