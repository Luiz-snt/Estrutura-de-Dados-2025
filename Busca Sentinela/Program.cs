int [] numeros = {10, 20, 180, 30, 60, 50, 110, 100, 70};
int keyInt = 180;
SentinelSearch(numeros, numeros.Length, keyInt);

string[] nomes = {"Ana","Bruno","Carlos","Diana"};
string keyString = "Carlos";
SentinelSearch(nomes, nomes.Length, keyString);

static void SentinelSearch<T>(T[] arr, int n, T key)
{
    //Coloca o elemento a ser buscado na última posição
    T last = arr[n - 1];
    
    //Coloca o elemento a ser buscado na última posição
    arr[n - 1] = key;
    int i = 0;

    //Busca até encontra o valor
    while (!EqualityComparer<T>.Default.Equals(arr[i], key))
        i++;

    //Restaura o último elemento original
    arr[n - 1] = last;

    //verifica se encontrou dentro da faixa válida
    if (i < n -1 || EqualityComparer<T>.Default.Equals(arr[n - 1], key))
        Console.WriteLine($"{key} está presente no índice {i}");
    else
        Console.WriteLine("Elemento não encontrado");    
}