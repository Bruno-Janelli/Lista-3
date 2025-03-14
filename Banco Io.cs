using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GerenciamentoEstoque
{
    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Quantidade: {Quantidade}, Preço: {Preco:C}";
        }
    }

    class Program
    {
        private static List<Produto> produtos = new List<Produto>();
        private const string caminhoArquivo = "estoque.txt";

        static void Main(string[] args)
        {
            CarregarDados();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Remover Produto");
                Console.WriteLine("3. Listar Produtos");
                Console.WriteLine("4. Calcular Valor Total do Estoque");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma operação: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        RemoverProduto();
                        break;
                    case "3":
                        ListarProdutos();
                        break;
                    case "4":
                        CalcularValorTotalEstoque();
                        break;
                    case "5":
                        SalvarDados();
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Operação invalida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            int quantidade;
            do
            {
                Console.Write("Quantidade: ");
            } while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0);

            decimal preco;
            do
            {
                Console.Write("Preço: ");
            } while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0);

            produtos.Add(new Produto { Nome = nome, Quantidade = quantidade, Preco = preco });
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        static void RemoverProduto()
        {
            ListarProdutos();

            if (!produtos.Any()) return;

            Console.Write("Digite o nome ou indice do produto a ser removido: ");
            string entrada = Console.ReadLine();

            Produto produtoRemover = null;
            if (int.TryParse(entrada, out int indice))
            {
                if (indice >= 0 && indice < produtos.Count)
                {
                    produtoRemover = produtos[indice];
                }
            }
            else
            {
                produtoRemover = produtos.FirstOrDefault(p => p.Nome.Equals(entrada, StringComparison.OrdinalIgnoreCase));
            }

            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void ListarProdutos()
        {
            if (!produtos.Any())
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            Console.WriteLine("\nProdutos cadastrados:");
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"[{i}] {produtos[i]}");
            }
        }

        static void CalcularValorTotalEstoque()
        {
            decimal valorTotal = produtos.Sum(p => p.Quantidade * p.Preco);
            Console.WriteLine($"Valor total do estoque: {valorTotal:C}");
        }

        static void SalvarDados()
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (var produto in produtos)
                {
                    writer.WriteLine($"{produto.Nome}|{produto.Quantidade}|{produto.Preco}");
                }
            }
        }

        static void CarregarDados()
        {
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split('|');
                    if (partes.Length == 3 &&
                        int.TryParse(partes[1], out int quantidade) &&
                        decimal.TryParse(partes[2], out decimal preco))
                    {
                        produtos.Add(new Produto { Nome = partes[0], Quantidade = quantidade, Preco = preco });
                    }
                }
            }
        }
    }
}