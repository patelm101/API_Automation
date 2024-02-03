using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_testing_Examples
{
    class Program
    {
        static async Task Main()
        {
            string apiUrl = "https://api.example.com/data";
            string result = await GetApiResponse(apiUrl);

            Console.WriteLine(result);
        }

        static async Task<string> GetApiResponse(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Ensure the response is successful before reading the content
                    response.EnsureSuccessStatusCode();

                    // Read and return the response content as a string
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException ex)
                {
                    // Handle exception or log error
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
