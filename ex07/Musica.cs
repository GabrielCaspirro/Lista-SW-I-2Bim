using System;
using System.Collections.Generic;

class Musica
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Gravadora { get; set; }

    public Musica(string nome, string autor, string gravadora)
    {
        Nome = nome;
        Autor = autor;
        Gravadora = gravadora;
    }
}

class Playlist
{
    private List<Musica> musicas;
    private string donoPlaylist;
    private Random random;

    public Playlist(string dono)
    {
        musicas = new List<Musica>();
        donoPlaylist = dono;
        random = new Random();
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void TocarMusicaAleatoria()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("A playlist esta vazia.");
            return;
        }

        int indiceAleatorio = random.Next(musicas.Count);
        Musica musicaAleatoria = musicas[indiceAleatorio];
        Console.WriteLine($"Tocando \"{musicaAleatoria.Nome}\" por {musicaAleatoria.Autor}");
    }

    public void TocarMusica(int indice)
    {
        if (indice - 1 >= 0 && indice < musicas.Count)
        {
            Musica musica = musicas[indice - 1];
            Console.WriteLine($"Tocando \"{musica.Nome}\" por {musica.Autor}");
        }
        else
        {
            Console.WriteLine("Indice inválido.");
        }
    }
}