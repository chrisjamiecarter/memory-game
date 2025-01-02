using MemoryGame.Web.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Features.Scores.GetHighScores;

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

        var highScores = scores.Select((s, i) => new HighScore
        {
            Rank = i + 1,
            DatePlayed = s.DatePlayed,
            Difficulty = s.Difficulty,
            Moves = s.Moves,
            TimeTakenInSeconds = s.TimeTakenInSeconds,
            TotalScore = s.TotalScore,
            Username = s.Username,
        }).ToList();

        return new GetHighScoresResponse { HighScores = highScores };
    }
}
