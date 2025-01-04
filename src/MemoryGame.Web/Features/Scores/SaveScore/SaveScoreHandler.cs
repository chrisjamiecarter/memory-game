using MemoryGame.Web.Data.Contexts;
using MemoryGame.Web.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Features.Scores.SaveScore;

public class SaveScoreHandler(IDbContextFactory<MemoryGameDbContext> contextFactory)
{
    public async Task<SaveScoreResponse> Handle(SaveScoreRequest request)
    {
        try
        {
            using var context = await contextFactory.CreateDbContextAsync();

            var score = new Score
            {
                Id = Guid.CreateVersion7(),
                DatePlayed = request.DatePlayed,
                Difficulty = request.Difficulty,
                Moves = request.Moves,
                TimeTakenInSeconds = request.TimeTakenInSeconds,
                TotalScore = request.TotalScore,
                Username = request.Username,
            };

            await context.Scores.AddAsync(score);
            var result = await context.SaveChangesAsync();

            var isSuccess = result > 0;
            var message = string.Empty;
            if (!isSuccess)
            {
                message = $"Unable to add score";
            }

            return new SaveScoreResponse
            {
                IsSuccess = isSuccess,
                Message = message,
            };

        }
        catch (Exception exception)
        {
            return new SaveScoreResponse
            {
                IsSuccess = false,
                Message = exception.Message,
            };
        }
    }
}
