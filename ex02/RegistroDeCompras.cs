using System;
using System.Collections.Generic;

public class Compra
{
    public DateTime Data;
    public string Produto;
    public double Valor;

    public Compra(DateTime data, string produto, double valor)
    {
        Data = data;
        Produto = produto;
        Valor = valor;
    }
}

public class RegistroDeCompras
{
    private List<Compra> compras;

    public RegistroDeCompras()
    {
        compras = new List<Compra>();
    }

    public void AdicionarCompra(DateTime data, string produto, double valor)
    {
        Compra novaCompra = new Compra(data, produto, valor);
        compras.Add(novaCompra);
    }

    public void ListarCompras()
    {
        if (compras.Count == 0)
        {
            Console.WriteLine("Não há compras registradas.");
        }
        else
        {
            Console.WriteLine("Lista de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.Data.ToShortDateString()} - Produto: {compra.Produto} - Valor: {compra.Valor:C}");
            }
        }
    }
}