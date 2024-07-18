using System.Text.Json;
using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync
        ("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasPreferidasDoMarcos = new MusicasPreferidas("Marcos");
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[5]);

        //musicasPreferidasDoMarcos.ExibirMuiscasFavoritas();

        //musicasPreferidasDoMarcos.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}