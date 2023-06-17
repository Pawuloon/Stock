using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Stock;
using Stock.Server;
using Stock.Server.Controllers;
using Stock.Server.Data;
using Stock.Server.Services;


namespace Stock
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            
            var apiUrl = Environment.GetEnvironmentVariable("API_URL");
            
            if (string.IsNullOrEmpty(apiUrl))
            {
                apiUrl = builder.HostEnvironment.BaseAddress;
            }

            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(apiUrl) });

            await builder.Build().RunAsync();
        }
    }
}




// var builder = WebApplication.CreateBuilder(args);
//
// // Add services to the container.
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();
// builder.Services.AddSingleton<StockDbContext>();
// builder.Services.AddScoped<UserService>();
//
// var app = builder.Build();
//
// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }
//
// app.UseHttpsRedirection();
//
// app.UseStaticFiles();
//
// app.UseRouting();
//
// app.MapBlazorHub();
// app.MapFallbackToPage("/_Host");
//
// app.Run();