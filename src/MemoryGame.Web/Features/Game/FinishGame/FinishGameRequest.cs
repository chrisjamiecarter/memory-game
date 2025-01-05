using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.Game.FinishGame;

/// <summary>
/// Represents the input data required to calculate the final score for a completed game, 
/// including difficulty level, elapsed time, and number of moves.
/// </summary>

public class FinishGameRequest
{
    public GameDifficulty Difficulty { get; set; }

    public TimeSpan ElapsedTime { get; set; }

    public int Moves { get; set; }
}
