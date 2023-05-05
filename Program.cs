using System;
using ConsoleApp5;

namespace ConsoleApp5
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var client = new ApiClient("AYTHJpRsBlMl6W85AcZW6RcfSP7WDuZg");
            var apiMethods = new ApiMethods(client);

            try
            {
                var response = await apiMethods.GetExchangeRates();
                Console.WriteLine($"USD rate: {response.Data[0].Rates.USD}");
                Console.WriteLine($"EUR rate: {response.Data[0].Rates.EUR}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}