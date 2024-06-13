namespace Workshops
{
    internal class WorkshopInfo
    {
        public string Bedriftsnavn { get; set; }
        public string Adresse { get; set; }
        public object Postnummer { get; set; }
        public string Poststed { get; set; }
        public string Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        public int Godkjenningsnummer { get; set; }

        public void Show()
        {
            Console.WriteLine($"Bedriftsnavn: {Bedriftsnavn}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Postnummer: {Postnummer}");
            Console.WriteLine($"Poststed: {Poststed}");
            Console.WriteLine($"Godkjenningstyper: {Godkjenningstyper}");
            Console.WriteLine($"Organisasjonsnummer: {Organisasjonsnummer}");
            Console.WriteLine($"Godkjenningsnummer: {Godkjenningsnummer}");
            Console.WriteLine();
        }

    }
}
