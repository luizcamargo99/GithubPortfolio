using GithubPortfolio.Core.Constants;
using GithubPortfolio.Core.Interfaces.Services;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.ApplicationService.Services;

public class GithubService : IGithubService
{
    private readonly IHttpService _httpService;

    public GithubService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<User> GetUserAsync(string username)
    {
        return await _httpService.RequestAsync<User>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/users/{username}"));
    }
    public async Task<List<Repository>> GetUserRepositoriesAsync(string username, int page, int count)
    {
        return await _httpService.RequestAsync<List<Repository>>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/users/{username}/repos?page={page}&per_page={count}"));
    }

    public bool UserHasNoInformation(User user)
    {
        return user is not null && user.CreatedAt is null || (user?.PublicRepos is not null && int.Parse(user.PublicRepos) <= 0);
    }
}
