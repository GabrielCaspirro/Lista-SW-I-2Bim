using System;
using System.Collections.Generic;

public class CorretoraDeImoveis
{
    public class Imovel
    {
        public string Endereco { get; set; }
        public decimal Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, decimal preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }

    private List<Imovel> imoveis;

    public CorretoraDeImoveis()
    {
        imoveis = new List<Imovel>();
    }

    public void InserirImovel(string endereco, decimal preco, string tipo)
    {
        Imovel novoImovel = new Imovel(endereco, preco, tipo);
        imoveis.Add(novoImovel);
    }

    public void AlterarPreco(string endereco, decimal novoPreco)
    {
        Imovel imovelEncontrado = imoveis.Find(imovel => imovel.Endereco == endereco);
        if (imovelEncontrado != null)
        {
            imovelEncontrado.Preco = novoPreco;
            Console.WriteLine($"Preco do imovel no endereco {endereco} alterado para {novoPreco:C}");
        }
        else
        {
            Console.WriteLine("Imovel nao encontrado.");
        }
    }

    public void ListarImoveisDisponiveis()
    {
        Console.WriteLine("Imoveis Disponiveis:");
        foreach (var imovel in imoveis)
        {
            Console.WriteLine($"Endereco: {imovel.Endereco} - Preco: {imovel.Preco:C} - Tipo: {imovel.Tipo}");
        }
    }

    public decimal CalcularValorMedio()
    {
        if (imoveis.Count == 0)
        {
            Console.WriteLine("Nao ha imoveis disponiveis para calcular o valor medio.");
            return 0;
        }

        decimal somaTotal = 0;
        foreach (var imovel in imoveis)
        {
            somaTotal += imovel.Preco;
        }

        return somaTotal / imoveis.Count;
    }
}

