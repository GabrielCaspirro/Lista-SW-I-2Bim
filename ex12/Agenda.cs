using System;
using System.Collections.Generic;

namespace AgendaApp
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}m";
        }
    }

    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
            Console.WriteLine($"Pessoa {nome} armazenada com sucesso.");
        }

        public void RemovePessoa(string nome)
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    pessoas.RemoveAt(i);
                    Console.WriteLine($"Pessoa {nome} removida com sucesso.");
                    return;
                }
            }
            Console.WriteLine($"Pessoa {nome} não encontrada.");
        }

        public Pessoa BuscaPessoa(string nome)
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return pessoas[i];
                }
            }
            return null;
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}