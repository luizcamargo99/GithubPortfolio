using GithubPortfolio.Core.Attributes;
using GithubPortfolio.Core.Strategies;

namespace GithubPortfolio.Core.Enums;

public enum EContactItem
{
    [ContentStrategy(nameof(CompanyContactItem))]
    Company,

    [ContentStrategy(nameof(BlogContactItem))]
    Blog,

    [ContentStrategy(nameof(LocationContactItem))]
    Location,

    [ContentStrategy(nameof(TwitterContactItem))]  
    Twitter
}
