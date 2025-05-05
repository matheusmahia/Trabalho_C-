using System;
using System.Collections.Generic;
class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public decimal ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}
class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();
        Console.WriteLine("Cadastro de Produtos\n");

        for (int i = 1; i <= 3; i++)
        {
            Produto produto = new Produto();

            Console.Write($"Digite o nome do produto {i}: ");
            produto.Nome = Console.ReadLine();

            Console.Write($"Digite o preço do produto {i}: ");
            while (!decimal.TryParse(Console.ReadLine(), out produto.Preco) || produto.Preco < 0)
            {
                Console.WriteLine("Entrada inválida! Digite um valor numérico positivo.");
                Console.Write($"Digite o preço do produto {i}: ");
            }

            Console.Write($"Digite a quantidade do produto {i}: ");
            while (!int.TryParse(Console.ReadLine(), out produto.Quantidade) || produto.Quantidade < 0)
            {
                Console.WriteLine(" Entrada inválida! Digite um número inteiro positivo.");
                Console.Write($"Digite a quantidade do produto {i}: ");
            }

            produtos.Add(produto);
        }
        Console.WriteLine("\nLista de Produtos Cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($" {produto.Nome} - Preço: R${produto.Preco:F2} - Quantidade: {produto.Quantidade} - Total em estoque: R${produto.ValorTotalEmEstoque():F2}");
        }
    }
}