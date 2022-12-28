using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class CompanyContactItem : IContentStrategy
{
    private string _id { get { return "company"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return string.IsNullOrEmpty(user.Company) ? string.Empty : $"""
                <div class="contact-item" id="{_id}">
                    <span> Working at {user.Company} </span>
                </div>
            """;
    }

}
