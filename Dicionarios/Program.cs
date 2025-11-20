/*
    Os dicionarios funcionam da mesma forma que as tabelas Hash.
    No entanto de uma maneira mais sofisticadas, é possivel definir
    que tipo de dado será utilizado para armazenar
    tanto a Chave quando o Valor.
    Diferentemente de TableHash que utiliza-se apenas de string.
*/

// Criando um dicionario com vazio
Dictionary<string,int> dic0 = new Dictionary<string,int>();

// Criando um dicionario com valores
Dictionary<string, int> dic = new Dictionary<string, int>
{
    { "Chave 1", 100 },
    { "Chave 2", 200 },
};

// Podemos adicionar informando diretamente a chave
dic["Chave 3"] = 300;
dic.Add("Chave 4", 400);

// Para procurar
if(dic.ContainsKey("Chave 4"))
{
    Console.WriteLine($"Encontrado Chave 4,{dic["Chave 4"]}");
}

// Percorrendo o Dicionario
foreach (KeyValuePair<string, int > kv in dic)
{
    Console.WriteLine( $"Chave: {kv.Key} - Valor: {kv.Value}");
}



