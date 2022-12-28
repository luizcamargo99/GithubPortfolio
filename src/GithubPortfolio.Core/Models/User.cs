using Newtonsoft.Json;

namespace GithubPortfolio.Core.Models;

public class User
{
    [JsonProperty("login")]
    public required string Username { get; set; }

    [JsonProperty("name")]
    public required string Name { get; set; }

    [JsonProperty("bio")]
    public required string Bio { get; set; }

    [JsonProperty("avatar_url")]
    public required string AvatarUrl { get; set; }

    [JsonProperty("company")]
    public required string Company { get; set; }

    [JsonProperty("blog")]
    public required string Blog { get; set; }

    [JsonProperty("location")]
    public required string Location { get; set; }

    [JsonProperty("twitter_username")]
    public required string Twitter { get; set; }

    [JsonProperty("email")]
    public required string Email { get; set; }

    [JsonProperty("public_repos")]
    public required string PublicRepos { get; set; }

    [JsonProperty("created_at")]
    public required DateTime? CreatedAt { get; set; }

    public required List<Repository> Repositories { get; set; }

    public User()
    {
        Repositories = new();
    }
}
