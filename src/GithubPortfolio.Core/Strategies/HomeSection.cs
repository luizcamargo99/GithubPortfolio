using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class HomeSection : IContentStrategy
{
    private const string _defaultBio = "I'm practicing and programming on Github";
    private string _id { get { return "skills"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return $"""
                <div class="section" id="{_id}" style="margin: 10rem 0; gap: 2rem; margin: 10rem 0 0;">                   
                    <img src="{user.AvatarUrl}" alt="Profile Photo" class="circle"/>
                    <h2 class="text-primary" style="font-size: 3.5rem; word-break: break-word;"> HEY, I'M {user.Name?.ToUpper() ?? user.Username.ToUpper()} </h2>
                    <span style="font-size: 1.3rem;"> {user.Bio ?? _defaultBio} </span>                 
                    <img src="./images/banner.svg" alt="Banner" class="banner"style="width: 55rem; max-width: 55rem;"/>
                </div>  
                """;
    }
}
