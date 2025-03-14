using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando dois conjuntos de números inteiros
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

        // Criando um novo conjunto para armazenar a união
        HashSet<int> uniao = new HashSet<int>(conjuntoA);

        // Adicionando os elementos do segundo conjunto
        uniao.UnionWith(conjuntoB);

        // Exibindo os conjuntos originais
        Console.WriteLine("Conjunto A: " + string.Join(", ", conjuntoA));
        Console.WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

        // Exibindo o resultado da união
        Console.WriteLine("\nUnião dos conjuntos:");
        Console.WriteLine(string.Join(", ", uniao));
    }
}
