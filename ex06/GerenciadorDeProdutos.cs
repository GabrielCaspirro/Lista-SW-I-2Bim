using System;
using System.Collections.Generic;

public class Produto
{
    public int Codigo { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(int codigo, string nome, decimal preco, int quantidadeEmEstoque)
    {
        Codigo = codigo;
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

public class GerenciadorDeProdutos
{
    private List<Produto> produtos;

    public GerenciadorDeProdutos()
    {
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(int codigo, string nome, decimal preco, int quantidadeEmEstoque)
    {
        produtos.Add(new Produto(codigo, nome, preco, quantidadeEmEstoque));
    }

    public void ApresentarProdutos()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
        }
    }

    public string ConsultarProdutoPorCodigo(int codigo)
    {
        for(int i = 0; i < produtos.Count; i++)
        {
            if(codigo == produtos[i].Codigo)
            {
                return $"Produto encontrado - Código: {produtos[i].Codigo}, Nome: {produtos[i].Nome}, Preço: {produtos[i].Preco}, Quantidade em Estoque: {produtos[i].QuantidadeEmEstoque}";
            }
        }
        return $"Produto com código {codigo} não encontrado.";
    }
}