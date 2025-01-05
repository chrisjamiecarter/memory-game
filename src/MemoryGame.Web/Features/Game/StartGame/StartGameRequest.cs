using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.Game.StartGame;

/// <summary>
/// Represents the request to start a new game, specifying the desired difficulty level.
/// </summary>
public class StartGameRequest
{
    public GameDifficulty Difficulty { get; set; }
}
