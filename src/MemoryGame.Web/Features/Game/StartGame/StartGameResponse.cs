using MemoryGame.Web.Shared.Models;

namespace MemoryGame.Web.Features.Game.StartGame;

/// <summary>
/// Represents the response for starting a new game, including the initialized game board 
/// and the timestamp when the game started.
/// </summary>
public class StartGameResponse
{
    public Board? Board { get; set; }

    public DateTime StartedTime { get; set; }
}
