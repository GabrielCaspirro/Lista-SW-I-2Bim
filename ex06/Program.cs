class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

        gerenciador.AdicionarProduto(1, "Caneta", 2.5m, 10);
        gerenciador.AdicionarProduto(2, "Caderno", 10m, 5);
        gerenciador.AdicionarProduto(3, "Borracha", 1.5m, 20);

        Console.WriteLine("Produtos disponíveis:");
        gerenciador.ApresentarProdutos();

        int codigoProduto = 2;
        Console.WriteLine(gerenciador.ConsultarProdutoPorCodigo(codigoProduto));
    }
}