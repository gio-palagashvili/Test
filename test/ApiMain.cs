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
        public class FileClasss
        {
            public static string FileWriter(string text,string fileName)
            {
                var file = $"C:/Users/Gio/Documents/c#/test/test/{fileName}.txt";
                File.WriteAllText(file, text); 
                return null;
            }
            public static string FileReader(string filePath)
            {
                using var sr = new StreamReader(filePath);
                string line;
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }

                return null;
            }
        }
    }
    
}