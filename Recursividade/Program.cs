Console.Write("Escreva um número para Finobacci séries:");
int leght = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < leght; i++)
{
    Console.Write("{0}", FibonacciSeries(i));
}
Console.ReadKey();

static int FibonacciSeries(int n);
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
}