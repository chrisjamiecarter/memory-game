using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Game.FinishGame;

public class FinishGameRequest
{
    public GameDifficulty Difficulty { get; set; }

    public TimeSpan ElapsedTime { get; set; }

    public int Moves { get; set; }
}
