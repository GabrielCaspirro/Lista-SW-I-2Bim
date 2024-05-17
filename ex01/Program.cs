using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto("Camisa", 29.99m, 50);

        Console.WriteLine($"Produto: {produto1.Nome} - Preço: {produto1.Preco:C} - Quantidade em Estoque: {produto1.QuantidadeEmEstoque}");

        produto1.AdicionarAoEstoque(10);
        Console.WriteLine($"Novo estoque de {produto1.Nome}: {produto1.QuantidadeEmEstoque}");

        produto1.RemoverDoEstoque(5);
        Console.WriteLine($"Novo estoque de {produto1.Nome}: {produto1.QuantidadeEmEstoque}");
    }
}