class Program
{
    static void Main(string[] args)
    {
        Playlist minhaPlaylist = new Playlist("Eu");
        minhaPlaylist.AdicionarMusica(new Musica("Fly By Night", "Rush", "Gravadora 1"));
        minhaPlaylist.AdicionarMusica(new Musica("Close To The Edge", "Yes", "Gravadora 2"));
        minhaPlaylist.AdicionarMusica(new Musica("Epitaph", "King Crimson", "Gravadora 3"));

        minhaPlaylist.TocarMusicaAleatoria();
        minhaPlaylist.TocarMusicaAleatoria();
        minhaPlaylist.TocarMusica(1);
    }
}
