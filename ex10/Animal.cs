using System;

class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, string especie, int idade)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
    }

    public void EmitirSom()
    {
        switch (Especie.ToLower())
        {
            case "cachorro":
                Console.WriteLine("Au Au!");
                break;
            case "gato":
                Console.WriteLine("Miau!");
                break;
            case "pássaro":
                Console.WriteLine("Piu Piu!");
                break;
            default:
                Console.WriteLine("Este animal não tem um som conhecido.");
                break;
        }
    }
}