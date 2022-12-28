using GithubPortfolio.Core.Attributes;
using GithubPortfolio.Core.Strategies;
using System.ComponentModel;

namespace GithubPortfolio.Core.Enums;

public enum ESection
{
    [ContentStrategy(nameof(HomeSection))]
    [Description("Home")]
    Home,

    [ContentStrategy(nameof(MainSkillsSection))]
    [Description("Main Skills")]
    MainSkills,

    [ContentStrategy(nameof(ProjectsSection))]
    [Description("Projects")]
    Projects,

    [ContentStrategy(nameof(ContactSection))]
    [Description("Contact")]
    Contact
}
