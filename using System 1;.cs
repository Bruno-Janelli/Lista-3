using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> numeros = new List<int>();

        // Adicionando cinco números inteiros à lista
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        numeros.Add(50);

        // Imprimindo todos os elementos da lista
        Console.WriteLine("Elementos da lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
