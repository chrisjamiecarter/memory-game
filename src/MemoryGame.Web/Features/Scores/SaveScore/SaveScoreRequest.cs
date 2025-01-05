using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.Scores.SaveScore;

/// <summary>
/// Represents the request to save a new score, including details such as the date played, 
/// difficulty level, moves, time taken, total score, and the player's username.
/// </summary>
public class SaveScoreRequest
{
    public DateTime DatePlayed { get; set; }

    public GameDifficulty Difficulty { get; set; }

    public int Moves { get; set; }

    public int TimeTakenInSeconds { get; set; }

    public int TotalScore { get; set; }

    public string Username { get; set; } = string.Empty;
}
