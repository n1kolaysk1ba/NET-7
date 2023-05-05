using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp5
{
    public class ApiMethods
    {
        private readonly ApiClient _client;

        public ApiMethods(ApiClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<ExchangeRates>> GetExchangeRates()
        {
            try
            {
                using var client = _client.GetClient();
                var response = await client.GetAsync("latest?base=USD");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ExchangeRates>(json);

                return new ApiResponse<ExchangeRates>()
                {
                    Message = "OK",
                    StatusCode = response.StatusCode,
                    Data = new List<ExchangeRates>() { data }
                };
            }
            catch (Exception e)
            {
                return new ApiResponse<ExchangeRates>()
                {
                    Message = e.Message,
                    StatusCode = HttpStatusCode.InternalServerError,
                    Data = null
                };
            }
        }
    }
}