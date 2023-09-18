using _2._3_Sparbanken_Banken;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

bool run = true;
Bank bank = new Bank();

while (run)
{
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
        Console.WriteLine("Vilket konto vill du sätta in på?");
        SkrivUt();
        Console.WriteLine("Skriv motsvarande siffra:");
        int.TryParse(Console.ReadKey().ToString(), out int kontoNummer);
        Console.WriteLine("Skriv belopp och sen enter:");
        double.TryParse(Console.ReadLine(), out double belopp);

        if (0 < kontoNummer && kontoNummer <= bank.konton.Count + 1)
        {
            bank.konton[kontoNummer].Insättning(belopp);
        }
        else Console.WriteLine("Det gick snett tyvärr, du får försöka igen senare");
    }
}

void Uttag()
{
    if (bank.konton.Count != 0)
    {
        Console.WriteLine("Vilket konto vill du dra pengar ifrån?");
        SkrivUt();
        Console.WriteLine("Skriv motsvarande siffra:");
        int.TryParse(Console.ReadKey().ToString(), out int kontoNummer);
        Console.WriteLine("Skriv belopp och sen enter:");
        double.TryParse(Console.ReadLine(), out double belopp);

        if (0 < kontoNummer && kontoNummer <= bank.konton.Count + 1)
        {
            bool lyckad = bank.konton[kontoNummer].Uttag(belopp);
            if (!lyckad)
            {
                Console.WriteLine("Du kan inte ta ut så mycket pengar \n\rFörsök igen senare");
            }
            else Console.WriteLine("Transaktionen lyckades!");
        }
        else Console.WriteLine("Det gick snett tyvärr, du får försöka igen senare");
    }
}

void SkapaKonto()
{
    Console.WriteLine("Vad kommer det att vara för slags konto?\n\r'1'-Sparkonto; '2'-Lånekonto");
    char kontotyp = Console.ReadKey().KeyChar;
    Console.WriteLine("Vad är ditt personnummer?");
    string personnummer = "";
    personnummer += Console.ReadLine();
    Console.WriteLine("Vad är räntesatsen?");
    bool lyckat = double.TryParse(Console.ReadLine(), out double räntesats);
    Console.WriteLine("Vad är befintliga behållningen?");
    bool lyckat2 = double.TryParse(Console.ReadLine(), out double behållning);
    if (lyckat && lyckat2)
    {
        if (kontotyp == '1')
        {
            SparKonto konto = new SparKonto(personnummer, behållning, räntesats);
            bank.konton.Add(konto);
        }
        else if (kontotyp == '2')
        {
            Console.WriteLine("Vad är kreditgränsen?");
            double.TryParse(Console.ReadLine(), out double kreditgräns);
            LåneKonto konto = new LåneKonto(personnummer, behållning, räntesats, kreditgräns);
            bank.konton.Add(konto); 
        }
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
    Console.WriteLine("\n\r--- Här börjar listan ---\n\r";
    foreach (BankKonto konto in bank.konton)
    {
        konto.ToString();
    }

}