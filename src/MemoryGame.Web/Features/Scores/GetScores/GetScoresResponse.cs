using MemoryGame.Web.Shared.Models;

namespace MemoryGame.Web.Features.Scores.GetScores;

/// <summary>
/// Represents the response containing a list of scores retrieved from the database, 
/// based on the specified filters and sorting criteria.
/// </summary>
public class GetScoresResponse
{
    public IReadOnlyList<Score> Scores { get; set; } = [];
}
