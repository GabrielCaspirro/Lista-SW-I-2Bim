class Program
{
    static void Main(string[] args)
    {
        RegistroDeCompras registro = new RegistroDeCompras();

        registro.AdicionarCompra(new DateTime(2024, 5, 13), "Camisa", 29.99);
        registro.AdicionarCompra(new DateTime(2024, 5, 14), "Calça", 49.99);
        registro.AdicionarCompra(new DateTime(2024, 5, 15), "Meias", 9.99);

        registro.ListarCompras();
    }
}