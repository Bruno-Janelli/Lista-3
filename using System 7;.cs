using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um conjunto (HashSet) para armazenar palavras únicas
        HashSet<string> palavras = new HashSet<string>();

        // Adicionando palavras ao conjunto, incluindo duplicatas
        palavras.Add("maçã");
        palavras.Add("banana");
        palavras.Add("laranja");
        palavras.Add("maçã");  // Duplicata
        palavras.Add("uva");
        palavras.Add("banana"); // Duplicata
        palavras.Add("pera");

        // Exibindo o conjunto (as duplicatas serão removidas automaticamente)
        Console.WriteLine("Palavras únicas no conjunto:");
        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
    }
}
