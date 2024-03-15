namespace ScreenSound
{
    public class Musica
    {
        public Musica(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }

        public string Nome { get; set; }
        public Banda Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public Genero Genero { get; set; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Artista: {Artista.Nome}\n" +
                $"Duracao: {Duracao}\n" +
                $"{(Disponivel ? "Disponível no plano" : "Assine o plano Plus")}");
        }

        public void ExibirNomeEArtista()
        {
            Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
        }
    }
}
