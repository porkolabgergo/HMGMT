using HMGMT.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestSharp;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzQ2NTc1QDMyMzAyZTMzMmUzMGU1ejNJbWhqSFdvRWhwb2hwekZWVnBFdjJ2V0tITE9EVVJsaWIzcUVkQlE9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://10.0.0.224/") });
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
