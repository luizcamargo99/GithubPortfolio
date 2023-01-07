namespace GithubPortfolio.Web.Models;

public class InputModel
{
    public required string Id { get; set; }
    public string Value { get; set; }
    public string HtmlClass { get; set; }
    public required string Name { get; set; }
    public required bool IsMandatory { get; set; }
}
