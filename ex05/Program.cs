

class Program {
    static void Main(string[] args) {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        gerenciador.AdicionarTarefa("Estudar para o exame", new DateTime(2024, 5, 17));
        gerenciador.AdicionarTarefa("Fazer compras", new DateTime(2024, 5, 16));

        gerenciador.Listar();

        Console.WriteLine(gerenciador.TarefaParaHoje("Fazer compras"));

        gerenciador.RemoverTarefa("Fazer compras");

        gerenciador.Listar();
    }
}