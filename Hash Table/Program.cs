using System.Collections;
using System.Collections.Generic;

/* 
    A tabela hash é baseada no conceito de por chave - valor
    a chave é a forma de se acessar o respectivo valor
    e por ser chave deve ser única.
*/
Hashtable ht = new Hashtable () 
{ 
    { "Luiz", "123"},
    { "Mauricio de Souza", "456" } 
};

// Uma forma de adicionar um novo par
ht[ "Mauricio Mattar"] = "789";

ht.Add("Mossou", "666");

// Verificar se existem pares chave - valor na tabela hash

if (ht.Count > 0)
{
    // Percorrer os pares armazenados
    foreach(DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave: {entry.Key}, Valor: {entry.Value}");
    }
}
else
{
    Console.WriteLine("Tabela Hash Vazia");
}

// Vimos que ao adicionar uma chave repetida á HashTable
// O programa crasha é interrompida a execução
// Para evitar este comportamento, fazemos uso da
// Claúsula (sentença) try {} catch {}

try
{
    ht.Add("Mossou", "666");
}
catch (ArgumentException ex2)
{
    Console.WriteLine("Não é possível adicionar chaves iguais.");
    //throw ex2;
}
catch (Exception ex)
{
    Console.WriteLine("Erro Desconhecido");
}
finally
{
    Console.WriteLine("Agora vai! Segue em frente");
}

// Agora o úsuario vai informar

Console.WriteLine("Informe a chave: ");
string key = Console.ReadLine ();

Console.WriteLine("Informe o Valor: ");
string value = Console.ReadLine ();

try
{
    ht.Add(key, value);
    Console.WriteLine("Par chave - valor adicionado!");
}
catch
{
    Console.WriteLine("Ops! Chave já existente.");
}

// Agora faremos uma busca na Tabela Hash

Console.WriteLine("O que procuras muchacho?");
string search = Console.ReadLine ();

if( ht.Contains(search))
{
    Console.WriteLine($"Encontrado! {search}, {ht[search]}");
}
else
{
    Console.WriteLine("Non ecxiste");
}