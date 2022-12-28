using GithubPortfolio.Core.Interfaces.Strategies;
using System.Reflection;

namespace GithubPortfolio.Core.Attributes;

internal class ContentStrategyAttribute: Attribute
{
    private readonly IContentStrategy _sectionStrategy;

    public ContentStrategyAttribute(string sectionName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        string namespaceName = "Strategies";
        Type type = assembly.GetType($"{assembly.GetName().Name}.{namespaceName}.{sectionName}");
        _sectionStrategy = (IContentStrategy?)Activator.CreateInstance(type);
    }

    public IContentStrategy SectionStrategy { get { return _sectionStrategy; } }
}
