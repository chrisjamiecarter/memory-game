namespace MemoryGame.Web.Features.Scores.GetHighScores;

public class GetHighScoresResponse
{
    public IReadOnlyList<HighScore> HighScores { get; set; } = [];
}
