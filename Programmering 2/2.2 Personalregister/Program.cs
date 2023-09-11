using _2._2_Personalregister;
using System.Xml;

bool run = true;
List<Anställd> anställda = new();

while (run)
{
    Console.WriteLine("Vad vill du göra?\n\r'1'-lägg till, '2'-skriv ut, 'q'-quit");
    char answer = Console.ReadKey().KeyChar;

    // Ifall man vill lägga till något i registret
    if (answer == '1')
    {
        Registrera();
    }
    // Ifall du vill skriva ut registret
    else if (answer == '2')
    {
        SkrivUtRegister();
    }
    // Avsluta
    else if (answer == 'q')
    {
        Environment.Exit(0);
    }
    // Inget giltigt svar
    else
    {
        Console.WriteLine("Var snäll och ange något giltigt\n\rTryck på valfri knapp för att fortsätta");
        Console.ReadLine();
    }
     Console.Clear();
}

// Beräknar alla löner tillsammans
string LönSumma()
{
    double summa = 0;
    foreach (Anställd person in anställda)
    {
        summa += person.BeräknaLön();
    }
    return summa.ToString() + " kr";
}

// Här skriver vi ut registret
void SkrivUtRegister()
{
    Console.Clear();
    Console.WriteLine("\n\r---Här börjar registret---\n\r");
    foreach (Anställd person in anställda)
    {
        Console.WriteLine(person.ToString());
    }

    Console.WriteLine("\n\rSumma av löner: " + LönSumma());

    Console.WriteLine("\n\r---Här slutar registret---\n\r (tryck valfri knapp för att fortsätta)");
    Console.ReadKey();
}

// Här registrear vi nya anställda
void Registrera()
{
    Console.Clear();
    Console.WriteLine("Vad vill du lägga till?\n\r'1'-säljare, '2'-konsult, '3'-kontorist, 'q'-gå tillbaka");
    char answer = Console.ReadKey().KeyChar;
    Console.Clear();

    // För säljare
    if (answer == '1')
    {
        Console.WriteLine("Var vänlig skriv namn");
        string namn = Console.ReadLine();
        Console.WriteLine("Provision:");
        double provision = HämtaDouble();
        Console.WriteLine("Försäljning:");
        double försäljning = HämtaDouble();
        anställda.Add(new Säljare(namn, provision, försäljning));
    }
    // För konsulter
    else if (answer == '2')
    {
        Console.WriteLine("Var vänlig skriv namn");
        string namn = Console.ReadLine();
        Console.WriteLine("Arbetade timmar:");
        double arbetadeTimmar = HämtaDouble();
        Console.WriteLine("Timlön:");
        double timLön = HämtaDouble();
        anställda.Add(new Konsult(namn, arbetadeTimmar, timLön));
    }
    // för kontorister
    else if (answer == '3')
    {
        Console.WriteLine("Var vänlig skriv namn");
        string namn = Console.ReadLine();
        Console.WriteLine("Månadslön:");
        double arbetadeTimmar = HämtaDouble();
        anställda.Add(new Kontorist(namn, arbetadeTimmar));
    }
}

double HämtaDouble()
{
    double.TryParse(Console.ReadLine(), out double returnerar);
    return returnerar;
}