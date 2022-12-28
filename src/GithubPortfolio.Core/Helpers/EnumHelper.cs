using GithubPortfolio.Core.Attributes;
using GithubPortfolio.Core.Interfaces.Strategies;
using System.ComponentModel;

namespace GithubPortfolio.Core.Helpers;

public static class EnumHelper
{
    public static string ToDescription<TEnum>(this TEnum enumValue) where TEnum : struct
    {
        return typeof(TEnum).GetMember(enumValue.ToString())
             .SelectMany(member => member.GetCustomAttributes(typeof(DescriptionAttribute), true).Cast<DescriptionAttribute>()).FirstOrDefault().Description;
    }

    public static IContentStrategy GetContentStrategy<TEnum>(this TEnum enumValue) where TEnum : struct
    {
        return typeof(TEnum).GetMember(enumValue.ToString())
             .SelectMany(member => member.GetCustomAttributes(typeof(ContentStrategyAttribute), true).Cast<ContentStrategyAttribute>()).FirstOrDefault().SectionStrategy;
    }
}
