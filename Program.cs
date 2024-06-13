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

            MyConsole.ShowRegions();

            var fylke = Console.ReadLine();
            Console.Clear();

            MyConsole.ShowApprovalTypes();
            var approvalTypes = Console.ReadLine().ToUpper();
            Console.Clear();

            foreach (var workshop in workshops)
            {
                var filterRegion = workshop.Postnummer.ToString().StartsWith(fylke);
                var filterApprovalTypes = workshop.Godkjenningstyper.Contains(approvalTypes);
                if (filterRegion && filterApprovalTypes)
                {
                    workshop.Show();
                }

            }
        }
    }
}
