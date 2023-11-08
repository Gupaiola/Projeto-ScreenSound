class Episodios
{
    private List<string> convidados = new List<string>();
    public Episodios(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}, {Titulo}, ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    { 
        convidados.Add(convidado);
    }
}