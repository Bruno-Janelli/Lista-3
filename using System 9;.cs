using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando dois conjuntos com alguns elementos em comum
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6, 7 };

        // Criando um novo conjunto para armazenar a interseção
        HashSet<int> intersecao = new HashSet<int>(conjuntoA);

        // Mantendo apenas os elementos que também estão em conjuntoB
        intersecao.IntersectWith(conjuntoB);

        // Exibindo os conjuntos originais
        Console.WriteLine("Conjunto A: " + string.Join(", ", conjuntoA));
        Console.WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

        // Exibindo a interseção
        Console.WriteLine("\nInterseção dos conjuntos:");
        Console.WriteLine(string.Join(", ", intersecao));
    }
}
