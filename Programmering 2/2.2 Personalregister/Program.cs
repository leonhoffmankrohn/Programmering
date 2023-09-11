using _2._2_Personalregister;

bool run = true;
List<Anställd> anställda = new();

while (run)
{
    Console.WriteLine("Vad vill du göra?\n\r'1'-lägg till, '2'-skriv ut, 'q'-quit");
    char answer = Console.ReadKey().KeyChar;

    // Ifall man vill lägga till något i registret
    if (answer == '1')
    {
        Console.WriteLine("Vad vill du lägga till?\n\r")
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

void SkrivUtRegister()
{
    Console.WriteLine("\n\r---Här börjar registret---\n\r");
    foreach (Anställd person in anställda)
    {
        Console.WriteLine(person.ToString());
    }
    Console.WriteLine("\n\r---Här slutar registret---\n\r");
}
void Registrera()
{
    
}
void Beräkna()
{
    
}