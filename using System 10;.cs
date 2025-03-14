using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando os conjuntos A e B
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };

        // Criando um novo conjunto para armazenar a diferença (A - B)
        HashSet<int> diferenca = new HashSet<int>(conjuntoA);
        diferenca.ExceptWith(conjuntoB);

        // Exibindo os conjuntos originais
        Console.WriteLine("Conjunto A: " + string.Join(", ", conjuntoA));
        Console.WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

        // Exibindo a diferença A - B
        Console.WriteLine("\nElementos que estão em A mas não em B:");
        Console.WriteLine(string.Join(", ", diferenca));

        // Verificando se A é subconjunto de B
        bool aEhSubconjuntoDeB = conjuntoA.IsSubsetOf(conjuntoB);
        Console.WriteLine("\nA é subconjunto de B? " + aEhSubconjuntoDeB);

        // Verificando se B é subconjunto de A
        bool bEhSubconjuntoDeA = conjuntoB.IsSubsetOf(conjuntoA);
        Console.WriteLine("B é subconjunto de A? " + bEhSubconjuntoDeA);
    }
}
