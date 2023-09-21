using System.Collections;

// Criar Hash table
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt","notepad.exe");
    openWith.Add("bpm","paint.exe");
    openWith.Add("dib","paint.exe");
    openWith.Add("rtf","wordpad.exe");

    openWith.Add("txt","notepad++.exe");
}
/*
catch(ArgumentException aex)
{
  Console.WriteLine("Você tentou adicionar uma chave já adicionada a anteriormente.");
  Console.WriteLine($"Detalhes do Erro: {aex.Message}");
}
*/

catch (Exception)
{
    Console.WriteLine("Erro Genérico");
    
}

Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"]);


openWith["rtf"] =  "winword.exe";
Console.WriteLine(
  "Na \\ chave = \"rtf\" é {0}"
   , openWith["rtf"]
   );

// Testar se a chave existe

if(openWith.ContainsKey("ht")) 
{
  openWith.Add("ht", "hypertrm.exe");
  Console.WriteLine("Chave ht adicionada.");
}
// Percorrendo has com Foreach
Console.WriteLine();
foreach ( DictionaryEntry de in openWith)
{
  Console.WriteLine(
    "Key = {0} - Value = {1}",
    de.Key,
    de.Value
    );
}

// openWith.Add("dib","paint.exe");
Console.WriteLine("Programa ainda rodando");

// obtendo apenas os valores do hash
ICollection ValueCol = openWith.Values;
Console.WriteLine();
foreach(string s in ValueCol)
{
  Console.WriteLine("value = {0}", s);
}

ICollection KeyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in KeyCol)
{
  Console.WriteLine("key = {0}", s);
}

// remover registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");