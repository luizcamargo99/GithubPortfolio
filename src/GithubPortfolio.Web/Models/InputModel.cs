namespace GithubPortfolio.Web.Models;

public class InputModel
{
    public required string Id { get; set; }
    public string Value { get; set; } = null!;
    public string HtmlClass { get; set; } = string.Empty;
    public required string Name { get; set; }
    public required bool IsMandatory { get; set; }
}
