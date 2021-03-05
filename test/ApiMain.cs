using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;    
using System.Net;    
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace test
{
    public class ApiMain
    {
        public ApiMain()
        {
        }

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