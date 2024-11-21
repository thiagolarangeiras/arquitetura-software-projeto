using System.Text.Json.Serialization;

namespace Gestao.Models.TmdbMovieDetailed;

public class Search
{
    public int movieId;

    [JsonPropertyName("language")]
    public string language = "en-US";
}

public class Result
{
    [JsonPropertyName("adult")]
    public bool Adult;

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath;

    [JsonPropertyName("belongs_to_collection")]
    public Object BelongsToCollection;

    [JsonPropertyName("budget")]
    public int Budget;

    [JsonPropertyName("genres")]
    public List<ResultGenre> Genres;

    [JsonPropertyName("homepage")]
    public string Homepage;

    [JsonPropertyName("id")]
    public int Id;

    [JsonPropertyName("imdb_id")]
    public string ImdbId;

    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry;

    [JsonPropertyName("original_language")]
    public string OriginalLanguage;

    [JsonPropertyName("original_title")]
    public string OriginalTitle;

    [JsonPropertyName("overview")]
    public string Overview;

    [JsonPropertyName("popularity")]
    public double Popularity;

    [JsonPropertyName("poster_path")]
    public string PosterPath;

    [JsonPropertyName("production_companies")]
    public List<ResultProductionCompany> ProductionCompanies;

    [JsonPropertyName("production_countries")]
    public List<ResultProductionCountry> ProductionCountries;

    [JsonPropertyName("release_date")]
    public string ReleaseDate;

    [JsonPropertyName("revenue")]
    public int Revenue;

    [JsonPropertyName("runtime")]
    public int Runtime;

    [JsonPropertyName("spoken_languages")]
    public List<ResultSpokenLanguage> SpokenLanguages;

    [JsonPropertyName("status")]
    public string Status;

    [JsonPropertyName("tagline")]
    public string Tagline;

    [JsonPropertyName("title")]
    public string Title;

    [JsonPropertyName("video")]
    public bool Video;

    [JsonPropertyName("vote_average")]
    public double VoteAverage;

    [JsonPropertyName("vote_count")]
    public int VoteCount;
}

public class ResultGenre
{
    [JsonPropertyName("id")]
    public int Id;

    [JsonPropertyName("name")]
    public string Name;
}

public class ResultProductionCompany
{
    [JsonPropertyName("id")]
    public int Id;

    [JsonPropertyName("logo_path")]
    public string LogoPath;

    [JsonPropertyName("name")]
    public string Name;

    [JsonPropertyName("origin_country")]
    public string OriginCountry;
}

public class ResultProductionCountry
{
    [JsonPropertyName("iso_3166_1")]
    public string Iso;

    [JsonPropertyName("name")]
    public string Name;
}

public class ResultSpokenLanguage
{
    [JsonPropertyName("english_name")]
    public string EnglishName;

    [JsonPropertyName("iso_639_1")]
    public string Iso;

    [JsonPropertyName("name")]
    public string Name;
}