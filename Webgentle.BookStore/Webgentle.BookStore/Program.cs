namespace Webgentle.BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddControllersWithViews();

            builder.Services.AddMvc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First Middleware\n");
                await next();
                await context.Response.WriteAsync("Third Middleware\n");
            });*/

            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("second middleware\n");
                await next();
                await context.Response.WriteAsync("fourth middleware\n");
            });*/

            /*app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Fifth middleware\n");
                await next();
            });*/

            /*app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Testing\n");
                await next();
            });*/

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    var environment = context.RequestServices.GetRequiredService<IHostEnvironment>();
                    await context.Response.WriteAsync($"Hello world !!! Environment : {environment.EnvironmentName}");
                });
            });*/

            /*            app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapGet("/nitish", async context =>
                            {
                                await context.Response.WriteAsync("Hello world 11 !!!");
                            });
                        });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            app.Run();
        }
    }
}