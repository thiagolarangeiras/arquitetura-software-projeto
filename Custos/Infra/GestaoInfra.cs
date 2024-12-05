using Custos.Models;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Web;

namespace Elenco.Infra;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
    public int Nota { get; set; }
    public float vl_total { get; set; }
}
public static class GestaoInfra
{
    private static string Url = "http://localhost:5001";
    private static Filme Request(string uri, HttpMethod method, JsonContent json)
    {
        var client = new HttpClient();


        var request = new HttpRequestMessage
        {
            Method = method,
            RequestUri = new Uri(uri),
            Headers = {
                { "accept", "application/json" },
            },
        };

        if(method == HttpMethod.Patch){
            request.Content = json;
        }

        using (HttpResponseMessage response = client.SendAsync(request).Result)
        {
            response.EnsureSuccessStatusCode();
            return response.Content.ReadFromJsonAsync<Filme>().Result;
        }
        //    throw new TmdbServerOffException(e.getMessage());
    }

    public static Filme UpdateMoviePrecos(int id, decimal lucro, decimal vl_total) 
    {
        string uri = Url + "/filme/" + id.ToString() + "/custo";
        return Request(uri, HttpMethod.Patch, JsonContent.Create(new {Lucro = lucro, vl_total = vl_total}));
    }

    public static Filme GetMovie(int id)
    {
        string uri = Url + "/filme/" + id.ToString();
        return Request(uri, HttpMethod.Get, JsonContent.Create(new {}));
    }
}