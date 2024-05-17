class Program
{
    static void Main(string[] args)
    {
        Animal cachorro = new Animal("Rex", "Cachorro", 3);
        cachorro.EmitirSom(); 

        Animal gato = new Animal("Whiskers", "Gato", 2);
        gato.EmitirSom(); 

        Animal passaro = new Animal("Piu", "Pássaro", 1);
        passaro.EmitirSom(); 
    }
}