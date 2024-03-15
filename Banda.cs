﻿namespace ScreenSound
{
    public class Banda
    {
        private List<Album> albums = new();

        public Banda(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in albums)
            {
                Console.WriteLine($"Álbums: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
