using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Interfaces.Strategies;

public interface IContentStrategy
{
    string Id { get; }
    string CreateContent(User user);
}
