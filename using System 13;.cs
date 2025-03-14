using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um dicionário com produtos e seus preços
        Dictionary<string, double> produtos = new Dictionary<string, double>
        {
            { "Arroz", 5.99 },
            { "Feijão", 7.49 },
            { "Macarrão", 3.29 },
            { "Leite", 4.99 },
            { "Café", 10.50 }
        };

        // Solicitando o nome do produto ao usuário
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        // Buscando o preço do produto no dicionário
        if (produtos.TryGetValue(nomeProduto, out double preco))
        {
            Console.WriteLine($"O preço de {nomeProduto} é R$ {preco:F2}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}
