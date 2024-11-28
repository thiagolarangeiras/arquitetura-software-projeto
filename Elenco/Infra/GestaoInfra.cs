using Elenco.Models;
using System.Collections.Specialized;
using System.Web;

namespace Elenco.Infra;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
    public int Nota { get; set; }
}
public static class GestaoInfra
{
    private static string Url = "http://localhost:5001";
    private static Filme Request(string uri)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
            Headers =
        {
            { "accept", "application/json" },
        },
        };
        using (HttpResponseMessage response = client.SendAsync(request).Result)
        {
            response.EnsureSuccessStatusCode();
            return response.Content.ReadFromJsonAsync<Filme>().Result;
        }
        //    throw new TmdbServerOffException(e.getMessage());
    }

    public static Filme GetMovie(int id)
    {
        string uri = Url + "/filme/" + id.ToString();
        return Request(uri);
    }
}