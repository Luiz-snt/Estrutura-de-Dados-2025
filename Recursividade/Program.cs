Console.Write("Enter a number:");
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
}