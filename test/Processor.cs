using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace test
{
    public class Processor
    {
        
        public static async Task<string> LoadUser(int number = 0)
        {
            var url = number > 0 ? $"https://jsonplaceholder.typicode.com/todos/{number}" : $"https://jsonplaceholder.typicode.com/todos/1";
            
            using var responseMessage = await ApiHelper.ApiClient.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var message = await responseMessage.Content.ReadAsStringAsync();
                return message;
            }
            Console.WriteLine("error");
            throw new Exception(responseMessage.ReasonPhrase);
            
        } 
    }
}