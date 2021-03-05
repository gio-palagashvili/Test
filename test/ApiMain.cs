using System;
using System.Net.Http;

namespace test
{
    public static class ApiMain
    {
        public static string J()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos")
            };
            using var response = client.GetAsync("/todos/").Result;
            var data = response.Content.ReadAsStringAsync().Result;            
            return data;
        }

    }
}