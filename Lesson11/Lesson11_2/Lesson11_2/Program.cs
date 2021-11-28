using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lesson_11_1
{
    class Program
    {
        public class Genderize
        {
            public string Name { get; set; }
            public string Gender { get; set; }
        }
        static async Task Main(string[] args)
        {
            bool isContinue;

            const string url = "https://api.genderize.io/?name=";

            HttpClient httpClient = new HttpClient();

            do
            {
                Console.Write("Enter name : ");
                string text = Console.ReadLine();

                string ApiUrl = $"{url}{text}";

                var result = await httpClient.GetStringAsync(ApiUrl);

                var genderize = JsonConvert.DeserializeObject<Genderize>(result);

                Console.WriteLine(genderize.Name + " :" + genderize.Gender + "\n");

                Console.WriteLine("Do you want to continue ? true/false \n");

                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

            } while (isContinue);


            Console.ReadKey();
        }
    }
}