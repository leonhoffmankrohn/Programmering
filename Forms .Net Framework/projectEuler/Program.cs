
// Problem 1
double sum = 0;
int below = 1000;

for (int i = 0; i < below; i++)
{
    sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
}

Console.WriteLine("Multiples of 3 and 5 under 1000: " + sum);

// Problem 2
int fi;
int se = 1;
int th = 1;
sum = 0;

while (se < 4000000)
{
    
    fi = se + th;
    th = se;
    se = fi;
    sum += (se % 2 == 0) ? se : 0;
}

Console.WriteLine("\r\nFibonacci even numbers sum below 4 milions: " + sum + "\r\n");

// Problem 3
/*
 * Kolla för varje nummer
 *      Kolla alla nummer som är under om rest uppstår, continue
 *      
 */

// nummer är varje nummer
// j är varje nummer vi ska prova dela nummer på
// om rest uppstår fortsätter vi att dela
// om ingen rest uppstår så avbryter och kör annat nummer på nummer

int nummer = 60;
bool undividable = false;
int[] primtal = new int[100];

bool ärprim(int tal) 
{
    //Kollar om nummer är primtal
    int except = tal;
    
    for (int i = tal; i > 1; i--)
        if (tal % i == 0 && i != except)
        {
            break;
        }
        else return true;
    return false;
}

int tal = 0;
nummer = 0;
while (tal < 100)
{
    if (ärprim(nummer)) { primtal[tal] = nummer; tal++; Console.WriteLine(nummer); }
    nummer++;
}


double sökt = 600851475143;
for (int i = 0; i < primtal.Length; i++)
{
    undividable = false;
    while (!undividable)
        if (sökt % primtal[i] == 0)
        {
            sökt /= primtal[i];
            Console.WriteLine(primtal[i] + " " + sökt);
        }
        else undividable = true;
}
// (34)    (25)
// (17*2) (5*5)