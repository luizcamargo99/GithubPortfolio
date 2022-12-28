using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class MainSkillsSection : IContentStrategy
{
    private string _id { get { return "skills"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        string[] topLanguages = GetTopLanguages(user.Repositories);

        return $"""
                <div class="section" id="{_id}" 
                style="
                margin: 0rem 0;
                gap: 2rem;                 
                padding: 4rem 0;     
                background: #6e07f37d;">
                    <h2 style="font-size: 2.5rem;"> Main Skills </h2>
                    <div style="display: flex;
                    justify-content: center;
                    align-items: center;
                    flex-wrap: wrap;
                    gap: 2rem;">
                    {CreateLanguagesContent(topLanguages)}
                    </div>
                </div>  
                """;
    }

    private string CreateLanguagesContent(string[] languages)
    {
        string content = string.Empty;

        foreach (var language in languages)
        {
            content += $"""
                <a href="https://github.com/topics/{FormatLanguageName(language)}" target="_blank"> 
                    <div style="
                    background: #14e9562e;
                    color: var(--primaryColor);
                    border-radius: 2rem;
                    font-size: 1.5rem;
                    display: flex;
                    gap: 4rem;
                    flex-wrap: wrap;
                    justify-content: center;
                    align-items: center;
                    padding: 0.5rem 2rem; 
                    border: 0.1rem solid;"
                    class="hover-scale">
                        {language}
                     </div>  
                 </a>
                """;
        }

        return content;
    }

    private string FormatLanguageName(string language)
    {
        return language.Replace("+", "plus").Replace("#", "sharp").Replace(".", "dot");
    }

    private string[] GetTopLanguages(List<Repository> repositories, int take = 6)
    {
        var languages = repositories.Select(r => r.Language).Where(x => x is not null).ToList();
        Dictionary<string, int> topLanguages = new();

        foreach (var language in languages.Where(lang => topLanguages.Any(x => x.Key == lang) == false))
        {
            topLanguages.Add(language, languages.Count(x => x == language));
        }

        return topLanguages.Take(take).OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();
    }
}
