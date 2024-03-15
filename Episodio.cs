namespace ScreenSound
{
    public class Episodio
    {
        public Episodio(string titulo, int ordem, int duracao)
        {
            Titulo = titulo;
            Ordem = ordem;
            Duracao = duracao;
        }

        public string Titulo { get;}
        public int Ordem { get;}
        public int Duracao { get;}

        private List<string> convidados = new();
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - " +
            $"{string.Join(", ", convidados)}";

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }


    }
}