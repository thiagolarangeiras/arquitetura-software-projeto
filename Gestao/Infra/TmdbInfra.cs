using Gestao.Models;
using Gestao.Models.TmdbMovieDetailed;
using System.Collections.Specialized;
using System.Web;

namespace Gestao.Services;

public static class TmdbInfra
{
    private static string Url = "https://api.themoviedb.org/3";
    private static string TmdbKey;

    private static string FormatUri(string endPoint, string[][] parametros)
    {
        endPoint += "?";
        foreach (string[] element in parametros)
        {
            if (string.IsNullOrWhiteSpace(element[1]))
                continue;
            endPoint += element[0] + "=" + element[1] + "&";
        }
        return endPoint;
    }

    private static HttpResponseMessage Request(string uri)
    {    
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
            Headers =
            {
                { "accept", "application/json" },
                { "Authorization", $"Bearer {TmdbKey}" },
            },
        };
        using (HttpResponseMessage response = client.SendAsync(request).Result)
        {
            response.EnsureSuccessStatusCode();
            return response;
        }
        //    throw new TmdbServerOffException(e.getMessage());
    }

    public static Result GetMovie(Search movieDetailsSearch)
    {
        string[][] param =
        [
            ["language", movieDetailsSearch.language]
        ];

        string uri = FormatUri("/movie/" + movieDetailsSearch.movieId.ToString(), param);
        return Request(uri).Content.ReadFromJsonAsync<Result>().Result;
    }

    public static List<TmdbMovieResultData> SearchMovie(TmdbMovieSearch movieSearch)
    {
        NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
        query["query"] = movieSearch.Title;
        query["include_adult"] = movieSearch.IncludeAdult.ToString();
        query["page"] = movieSearch.Page.ToString();
        query["language"] = movieSearch.Language;
        query["region"] = movieSearch.Region;
        query["year"] = movieSearch.Year;
        query["primary_release_year"] = movieSearch.PrimaryReleaseYear;

        string uri = $"/search/movie?{query}";
        return Request(uri).Content.ReadFromJsonAsync<TmdbMovieResult>().Result.Results; 
    }
    public static List<TmdbPersonResultData> SearchPerson(TmdbPersonSearch personSearch)
    {
        NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
        query["query"] = personSearch.Name;
        query["include_adult"] = personSearch.IncludeAdult.ToString();
        query["page"] = personSearch.Page.ToString();
        query["language"] = personSearch.Language;
        string uri = $"/search/person?{query}";
        return Request(uri).Content.ReadFromJsonAsync<TmdbPersonResult>().Result.Results;
    }
}