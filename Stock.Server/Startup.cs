namespace Stock.Server;

public class Startup
{
    
        public void ConfigureServices(IServiceCollection services)
        {
            // Add any services that your application requires here.
            // For example, you might add a database context or a service that handles authentication.
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
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello, world!");
                });
            });
        } 
}



