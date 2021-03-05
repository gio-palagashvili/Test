using System;
using System.Net.Http;
using System.IO;

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
        public class File
        {
            public static string FileWriter()
            {
                var dummy = new string[] {"begone", "tt"};
                using var sw = new StreamWriter("names.txt");
                foreach (var s in dummy) {
                    sw.WriteLine(s);
                }
                return null;
            }
            public static string FileReader()
            {
                using var sr = new StreamReader("C:/Users/Gio/Documents/c#/test/test/dummy.txt");
                string line;
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }

                return null;
            }
    
        }
    }
    
}