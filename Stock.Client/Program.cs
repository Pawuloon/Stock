using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Stock;
using Stock.Server;
using Stock.Server.Controllers;
using Stock.Server.Data;
using Stock.Server.Services;
using Syncfusion.Blazor.Charts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<StockDbContext>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PolygonService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddTransient<StockDbContext>();
builder.Services.AddScoped<SfStockChart>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();