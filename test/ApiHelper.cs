using System;   
using System.Net.Http;
using System.Net.Http.Headers;

namespace test
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient {BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/")};
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        } 
        
    }
}