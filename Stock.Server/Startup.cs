using Stock.Server.Data;
using Stock.Server.Services;

namespace Stock.Server
{
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddScoped<UserService>();
            services.AddScoped<PolygonService>();
            services.AddScoped<StockDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello, world!");
                });
            });
        } 
    }
}





