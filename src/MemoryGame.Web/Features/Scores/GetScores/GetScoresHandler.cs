using MemoryGame.Web.Data.Contexts;
using MemoryGame.Web.Features.Scores.Enums;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Features.Scores.GetScores;

/// <summary>
/// Handles the retrieval of scores from the database, applying various filters and sorting options 
/// based on username, difficulty, date, and other score-related criteria.
/// </summary>
public class GetScoresHandler(IDbContextFactory<MemoryGameDbContext> contextFactory)
{
    public async Task<GetScoresResponse> Handle(GetScoresRequest request)
    {
        using var context = await contextFactory.CreateDbContextAsync();

        var query = context.Scores.AsQueryable();

        if (request.UsernameFilter != null)
        {
            query = query.Where(s => EF.Functions.Like(s.Username, $"%{request.UsernameFilter}%"));
        }

        if (request.DifficultyFilter != null)
        {
            query = query.Where(s => s.Difficulty == request.DifficultyFilter);
        }

        if (request.DateFromFilter != null)
        {
            query = query.Where(s => s.DatePlayed >= request.DateFromFilter);
        }

        if (request.DateToFilter != null)
        {
            query = query.Where(s => s.DatePlayed <= request.DateToFilter);
        }

        query = request.OrderBy switch
        {
            ScoresOrderBy.UsernameAscending => query.OrderBy(s => s.Username),
            ScoresOrderBy.UsernameDescending => query.OrderByDescending(s => s.Username),
            ScoresOrderBy.DifficultyAscending => query.OrderBy(s => s.Difficulty),
            ScoresOrderBy.DifficultyDescending => query.OrderByDescending(s => s.Difficulty),
            ScoresOrderBy.MovesAscending => query.OrderBy(s => s.Moves),
            ScoresOrderBy.MovesDescending => query.OrderByDescending(s => s.Moves),
            ScoresOrderBy.TimeTakenInSecondsAscending => query.OrderBy(s => s.TimeTakenInSeconds),
            ScoresOrderBy.TimeTakenInSecondsDescending => query.OrderByDescending(s => s.TimeTakenInSeconds),
            ScoresOrderBy.TotalScoreAscending => query.OrderBy(s => s.TotalScore),
            ScoresOrderBy.TotalScoreDescending => query.OrderByDescending(s => s.TotalScore),
            ScoresOrderBy.DatePlayedAscending => query.OrderBy(s => s.DatePlayed),
            ScoresOrderBy.DatePlayedDescending => query.OrderByDescending(s => s.DatePlayed),
            _ => query.OrderByDescending(s => s.DatePlayed),
        };

        var scores = await query.ToListAsync();

        return new GetScoresResponse { Scores = scores };
    }
}
