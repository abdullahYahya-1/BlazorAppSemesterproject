using BlazorAppProject.Data;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var hostContext = WebApplication.CreateBuilder(args);

        // Add services to the container.
        hostContext.Services.AddRazorPages();
        hostContext.Services.AddServerSideBlazor();
        hostContext.Services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(hostContext.Configuration.GetConnectionString("DevConnection")));

        var app = hostContext.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }


        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}