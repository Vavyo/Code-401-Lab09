using LINQinManhattan.Classes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace LINQinManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            JsonTests();
        }
        public static void JsonTests()
        {
            
            FeatureCollection collection = JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText(@"E:\Delta V\401\Code-401-Lab09\data.json"));
            var results =
                from c in collection.features
                select c.properties.neighborhood;
            foreach(string i in results)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(results.Count());
            results =
                from c in results
                where c != ""
                select c;
            foreach (string i in results)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(results.Count());

        }
    }
}
