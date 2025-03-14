using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtrando apenas os números pares
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        // Exibindo a lista original
        Console.WriteLine("Lista original:");
        Console.WriteLine(string.Join(", ", numeros));

        // Exibindo a lista filtrada
        Console.WriteLine("\nLista de números pares:");
        Console.WriteLine(string.Join(", ", numerosPares));
    }
}
