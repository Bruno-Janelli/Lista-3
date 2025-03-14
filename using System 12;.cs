using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // String de entrada
        string texto = "banana";

        // Criando um dicionário para armazenar a frequência dos caracteres
        Dictionary<char, int> frequencia = new Dictionary<char, int>();

        // Percorrendo cada caractere da string
        foreach (char c in texto)
        {
            if (frequencia.ContainsKey(c))
                frequencia[c]++; // Se já existe, incrementa
            else
                frequencia[c] = 1; // Se não existe, adiciona com valor 1
        }

        // Exibindo o resultado
        Console.WriteLine("Frequência de caracteres:");
        foreach (var item in frequencia)
        {
            Console.WriteLine($"'{item.Key}': {item.Value}");
        }
    }
}
