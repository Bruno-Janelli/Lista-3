using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        // Calculando a soma de todos os elementos
        int soma = numeros.Sum();

        // Exibindo o resultado
        Console.WriteLine("A soma dos elementos da lista é: " + soma);
    }
}
