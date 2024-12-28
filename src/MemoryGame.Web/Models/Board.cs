namespace MemoryGame.Web.Models;

public class Board
{
    private readonly int _size = 2;

    private readonly string[] _symbols = ["!", "$", "%", "*"];

    public Board()
    {
        for (int i = 0; i < _size; i++)
        {
            Cards.AddRange(Card.CreatePair(_symbols[i]));
        }

        Cards = [.. Cards.OrderBy(x => Random.Shared.Next())];
    }

    public List<Card> Cards { get; set; } = [];
}
