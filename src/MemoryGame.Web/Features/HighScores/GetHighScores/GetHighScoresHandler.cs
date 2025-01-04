using MemoryGame.Web.Data.Contexts;
using MemoryGame.Web.Features.HighScores.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Features.HighScores.GetHighScores;

public class GetHighScoresHandler(IDbContextFactory<MemoryGameDbContext> contextFactory)
{
    public async Task<GetHighScoresResponse> Handle(GetHighScoresRequest request)
    {
        using var context = await contextFactory.CreateDbContextAsync();

        var scores = await context.Scores
            .OrderByDescending(s => s.TotalScore)
            .ThenByDescending(s => s.Difficulty)
            .ThenBy(s => s.Moves)
            .ThenBy(s => s.TimeTakenInSeconds)
            .ThenBy(s => s.DatePlayed)
            .Take(request.AmountOfHighScores)
            .ToListAsync();

        var highScores = scores.Select((s, i) => new HighScore(i + 1, s.Username, s.TotalScore, s.Difficulty)).ToList();

        return new GetHighScoresResponse { HighScores = highScores };
    }
}
