namespace Gestao.Infra;

public class Atores
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly Nascimento { get; set; }
    public DateOnly Morte { get; set; }
    public string Genero { get; set; }
    public string Nacionalidade { get; set; }
}
    public static class ElencoInfra
{
    private static string Url = "http://localhost:5002";
    private static List<Atores> Request(string uri)
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
            return response.Content.ReadFromJsonAsync<List<Atores>>().Result;
        }
    }

    public static List<Atores> Get(int id)
    {
        string uri = $"{Url}/atores?page=0&count=50&movie-id={id}";
        return Request(uri);
    }
}