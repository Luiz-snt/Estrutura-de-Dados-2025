using Selection_Sort;
Console.WriteLine("Vetor de inteiros:");

int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

Selection_Sort.SelectionSort.Sort(integerValues);
Console.WriteLine(string.Join(",", integerValues));
Console.WriteLine("\n****************************\n");

Console.WriteLine("Vetor de nomes:");

string[] stringValues = { "Bolsonaro", "Kléber", "Putin", "Pica-Pau", "Barack Hussein Obama", "Tais Carla" };
Selection_Sort.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(",", stringValues));
