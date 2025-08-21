/*Console.Write("Enter a number:");
int leght = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < leght; i++)
{
    Console.Write("{0} ", fatorial(i));
}
Console.ReadKey();

static int fatorial (int n)
{
    if (n == 0) return 1;
    else return n * fatorial(n - 1);
}*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine($"The factorial of {x} is {factorial(x)}");
        Console.ReadKey();
    }

    static int factorial(int number)
    {
        if (number == 1)
        {
            return 1;
        }
        else
        {
            return number * factorial(number - 1);
        }
    }
}
