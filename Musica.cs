namespace ScreenSound
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public Genero Genero { get; set; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Artista: {Artista}\n" +
                $"Duracao: {Duracao}\n" +
                $"{(Disponivel ? "Disponível no plano" : "Assine o plano Plus")}");
        }

        public void ExibirNomeEArtista()
        {
            Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
        }
    }
}
