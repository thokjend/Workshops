namespace Workshops
{
    internal class MyConsole
    {
        public static void ShowRegions()
        {
            Console.WriteLine(
                "Velg et fylke: Enter for å velge alle\n" +
                "00-12 for Oslo\n" +
                "13-15 for Akershus\n" +
                "15-18 for Østfold\n" +
                "19-21 for Akershus\n" +
                "21-26 for Hedmark\n" +
                "26-29 for Oppland\n" +
                "30 for Buskerud\n" +
                "30-32 for Vestfold\n" +
                "33-36 for Buskerud\n" +
                "35 for Oppland\n" +
                "36-39 for Telemark\n" +
                "40-44 for Rogaland\n" +
                "44-47 for Vest-Agder\n" +
                "47-49 for Aust-Agder\n" +
                "50-59 for Hordaland\n" +
                "55 for Rogaland\n" +
                "57, 59 for Sogn og Fjordane\n" +
                "60-66 for Møre og Romsdal\n" +
                "67-69 for Sogn og Fjordane\n" +
                "70-75 for Sør-Trøndelag\n" +
                "75-76 for Nord-Trøndelag\n" +
                "77 for Sør-Trøndelag\n" +
                "77-79 for Nord-Trøndelag\n" +
                "79-89 for Nordland\n" +
                "84, 90-94 for Troms\n" +
                "91, 95-99 for Finnmark"
            );
        }

        public static void ShowApprovalTypes()
        {
            Console.WriteLine("Velg en godkjenningstype: Enter for å velge alle\n" +
                              "komma mellom for å velge mer enn 1. eks: Bilverksted01, Hjul\n" +
                              "Bilverksted01\n" +
                              "Bilverksted01B\n" +
                              "Bilverksted02\n" +
                              "Bilverksted03\n" +
                              "Skadeverksted01\n" +
                              "Skadeverksted02\n" +
                              "Kontrollorgan01\n" +
                              "Kontrollorgan01B\n" +
                              "Kontrollorgan02\n" +
                              "Kontrollorgan03\n" +
                              "Kontrollorgan04\n" +
                              "Kontrollorgan05\n" +
                              "Alkolasverksted\n" +
                              "Hjul\n" +
                              "Hjulutrustning\n" +
                              "Traktor\n" +
                              "Lysutstyr\n" +
                              "Motorsykkelogmoped\n" +
                              "Hengerespalopsbremseanlegg\n" +
                              "Pabygger\n" +
                              "Eksosanlegg\n" +
                              "Bilglass\n" +
                              "Mykkarosseri");
        }
    }
}
