using GithubPortfolio.Core.Interfaces.Services;
using Newtonsoft.Json;

namespace GithubPortfolio.ApplicationService.Services;

public class HttpService : IHttpService
{
    private const string _mediaType = "application/json";
    private HttpClient _httpClient { get; set; } = new HttpClient();

    private bool _isLoading { get; set; }
    public bool IsLoading
    {
        get
        {
            return _isLoading;
        }
    }

    public event EventHandler? UnauthorizedStatus;

    public async Task<T> RequestAsync<T>(Func<Task<HttpResponseMessage>> requestAction)
    {
        var result = new HttpResponseMessage();

        try
        {
            _isLoading = true;

            result = await requestAction();

        }
        catch (Exception ex)
        {

        }
        finally
        {
            _isLoading = false;
        }

        return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
    }

    public async Task<HttpResponseMessage> GetAsync(string request, string query = "")
    {
        return await _httpClient.GetAsync(string.Concat(request, query));
    }

    public async Task<HttpResponseMessage> PostAsync(string request, string jsonString)
    {
        return await _httpClient.PostAsync(request, ConvertStringToStringContent(jsonString));
    }

    private StringContent ConvertStringToStringContent(string jsonString)
    {
        return new StringContent(jsonString is null ? string.Empty : jsonString, System.Text.Encoding.Default, _mediaType);
    }
}
