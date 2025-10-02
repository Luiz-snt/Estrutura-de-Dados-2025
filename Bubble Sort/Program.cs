using Bubble_Sort;

Console.WriteLine("Oredenação com Bubble Sort:");
Console.WriteLine("");
int[] arrNumbers = new int[] { 99, 50, -24, 0, 1 };

foreach (var number in arrNumbers)
    Console.Write($"[{number}] ");
    Console.WriteLine("");

var arrOrdered = BubbleSortOrder.Sort<int>(arrNumbers);
Console.WriteLine("");
Console.WriteLine("***********************");
Console.WriteLine("");
Console.WriteLine("Vetor Ordenado:");
Console.WriteLine("");

foreach (var number in arrOrdered)
    Console.Write($"[{number}] ");

Console.WriteLine("");
Console.WriteLine("\nOredenação com Bubble Sort:");
Console.WriteLine("");
string[] arrString = new string[] { "K", "50", "-24", "H", "HG" };

foreach (var i in arrString)
    Console.Write($"[{i}] ");
    Console.WriteLine("");

var arrOrdenedString = BubbleSortOrder.Sort<string>(arrString);
Console.WriteLine("");
Console.WriteLine("***********************");
Console.WriteLine("");
Console.WriteLine("Vetor Ordenado:");
Console.WriteLine("");

foreach (var i in arrOrdenedString)
    Console.Write($"[{i}] ");

