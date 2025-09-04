using System.Collections.Generic;
Console.WriteLine("Invertendo palavras com pilhas (Stacks)");

Stack<char> chars = new Stack<char>();
string? palavra = Console.ReadLine();
string? palavra_invertida = null;

foreach (var c in palavra)

    chars.Push(c);

while (chars.Count > 0)
{
    palavra_invertida += chars.Pop();
}
if (palavra_invertida == palavra)
{
    Console.WriteLine("Essa Palavra é um Palíndromo");
}
else
{
    Console.WriteLine("Essa Palavra não é um Palíndromo");
    Console.WriteLine(palavra_invertida);
}
