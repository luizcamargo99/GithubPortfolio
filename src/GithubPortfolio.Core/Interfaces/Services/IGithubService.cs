using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Interfaces.Services;

public interface IGithubService
{
    Task<User> GetUserAsync(string username);
    Task<List<Repository>> GetUserRepositoriesAsync(string username, int page, int count);
    bool UserHasNoInformation(User user);
}
