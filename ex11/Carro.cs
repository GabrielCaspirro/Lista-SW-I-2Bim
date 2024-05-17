using System;

namespace CarroApp
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; private set; }
        
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; 
        }

        public void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine($"Acelerando... Velocidade atual: {Velocidade} km/h");
        }

        public void Frear()
        {
            Velocidade -= 10;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"Freando... Velocidade atual: {Velocidade} km/h");
        }
    }
}