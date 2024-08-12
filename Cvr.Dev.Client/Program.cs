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
            config.ApiKey.Add("Authorization", "cvr.dev_8fdb7539213bf2085b5ebaba886814c3");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AutentificeringApi(config);

            try
            {
                // var pathParams = new Dictionary<string, string>()
                // {
                //     {"cvr_number", "38495224"},
                //     {"navn", "Quadsat"}
                // };
                // var result = apiInstance.Client.Get<Virksomhed>("https://api.cvr.dev/api/cvr/virksomhed", new RequestOptions(){PathParameters = pathParams}, config);
                var client = new RDataFraCVRApi(config); // TestAPIKey |
                List<Virksomhed> result = client.GetCvrVirksomhed("38495224", "Quadsat");
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