using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;

namespace DZ.HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data;
            //using (HttpClient client = new HttpClient())
            //{
            //    string root = ConfigurationManager.AppSettings["apiRoot"];
            //    HttpResponseMessage response = client.PostAsync(root + "/api/test/index", null).Result;
            //    data = response.Content.ReadAsStringAsync().Result;
            //}
            //Console.WriteLine(data);

            string json = JsonConvert.SerializeObject(new
            {
                Name = "张三",
                Age = 20,
                Gender = "Male"
            });
            Console.WriteLine(json);

            Console.WriteLine("测试自动部署 2019/08/13");

            Console.ReadKey();
        }
    }
}
