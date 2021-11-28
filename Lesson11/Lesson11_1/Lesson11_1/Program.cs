using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lesson11_1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            bool isContinue;

            const string ApiUrl = "https://www.boredapi.com/api/activity";

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Starting... \n");

            do
            {
                var result = await httpClient.GetStringAsync(ApiUrl);

                var bored = JsonConvert.DeserializeObject<Bored>(result);

                Console.WriteLine(bored.Activity + "\n");

                Console.WriteLine("Do you want to continue ? true/false \n");

                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

            } while (isContinue);

            Console.ReadKey();
        }
    }

    public class Bored
    {
        public string Activity { get; set; }

    }
}
