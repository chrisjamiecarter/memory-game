using MemoryGame.Web.Features.HighScores.Models;

namespace MemoryGame.Web.Features.HighScores.GetHighScores;

public class GetHighScoresResponse
{
    public IReadOnlyList<HighScore> HighScores { get; set; } = [];
}
