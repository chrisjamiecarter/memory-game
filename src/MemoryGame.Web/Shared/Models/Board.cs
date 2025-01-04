using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Shared.Models;

public class Board
{
    public List<Card> Cards { get; set; } = [];

    public GameDifficulty Difficulty { get; set; } = GameDifficulty.Normal;
}
