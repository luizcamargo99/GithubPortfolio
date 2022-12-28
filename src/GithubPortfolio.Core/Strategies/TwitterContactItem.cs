using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class TwitterContactItem : IContentStrategy
{
    private string _id { get { return "twitter"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return string.IsNullOrEmpty(user.Twitter) ? string.Empty : $"""
                <div class="contact-item" id="{_id}">
                    <a href="https://twitter.com/{user.Twitter}" target="_blank"> Follow me on Twitter </a>
                </div>
            """;
    }

}
