class PodCast
{
    private List<Episodios> episodios = new();

    public PodCast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get;  }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodios(Episodios episodio) => episodios.Add(episodio);

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome}, apresentado por: {Host}.\n");
        foreach (Episodios episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este Podcast possui {TotalEpisodios} episodios.");
    }
}