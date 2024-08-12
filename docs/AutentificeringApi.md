# Org.OpenAPITools.Api.AutentificeringApi

All URIs are relative to *https://api.cvr.dev*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TestAPIKey**](AutentificeringApi.md#testapikey) | **GET** /api/test/apikey | Test API key |

<a id="testapikey"></a>
# **TestAPIKey**
> TestAPIKey200Response TestAPIKey ()

Test API key

Dette endpoint lader dig teste om du medsender din API key korrekt. Dette endpoint tæller ikke med i dit månedlige forbrug.  Dine API keys er personlige og skal sendes med i alle requests. Din API key skal sættes i `Authorization`-headeren, som vist her:  `Authorization: Bearer din-api-key` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TestAPIKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutentificeringApi(config);

            try
            {
                // Test API key
                TestAPIKey200Response result = apiInstance.TestAPIKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutentificeringApi.TestAPIKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestAPIKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test API key
    ApiResponse<TestAPIKey200Response> response = apiInstance.TestAPIKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutentificeringApi.TestAPIKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TestAPIKey200Response**](TestAPIKey200Response.md)

### Authorization

[APIKey](../README.md#APIKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | API key er gyldig og medsendt på korrekt vis |  -  |
| **401** | API key er ugyldig eller bliver ikke medsendt korrekt |  -  |
| **500** | Noget uventet gik galt. Vi har fået en notifikation og arbejder på at udbedre problemet |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

