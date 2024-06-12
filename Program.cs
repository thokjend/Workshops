using System.Text.Json;

namespace Workshops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workShopsJson = File.ReadAllText("workshops.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var workshops = JsonSerializer.Deserialize<WorkshopInfo[]>(workShopsJson, options);

            Console.WriteLine(workshops[0].Bedriftsnavn);

        }
    }
}
