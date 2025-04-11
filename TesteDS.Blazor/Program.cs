using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using TesteDS.Blazor;
using TesteDS.Blazor.Services;
using TesteDS.Blazor.Services.Interfaces;
using TesteDS.Blazor.Utils;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var url = builder.Configuration["UrlAPI"];

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(url)
});

builder.Services.AddSingleton<ToastBase>();
builder.Services.AddScoped<DialogBase>();
builder.Services.AddScoped<HttpClientService>();

builder.Services.AddScoped<ITaskItemService, TaskItemService>();
builder.Services.AddScoped<IWorkerService, WorkerService>();

builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();
