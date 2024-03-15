namespace ScreenSound
{
    class Podcast
    {
        public string Host { get; set; }
        public string Nome { get; set; }
        private List<Episodio> episodios = new List<Episodio>();
        public int TotalEpisodios => episodios.Count();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
            foreach (Episodio episodio in episodios.OrderBy(episodio => episodio.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\nTodal de episodios: {TotalEpisodios}");
        }
    }
}
