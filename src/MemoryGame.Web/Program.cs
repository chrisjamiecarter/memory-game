using MemoryGame.Web.Data.Contexts;
using MemoryGame.Web.Features.Game.FinishGame;
using MemoryGame.Web.Features.Game.MatchCards;
using MemoryGame.Web.Features.Game.StartGame;
using MemoryGame.Web.Features.HighScores.GetHighScores;
using MemoryGame.Web.Features.Scores.GetScores;
using MemoryGame.Web.Features.Scores.SaveScore;
using MemoryGame.Web.Shared.Components;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("MemoryGame") ?? throw new InvalidOperationException("Connection string 'MemoryGame' not found.");
        builder.Services.AddDbContextFactory<MemoryGameDbContext>(options => options.UseSqlServer(connectionString));

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddScoped<FinishGameHandler>();
        builder.Services.AddScoped<GetHighScoresHandler>();
        builder.Services.AddScoped<GetScoresHandler>();
        builder.Services.AddScoped<MatchCardsHandler>();
        builder.Services.AddScoped<SaveScoreHandler>();
        builder.Services.AddScoped<StartGameHandler>();

        var app = builder.Build();

        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        using var context = services.GetRequiredService<MemoryGameDbContext>();
        context.Database.Migrate();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
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
