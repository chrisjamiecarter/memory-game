using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Core.Models;

public class Board
{
    public List<Card> Cards { get; set; } = [];
    
    public GameDifficulty Difficulty {  get; set; } = GameDifficulty.Normal;
}
