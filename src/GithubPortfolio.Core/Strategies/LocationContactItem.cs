using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class LocationContactItem : IContentStrategy
{
    private string _id { get { return "location"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return string.IsNullOrEmpty(user.Location) ? string.Empty : $"""
                <div class="contact-item" id="{_id}">
                    <span> I'm living in {user.Location} </span>
                </div>
            """;
    }

}
