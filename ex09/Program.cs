class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso
        try
        {
            Livro livro = new Livro("", "Autor Teste");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Livro livro2 = new Livro("Título Teste", ""); 
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Livro livro3 = new Livro("Harry Potter", "J.K. Rowling");
        Console.WriteLine($"Título: {livro3.Titulo}, Autor: {livro3.Autor}");
    }
}