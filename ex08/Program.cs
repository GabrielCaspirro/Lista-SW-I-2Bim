class Program
{
    static void Main(string[] args)
    {
        Fabricante fabricante = new Fabricante("Nissan", "Rua Alvarenga, 123", "São Bernardo do Campo");
        Produto produto = new Produto("Carro", fabricante, 100000.00);

        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
        Console.WriteLine($"Preço: R${produto.Preco}");
    }
}