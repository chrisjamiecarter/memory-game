using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Scores.SaveScore;

public class SaveScoreRequest
{
    public string Username { get; set; } = string.Empty;

    public TimeSpan ElapsedTime { get; set; }

    public int Moves { get; set; }

    public GameDifficulty Difficulty { get; set; }
}
