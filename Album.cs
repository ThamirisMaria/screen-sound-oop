﻿namespace ScreenSound
{
    public class Album
    {
        private List<Musica> musicas = new();
        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

        public void AdicionarMusica(Musica musica)
        { 
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}");
            foreach(var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal}");
        }
    }
}