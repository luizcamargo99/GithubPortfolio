using Microsoft.AspNetCore.Components;

namespace GithubPortfolio.Web.Pages;

public class BasePage : ComponentBase
{
    private bool _isLoading = false;
    public bool IsLoading { get { return _isLoading; } }

    protected override void OnInitialized()
    {
        _isLoading = true;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
            _isLoading = false;
    }
}
