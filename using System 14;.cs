using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um dicionário original
        Dictionary<char, int> dicionarioOriginal = new Dictionary<char, int>
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 }
        };

        // Criando um novo dicionário para armazenar a inversão
        Dictionary<int, char> dicionarioInvertido = new Dictionary<int, char>();

        // Percorrendo o dicionário original e invertendo chave e valor
        foreach (var item in dicionarioOriginal)
        {
            dicionarioInvertido[item.Value] = item.Key;
        }

        // E
