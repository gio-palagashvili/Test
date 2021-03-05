using System;
using System.Linq;    
using System.Net;    
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;    

namespace test
{
    public class ApiMain
    {
        public ApiMain()
        {
        }

        public static string J()
        {
            using var client = new HttpClient {BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/1")};
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("api/Values").Result;
            var products = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(products);
            return "ss";
        }
    }
}