using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lesson19_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string apiUrl = "https://catfact.ninja/fact";

            Console.WriteLine("Fact about cats\n");

            while (true)
            {
                HttpClient client = new();
                var result = await client.GetStringAsync(apiUrl);
                var catFact = JsonConvert.DeserializeObject<CatFact>(result);

                Console.WriteLine(catFact.Fact + "\n");
               
                Console.WriteLine("---If you wish to continue, please enter");
                Console.ReadLine();
            }

        }
    }

    public class CatFact
    {
        public string Fact { get; set; }
        public int Lenght { get; set; }
    }
}
