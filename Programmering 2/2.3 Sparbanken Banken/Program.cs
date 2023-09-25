using _2._3_Sparbanken_Banken;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

bool run = true;
Bank bank = new Bank();

while (run)
{
    Console.Clear();
    SkrivUt();
    Console.WriteLine("Vad vill du göra?\n\r'1'-Insättning;'2'-Uttag;'3'-Skapa konto;'4'-Uppdatera med årsränta;'q'-avsluta");
    char answer = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (answer == 'q') Environment.Exit(0);
    else if (answer == '1')
    {
        Insättning();
    }
    else if (answer == '2')
    {
        Uttag();
    }
    else if (answer == '3')
    {
        SkapaKonto();
    }
    else if (answer == '4')
    {
        UppdateraMedÅrsränta();
    }
}

void Insättning()
{
    if (bank.konton.Count != 0)
    {
        Console.WriteLine("Vilket konto vill du sätta in på?\n\rSkriv motsvarande siffra:");
        int.TryParse(Console.ReadKey().ToString(), out int kontoNummer);
        Console.WriteLine("\n\rSkriv belopp och sen enter:");
        double.TryParse(Console.ReadLine(), out double belopp);

        if (0 < kontoNummer && kontoNummer <= bank.konton.Count + 1)
        {
            bank.konton[kontoNummer].Insättning(belopp);
            Console.WriteLine("Insättningen lyckades!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Det gick snett tyvärr, du får försöka igen senare");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Skapa ett konto först");
        Console.ReadKey();
    }
}

void Uttag()
{
    if (bank.konton.Count != 0)
    {
        Console.WriteLine("Vilket konto vill du dra pengar ifrån?");
        Console.WriteLine("Skriv motsvarande siffra:");
        int.TryParse(Console.ReadKey().ToString(), out int kontoNummer);
        Console.WriteLine("\n\rSkriv belopp och sen enter:");
        double.TryParse(Console.ReadLine(), out double belopp);

        if (0 < kontoNummer && kontoNummer <= bank.konton.Count)
        {
            bool lyckad = bank.konton[kontoNummer-1].Uttag(belopp);
            if (!lyckad)
            {
                Console.WriteLine("Du kan inte ta ut så mycket pengar \n\rFörsök igen senare");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Transaktionen lyckades!");
                Console.ReadKey();
            }

        }
        else
        {
            Console.WriteLine("Det gick snett tyvärr, du får försöka igen senare");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Skapa ett konto först");
        Console.ReadKey();
    }
}

void SkapaKonto()
{
    Console.WriteLine("Vad kommer det att vara för slags konto?\n\r'1'-Sparkonto; '2'-Lånekonto");
    char kontotyp = Console.ReadKey().KeyChar;
    Console.WriteLine("\n\rVad är ditt personnummer?");
    string personnummer = "";
    personnummer += Console.ReadLine();
    Console.WriteLine("Vad är räntesatsen i %?");
    bool lyckat = double.TryParse(Console.ReadLine(), out double räntesats);
    Console.WriteLine("Vad är befintliga behållningen?");
    bool lyckat2 = double.TryParse(Console.ReadLine(), out double behållning);
    if (lyckat && lyckat2)
    {
        if (kontotyp == '1')
        {
            SparKonto konto = new SparKonto(personnummer, behållning, räntesats / 100);
            bank.konton.Add(konto);
        }
        else if (kontotyp == '2')
        {
            Console.WriteLine("Vad är kreditgränsen?");
            double.TryParse(Console.ReadLine(), out double kreditgräns);
            LåneKonto konto = new LåneKonto(personnummer, behållning, räntesats / 100, kreditgräns);
            bank.konton.Add(konto); 
        }
        else
        {
            Console.WriteLine("Något gick fel, försök igen senare eller kontakta service");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Något gick fel med tryparse, försök igen senare eller kontakta service");
        Console.ReadKey();
    }
}

void UppdateraMedÅrsränta()
{
    foreach (BankKonto konto in bank.konton)
    {
        konto.BeräknaRänta();
    }
}

void SkrivUt()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\r--- Här börjar listan ---\n\r");
    foreach (BankKonto konto in bank.konton)
    {
        Console.WriteLine(konto.ToString());
    }
    Console.WriteLine("\n\rBank behållning: " + bank.Behållning + " kr\n\r" +
        "--- Här slutar listan ---\n\r");
    Console.ForegroundColor = ConsoleColor.White;

}