using System;
using System.Configuration;
using System.Net.Http;

namespace DZ.HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            using (HttpClient client = new HttpClient())
            {
                string root = ConfigurationManager.AppSettings["apiRoot"];
                HttpResponseMessage response = client.PostAsync(root + "/api/test/index", null).Result;
                data = response.Content.ReadAsStringAsync().Result;
            }
            Console.WriteLine(data);

            Console.ReadKey();
        }
    }
}
