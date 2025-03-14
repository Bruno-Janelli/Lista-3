using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de palavras de entrada
        List<string> palavras = new List<string> { "apple", "banana", "apricot", "blueberry", "avocado", "cherry", "carrot" };

        // Criando um dicionário para armazenar o agrupamento
        Dictionary<char, List<string>> agrupamento = new Dictionary<char, List<string>>();

        // Percorrendo a lista de palavras
        foreach (string palavra in palavras)
        {
            char primeiraLetra = palavra[0]; // Obtém a primeira letra

            // Se a chave ainda não existe, cria uma nova lista
            if (!agrupamento.ContainsKey(primeiraLetra))
            {
                agrupamento[primeiraLetra] = new List<string>();
            }

            // Adiciona a palavra à lista correspondente
            agrupamento[primeiraLetra].Add(palavra);
        }

        // Exibindo o agrupamento
        Console.WriteLine("Palavras agrupadas por primeira letra:");
        foreach (var item in agrupamento)
        {
            Console.WriteLine($"{item.Key}: [{string.Join(", ", item.Value)}]");
        }
    }
}
