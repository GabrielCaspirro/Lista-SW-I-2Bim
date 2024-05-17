using System;

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, decimal preco, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarAoEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} {Nome}(s) adicionado(s) ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade adicionada deve ser maior que zero.");
        }
    }

    public void RemoverDoEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} {Nome}(s) removido(s) do estoque.");
        }
        else if (quantidade > QuantidadeEmEstoque)
        {
            Console.WriteLine("Quantidade solicitada excede a quantidade em estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade removida deve ser maior que zero.");
        }
    }
}
