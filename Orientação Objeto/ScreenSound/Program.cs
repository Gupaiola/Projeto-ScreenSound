Episodios ep1 = new("Conversando com Guguinha", 51, 1);
ep1.AdicionarConvidados("Del");
ep1.AdicionarConvidados("Adriano");
ep1.AdicionarConvidados("Sheila.");

Episodios ep2 = new("Conversa com Cris", 55, 2);
ep2.AdicionarConvidados("Messi");
ep2.AdicionarConvidados("Neymar");
ep2.AdicionarConvidados("Salah.");


PodCast podcast = new("Gustavo Paiola", "PodGuga");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();

