namespace MemoryGame.Web.Models;

public class Board
{
    private readonly int _size = 2;

    public Board()
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Cards.Add(Card.Create("*"));
            }
        }

        Cards = [.. Cards.OrderBy(x => Random.Shared.Next())];
    }

    public List<Card> Cards { get; set; } = [];
}
