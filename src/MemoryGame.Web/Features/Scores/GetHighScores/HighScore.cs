using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Scores.GetHighScores;

public class HighScore
{
    public int Rank { get; set; }

    public string Username { get; set; } = string.Empty;

    public GameDifficulty Difficulty { get; set; }

    public int Moves { get; set; }

    public int TimeTakenInSeconds { get; set; }

    public int TotalScore { get; set; }

    public DateTime DatePlayed { get; set; }
}
