using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um dicionário onde a chave é o nome e o valor é o telefone
        Dictionary<string, string> contatos = new Dictionary<string, string>();

        // Adicionando cinco contatos ao dicionário
        contatos.Add("Alice", "(11) 98765-4321");
        contatos.Add("Bruno", "(21) 91234-5678");
        contatos.Add("Carlos", "(31) 99876-5432");
        contatos.Add("Daniela", "(41) 97654-3210");
        contatos.Add("Eduardo", "(51) 93456-7890");

        // Exibindo todos os contatos
        Console.WriteLine("Lista de Contatos:");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"{contato.Key}: {contato.Value}");
        }
    }
}
