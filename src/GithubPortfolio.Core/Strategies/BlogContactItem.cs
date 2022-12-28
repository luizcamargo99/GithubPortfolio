using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class BlogContactItem : IContentStrategy
{
    private string _id { get { return "blog"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return string.IsNullOrEmpty(user.Blog) ? string.Empty : $"""
                <div class="contact-item" id="{_id}">
                    <a href="{user.Blog}" target="_blank"> {GetTextByString(user.Blog)} </a>
                </div>
            """;
    }

    private string GetTextByString(string blog)
    {
        if (blog.ToLower().Contains("linkedin"))
        {
            return "I'm on Linkedin!";
        }

        return "Follow my Website!";
    }

}
