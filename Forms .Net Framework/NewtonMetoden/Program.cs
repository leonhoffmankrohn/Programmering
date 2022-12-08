// See https://aka.ms/new-console-template for more information
/* What is the root of:
 * for instance 64 which we know is 8
 * but how do we get the computer to calculate it that way?
 * 
 * First we need to make it to an equation
 * this equation is the one we are running until enough numbers are equal to the previous iteration
 * then we shall print the number that the last iteration produced.
 */

Random generator = new Random();

void sqrt(double input) 
{
    double x0 = generator.Next(-100, 100) + generator.NextDouble();
    Console.WriteLine(x0);
    double x1 = 1;
    while (x0 != x1)
    { 
        x0 = x1;
        double fx = x0*x0-input;
        double fk = 2 * x0;
        x1 = x0 - (fx / fk);
        Console.WriteLine(x1.ToString());
    }
    Console.WriteLine("\r\n" + x0 * x0);

}
string input = Console.ReadLine();

sqrt(double.Parse(input));