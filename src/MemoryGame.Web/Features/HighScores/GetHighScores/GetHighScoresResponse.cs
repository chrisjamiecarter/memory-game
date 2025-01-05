using MemoryGame.Web.Features.HighScores.Models;

namespace MemoryGame.Web.Features.HighScores.GetHighScores;

/// <summary>
/// Represents the response containing a list of high scores retrieved from the database.
/// </summary>
public class GetHighScoresResponse
{
    public IReadOnlyList<HighScore> HighScores { get; set; } = [];
}
