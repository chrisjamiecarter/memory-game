using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.Game.StartGame;

public class StartGameRequest
{
    public GameDifficulty Difficulty { get; set; }
}
