using MemoryGame.Web.Enums;

namespace MemoryGame.Web.Models;

public class Board
{
    private readonly string[] _symbols = ["!", "$", "%", "*", "@", "#", "|", "~", "=", "+", "&", "£"];

    public Board(GameDifficulty difficulty)
    {
        int size = GetBoardSize(difficulty);

        for (int i = 0; i < size; i++)
        {
            Cards.AddRange(Card.CreatePair(_symbols[i]));
        }

        Cards = [.. Cards.OrderBy(x => Random.Shared.Next())];
    }

    public List<Card> Cards { get; set; } = [];

    private int GetBoardSize(GameDifficulty difficulty)
    {
        return difficulty switch
        {
            GameDifficulty.Easy => 6,
            GameDifficulty.Hard => 12,
            _ => 8,
        };
    }
}
