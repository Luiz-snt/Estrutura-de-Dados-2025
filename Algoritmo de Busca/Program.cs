using System;
public class BuscaNoVetor
{
    public static void Main(string[] args)
    {
        List<string> list = ["10", "80", "62", "24", "37", "5", "30", "78", "91", "67"];

        Console.WriteLine($"Dados: {string.Join(", ", list)}");
        Console.Write("Digite um Número: ");
        string? numero = Console.ReadLine();
        bool encontrado = false;

        if (numero != null)
        {
            for (int i = 0; i < list.Count; i++) 
            {

                if (numero.CompareTo(list[i]) == 0)
                {
                    Console.WriteLine($"✅ Número encontrado na posição: {i}");
                    encontrado = true;
                    break;
                }
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("❌ Número não encontrado.");
        }
    }
}