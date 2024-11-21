using System.Text.Json.Serialization;

namespace Gestao.Models;

public class TmdbMovieSearch
{
    [JsonPropertyName("title")]
    public string Title;

    [JsonPropertyName("include_adult")]
    public bool IncludeAdult = false;

    [JsonPropertyName("page")]
    public int Page = 1;

    [JsonPropertyName("language")]
    public string Language = "en-US";

    [JsonPropertyName("region")]
    public string Region;

    [JsonPropertyName("year")]
    public string Year;

    [JsonPropertyName("primary_release_year")]
    public string PrimaryReleaseYear;
}

public class TmdbMovieResult
{
    [JsonPropertyName("page")]
    public int page;

    [JsonPropertyName("results")]
    public List<TmdbMovieResultData> Results;

    [JsonPropertyName("total_pages")]
    public int TotalPages;

    [JsonPropertyName("total_results")]
    public int TotalResults;
}

public class TmdbMovieResultData
{
    [JsonPropertyName("adult")]
    public bool Adult;

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath;

    [JsonPropertyName("genre_ids")]
    public List<int> GenreIds;

    [JsonPropertyName("id")]
    public int Id;

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

    [JsonPropertyName("release_date")]
    public string ReleaseDate;

    [JsonPropertyName("title")]
    public string Title;

    [JsonPropertyName("video")]
    public bool Video;

    [JsonPropertyName("vote_average")]
    public double VoteAverage;

    [JsonPropertyName("vote_count")]
    public int VoteCount;
}