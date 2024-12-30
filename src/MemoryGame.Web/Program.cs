using MemoryGame.Web.Features.Game.FinishGame;
using MemoryGame.Web.Features.Game.MatchCards;
using MemoryGame.Web.Features.Game.StartGame;
using MemoryGame.Web.Features.Scores.SaveScore;
using MemoryGame.Web.Shared.Components;

namespace MemoryGame.Web;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddScoped<FinishGameHandler>();
        builder.Services.AddScoped<MatchCardsHandler>();
        builder.Services.AddScoped<SaveScoreHandler>();
        builder.Services.AddScoped<StartGameHandler>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
