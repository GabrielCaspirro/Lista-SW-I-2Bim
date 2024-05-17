using System;
using System.Collections.Generic;

namespace AgendaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda minhaAgenda = new Agenda();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura (em metros): ");
                        float altura = float.Parse(Console.ReadLine());
                        minhaAgenda.ArmazenaPessoa(nome, idade, altura);
                        break;

                    case "2":
                        Console.Write("Digite o nome da pessoa a ser removida: ");
                        nome = Console.ReadLine();
                        minhaAgenda.RemovePessoa(nome);
                        break;

                    case "3":
                        Console.Write("Digite o nome da pessoa a ser buscada: ");
                        nome = Console.ReadLine();
                        Pessoa pessoa = minhaAgenda.BuscaPessoa(nome);
                        if (pessoa != null)
                        {
                            Console.WriteLine("Pessoa encontrada: " + pessoa);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada.");
                        }
                        break;

                    case "4":
                        minhaAgenda.ImprimeAgenda();
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}