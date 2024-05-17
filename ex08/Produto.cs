using System;

class Fabricante
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Fabricante(string nome, string endereco, string cidade)
    {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }
}

class Produto
{
    private string nome;
    private Fabricante fabricante;
    private double preco;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            }
            nome = value;
        }
    }

    public Fabricante Fabricante { get; set; }

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço do produto deve ser positivo.");
            }
            preco = value;
        }
    }

    public Produto(string nome, Fabricante fabricante, double preco)
    {
        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }
}