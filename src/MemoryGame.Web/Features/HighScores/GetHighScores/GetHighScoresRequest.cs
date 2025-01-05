namespace MemoryGame.Web.Features.HighScores.GetHighScores;

/// <summary>
/// Represents the request to fetch high scores, including the number of top scores to return.
/// </summary>
public class GetHighScoresRequest
{
    public int AmountOfHighScores { get; set; } = 10;
}
