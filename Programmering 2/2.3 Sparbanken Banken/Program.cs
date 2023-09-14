using _2._3_Sparbanken_Banken;
using System.ComponentModel.DataAnnotations;

bool run = true;
Bank bank = new Bank();

while (run)
{
    Console.WriteLine("Vad vill du göra?\n\r'1'-Insättning;'2'-Uttag;'3'-Skapa konto;'4'-Skriv ut lista;'q'-avsluta");
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
        SkrivUt();
    }
}

void Insättning()
{
    if (bank.konton.Length != 0)
    {
        Console.WriteLine("Vilket konto vill du sätta in på?");
        SkrivUt();
        Console.WriteLine("Skriv motsvarande siffra:");
        int.TryParse(Console.ReadKey().ToString(), out int kontoNummer);
        Console.WriteLine("Skriv belopp och sen enter:");
        double.TryParse(Console.ReadLine(), out double belopp);

        if (0 < kontoNummer && kontoNummer <= bank.konton.Length + 1)
        {
            bank.konton.
        }
        else Console.WriteLine("Det gick snett tyvärr, du får försöka igen senare");
    }
}

void Uttag()
{

}

void SkapaKonto()
{

}

void SkrivUt()
{

}