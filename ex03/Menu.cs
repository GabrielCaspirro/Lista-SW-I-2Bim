using System;

public class Menu
{
    public void Interface()
    {
        CorretoraDeImoveis corretora = new CorretoraDeImoveis();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Inserir Imovel");
            Console.WriteLine("2. Alterar Preco do Imovel");
            Console.WriteLine("3. Listar Todos os Imoveis");
            Console.WriteLine("4. Calcular Valor Medio dos Imoveis");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opcao: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Endereco do Imovel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Preco do Imovel: ");
                    decimal preco = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Tipo do Imovel: ");
                    string tipo = Console.ReadLine();
                    corretora.InserirImovel(endereco, preco, tipo);
                    break;
                case "2":
                    Console.Write("Endereco do Imovel: ");
                    string enderecoAlterar = Console.ReadLine();
                    Console.Write("Novo Preco do Imovel: ");
                    decimal novoPreco = Convert.ToDecimal(Console.ReadLine());
                    corretora.AlterarPreco(enderecoAlterar, novoPreco);
                    break;
                case "3":
                    corretora.ListarImoveisDisponiveis();
                    break;
                case "4":
                    decimal valorMedio = corretora.CalcularValorMedio();
                    Console.WriteLine($"Valor Medio dos Imoveis: {valorMedio:C}");
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    break;
            }
        }
    }
}