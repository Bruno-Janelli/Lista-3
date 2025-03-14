using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> numeros = new List<int> { 15, 8, 22, 3, 19, 7 };

        // Inicializando as variáveis com o primeiro elemento da lista
        int menor = numeros[0];
        int maior = numeros[0];

        // Percorrendo a lista para encontrar o maior e o menor valor
        foreach (int numero in numeros)
        {
            if (numero < menor)
                menor = numero;

            if (numero > maior)
                maior = numero;
        }

        // Exibindo os resultados
        Console.WriteLine("Lista de números: " + string.Join(", ", numeros));
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Maior valor: " + maior);
    }
}
