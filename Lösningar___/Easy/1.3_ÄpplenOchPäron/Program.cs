
string input = Console.ReadLine();

int.TryParse(input.Split(' ')[0], out int axelAmount);
int.TryParse(input.Split(' ')[1], out int petraAmount);

int axelSold = axelAmount * 7;
int petraSold = petraAmount * 13;

if (axelSold == petraSold) Console.WriteLine("lika");
else if (axelSold > petraSold) Console.WriteLine("axel");
else if (axelSold < petraSold) Console.WriteLine("petra");
