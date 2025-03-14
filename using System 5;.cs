using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Criando uma lista com números repetidos
        List<int> numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 9 };

        // Removendo duplicatas usando HashSet
        List<int> numerosSemDuplicatas = numeros.Distinct().ToList();

        // Exibindo a lista original
        Console.WriteLine("Lista original:");
        Console.WriteLine(string.Join(", ", numeros));

        // Exibindo a lista sem duplicatas
        Console.WriteLine("\nLista sem duplicatas:");
        Console.WriteLine(string.Join(", ", numerosSemDuplicatas));
    }
}
