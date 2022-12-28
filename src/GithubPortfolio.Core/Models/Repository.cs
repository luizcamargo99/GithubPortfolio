using Newtonsoft.Json;

namespace GithubPortfolio.Core.Models;

public class Repository
{

    [JsonProperty("name")]
    public required string Name { get; set; }

    [JsonProperty("description")]
    public required string Description { get; set; }

    [JsonProperty("fork")]
    public required bool Fork { get; set; }

    [JsonProperty("language")]
    public required string Language { get; set; }

    [JsonProperty("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    [JsonProperty("pushed_at")]
    public required DateTime PushedAt { get; set; }

    [JsonProperty("forks")]
    public required int ForkCount { get; set; }

    [JsonProperty("stargazers_count")]
    public required int StarCount { get; set; }

    [JsonProperty("html_url")]
    public required string Url { get; set; }    
}
