# Org.OpenAPITools.Api.RDataFraCVRApi

All URIs are relative to *https://api.cvr.dev*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCvrProduktionsenhed**](RDataFraCVRApi.md#getcvrproduktionsenhed) | **GET** /api/cvr/produktionsenhed | Data om Produktionsenheder |
| [**GetCvrVirksomhed**](RDataFraCVRApi.md#getcvrvirksomhed) | **GET** /api/cvr/virksomhed | Data om Virksomheder |

<a id="getcvrproduktionsenhed"></a>
# **GetCvrProduktionsenhed**
> List&lt;Produktionsenhed&gt; GetCvrProduktionsenhed (string? pNummer = null, string? adresse = null)

Data om Produktionsenheder

Dette endpoint returnerer alt data om en produktionsenhed, som den er i CVR. Dette dataformat er bestemt af Virk, ikke af cvr.dev.  ### Data Bemærk feltet `produktionsEnhedMetadata`, der indeholder en simplificeret opsummering af resten af data.  Det er meget ofte denne information, man ønsker at benytte.  ### Query parametre **OBS**: *Sendes begge query parametre samtidig, vil kun p_nummer blive brugt.* 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCvrProduktionsenhedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RDataFraCVRApi(config);
            var pNummer = 1004862579;  // string? | P-nummer på produktionsenheden, der søges efter  (optional) 
            var adresse = Nybrovej 410 2800;  // string? | Adresse på produktionsenheden, der søges efter  (optional) 

            try
            {
                // Data om Produktionsenheder
                List<Produktionsenhed> result = apiInstance.GetCvrProduktionsenhed(pNummer, adresse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RDataFraCVRApi.GetCvrProduktionsenhed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCvrProduktionsenhedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Data om Produktionsenheder
    ApiResponse<List<Produktionsenhed>> response = apiInstance.GetCvrProduktionsenhedWithHttpInfo(pNummer, adresse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RDataFraCVRApi.GetCvrProduktionsenhedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pNummer** | **string?** | P-nummer på produktionsenheden, der søges efter  | [optional]  |
| **adresse** | **string?** | Adresse på produktionsenheden, der søges efter  | [optional]  |

### Return type

[**List&lt;Produktionsenhed&gt;**](Produktionsenhed.md)

### Authorization

[APIKey](../README.md#APIKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liste af Produktionsenheder |  -  |
| **401** | API key er ugyldig eller bliver ikke medsendt korrekt |  -  |
| **402** | Din API key er ikke tilknyttet et aktivt abonnement. Log ind på din profil og påbegynd et abonnement |  -  |
| **429** | Du har sendt flere requests end dit abonnement tillader. Vent lidt med at sende flere |  -  |
| **500** | Noget uventet gik galt. Vi har fået en notifikation og arbejder på at udbedre problemet |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcvrvirksomhed"></a>
# **GetCvrVirksomhed**
> List&lt;Virksomhed&gt; GetCvrVirksomhed (string? cvrNummer = null, string? navn = null)

Data om Virksomheder

Dette endpoint returnerer alt data om en virksomhed, som den er i CVR. Dette dataformat er bestemt af Virk, ikke af cvr.dev.  ### Data Bemærk feltet `virksomhedMetadata`, der indeholder en simplificeret opsummering af resten af data.  Det er meget ofte denne information, man ønsker at benytte.  ### Query parametre **OBS**: *Sendes begge query parametre samtidig, vil kun cvr_nummer blive brugt.* 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCvrVirksomhedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RDataFraCVRApi(config);
            var cvrNummer = 10103940;  // string? | CVR-nummer på virksomheden, der søges efter  (optional) 
            var navn = Statsministeriet, Departementet;  // string? | Navn på virksomheden, der søges efter  (optional) 

            try
            {
                // Data om Virksomheder
                List<Virksomhed> result = apiInstance.GetCvrVirksomhed(cvrNummer, navn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RDataFraCVRApi.GetCvrVirksomhed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCvrVirksomhedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Data om Virksomheder
    ApiResponse<List<Virksomhed>> response = apiInstance.GetCvrVirksomhedWithHttpInfo(cvrNummer, navn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RDataFraCVRApi.GetCvrVirksomhedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cvrNummer** | **string?** | CVR-nummer på virksomheden, der søges efter  | [optional]  |
| **navn** | **string?** | Navn på virksomheden, der søges efter  | [optional]  |

### Return type

[**List&lt;Virksomhed&gt;**](Virksomhed.md)

### Authorization

[APIKey](../README.md#APIKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liste af Virksomheder |  -  |
| **401** | API key er ugyldig eller bliver ikke medsendt korrekt |  -  |
| **402** | Din API key er ikke tilknyttet et aktivt abonnement. Log ind på din profil og påbegynd et abonnement |  -  |
| **429** | Du har sendt flere requests end dit abonnement tillader. Vent lidt med at sende flere |  -  |
| **500** | Noget uventet gik galt. Vi har fået en notifikation og arbejder på at udbedre problemet |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

