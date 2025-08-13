using System.Globalization;

Console.WriteLine("");

Console.WriteLine("Informe seu nome: ");
string? name = Console.ReadLine();

Console.WriteLine($"Seja bem vindo!{name}");

//declarando um vetor

int [] numbers = new int [5]; //vetor declarado

//atribuindo valores

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
int[] numbers4 = { 1, 2, 3, 4, 5 };

string[] mounths = new string[12];

for (int i = 1; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
    string Mounthname = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));

    mounths[i - 1] = Mounthname;
}

foreach (var month in mounths)
{ Console.WriteLine(month); }

//Arrray Multi-Dimensional

//2 Dimension

int[,] numbers52 = new int[5, 2];

//3 Dimension

int[,,] numbers543 = new int[5, 4, 3];

//Inicializando matriz valorada

int[,] nmb = new int[,] {
    {1, 2, -9},
    {5, 7, 10},
    {6, 115, 54}
};

//Também conseguimos declarar

int myNumber = nmb[2, 1];
Console.WriteLine("Imprimindo o valor da matriz:");
Console.WriteLine(myNumber);
