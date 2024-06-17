using BlazorApp;
using BlazorApp.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//configura��o do HTTP CLIENT para acessar as APIs
builder.Services.AddScoped(sp => new HttpClient());

//adicionando configura��es de inje��o de depend�ncia
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddTransient<AuthService>();

await builder.Build().RunAsync();
