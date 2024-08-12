using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.cvr.dev";
            // Configure API key authorization: APIKey
            config.ApiKey.Add("Authorization", "Your API Key");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AutentificeringApi(config);

            try
            {
                // Test API key
                var result = apiInstance.TestAPIKey();
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutentificeringApi.TestAPIKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}