﻿using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies.Sections;

public class ProjectsSection : ISectionStrategy
{
    private string _id { get { return "projects"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return $"""
                <div class="section" id="{_id}" 
                style="
                margin: 0rem 0;
                gap: 2rem; 
                padding: 4rem 0;">
                    <h2 style="font-size: 2.5rem;"> Projects </h2>
                    <div style="display: flex;
                    justify-content: center;
                    align-items: center;
                    gap: 2rem;">
                        <div style="display: flex; flex-wrap: wrap; flex-direction: row; gap: 4rem; justify-content: center;">
                            {CreateProjectsContent(user.Repositories, 8)}
                        </div>                       
                    </div>
                     <div>
                          See {user.PublicRepos} public projects on Github
                     </div>
                </div> 
                """;

    }

    private string CreateProjectsContent(List<Repository> repositories, int take = 6)
    {
        var content = string.Empty;
        var topRepos = repositories.OrderByDescending(x => x.Description is not null).ThenByDescending(x => x.StarCount).ThenByDescending(x => x.PushedAt)
            .Where(x => x.Fork == false && x.Name.Length < 25 && x.Language is not null).Take(take).ToList();

        foreach (var repo in topRepos)
        {
            content += $"""
                        <div style="
                            display: flex;
                            flex-direction: column;
                            background: #6e07f37d;
                            width: 21rem;
                            gap: 2rem;
                            justify-content: flex-start;
                            padding: 2rem;
                            border-radius: 1rem;
                            border: 0.1rem solid var(--primaryColor) !important;">
                            <span style="font-size: 1.5rem; font-weight: bold; "> {repo.Name} </span>
                            <span> {repo.Description} </span>
                            <span style="text-decoration: underline;"> Main Stack: {repo.Language} </span>
                            <a href="{repo.Url}" target="_blank" style="color: var(--primaryColor)"> See the Source Code </a>                        
                        </div>
                        """;
        }

        return content;
    }
}
