using MemoryGame.Web.Shared.Models;

namespace MemoryGame.Web.Features.Scores.GetScores;

public class GetScoresResponse
{
    public IReadOnlyList<Score> Scores { get; set; } = [];
}
