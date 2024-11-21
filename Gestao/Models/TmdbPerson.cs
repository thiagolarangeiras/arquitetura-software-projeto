using System.Text.Json.Serialization;

namespace Gestao.Models;

public class TmdbPersonSearch
{
    [JsonPropertyName("name")]
    public string Name;

    [JsonPropertyName("include_adult")]
    public bool IncludeAdult = false;

    [JsonPropertyName("page")]
    public int Page = 1;

    [JsonPropertyName("language")]
    public string Language = "en-US";
}

public class TmdbPersonResult
{
    [JsonPropertyName("page")]
    public int Page;

    [JsonPropertyName("results")]
    public List<TmdbPersonResultData> Results;

    [JsonPropertyName("total_pages")]
    public int TotalPages;

    [JsonPropertyName("total_results")]
    public int TotalResults;
}

public class TmdbPersonResultData
{
    [JsonPropertyName("adult")]
    public bool Adult;

    [JsonPropertyName("gender")]
    public int Gender;

    [JsonPropertyName("id")]
    public int Id;

    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment;

    [JsonPropertyName("name")]
    public string Name;

    [JsonPropertyName("original_name")]
    public string OriginalName;

    [JsonPropertyName("popularity")]
    public double Popularity;

    [JsonPropertyName("profile_path")]
    public string ProfilePath;

    [JsonPropertyName("known_for")]
    public List<TmdbPersonResultKnownfor> KnownFor;
}

public class TmdbPersonResultKnownfor
{
    [JsonPropertyName("backdrop_path")]
    public string BackdropPath;

    [JsonPropertyName("id")]
    public int Id;

    [JsonPropertyName("original_title")]
    public string OriginalTitle;

    [JsonPropertyName("overview")]
    public string Overview;

    [JsonPropertyName("poster_path")]
    public string PosterPath;

    [JsonPropertyName("media_type")]
    public string MediaType;

    [JsonPropertyName("adult")]
    public bool Adult;

    [JsonPropertyName("title")]
    public string Title;

    [JsonPropertyName("original_language")]
    public string OriginalLanguage;

    [JsonPropertyName("genre_ids")]
    public List<int> GenreIds;

    [JsonPropertyName("popularity")]
    public double Popularity;

    [JsonPropertyName("release_date")]
    public string ReleaseFate;

    [JsonPropertyName("video")]
    public bool Video;

    [JsonPropertyName("vote_average")]
    public double VoteAverage;

    [JsonPropertyName("vote_count")]
    public int VoteCount;

    [JsonPropertyName("original_name")]
    public string OriginalName;

    [JsonPropertyName("name")]
    public string Name;

    [JsonPropertyName("first_air_date")]
    public string FirstAirDate;

    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry;
}