using System;

namespace CarroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Fusca", 1975);

            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear(); 

            Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}, Velocidade: {meuCarro.Velocidade} km/h");
        }
    }
}