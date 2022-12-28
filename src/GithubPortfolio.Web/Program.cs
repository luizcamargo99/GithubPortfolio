using GithubPortfolio.ApplicationService.Services;
using GithubPortfolio.Core.Interfaces.Services;
using GithubPortfolio.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<IGithubService, GithubService>();

await builder.Build().RunAsync();
