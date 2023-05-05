using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp5
{
    public class ApiClient
    {
        private const string BaseUrl = "https://api.apilayer.com/exchangerates_data/live?base=USD&symbols=EUR,GBP";

        private readonly HttpClient _client;

        public ApiClient(string apiKey)
        {
            _client = new HttpClient();
            _client.BaseAddress = new System.Uri(BaseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "ApiClient");
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public HttpClient GetClient()
        {
            return _client;
        }
    }
}