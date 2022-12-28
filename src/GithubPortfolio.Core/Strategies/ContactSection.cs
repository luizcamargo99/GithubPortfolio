using GithubPortfolio.Core.Enums;
using GithubPortfolio.Core.Helpers;
using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class ContactSection : IContentStrategy
{
    private string _id { get { return "contact"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        string items = GetContactItems(user);

        return string.IsNullOrEmpty(items) ? string.Empty : $"""
                <div class="section" id="{_id}" 
                style="
                margin: 0rem 0;
                gap: 2rem;                 
                padding: 4rem 0;     
                background: #6e07f37d;">
                    <h2 style="font-size: 2.5rem;"> Contact </h2>
                    <div style="display: flex;
                    justify-content: center;
                    align-items: center;
                    flex-wrap: wrap;
                    gap: 2rem;
                    font-size: 1.2rem;">
                      {items}
                    </div>
                </div>  
                """;
    }

    private string GetContactItems(User user)
    {
        string content = string.Empty;

        foreach (var contactItem in Enum.GetValues<EContactItem>())
        {
            var strategy = contactItem.GetContentStrategy();
            content += strategy.CreateContent(user);
        }

        return content;

    }
}
