using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Shared.Models;

/// <summary>
/// Represents the game board, containing a list of cards and the difficulty level of the game.
/// </summary>
public class Board
{
    public List<Card> Cards { get; set; } = [];

    public GameDifficulty Difficulty { get; set; } = GameDifficulty.Normal;
}
