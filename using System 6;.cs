using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        // Criando uma nova lista para armazenar os números invertidos
        List<int> numerosInvertidos = new List<int>();

        // Percorrendo a lista de trás para frente e adicionando os elementos na nova lista
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            numerosInvertidos.Add(numeros[i]);
        }

        // Exibindo a lista original
        Console.WriteLine("Lista original:");
        Console.WriteLine(string.Join(", ", numeros));

        // Exibindo a lista invertida
        Console.WriteLine("\nLista invertida:");
        Console.WriteLine(string.Join(", ", numerosInvertidos));
    }
}
