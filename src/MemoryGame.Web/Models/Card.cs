namespace MemoryGame.Web.Models;

public class Card
{
    private Card(Guid id, string front)
    {
        Id = id;
        Front = front;
        Back = "?";
        IsMatched = false;
        IsSelected = false;
    }

    public Guid Id { get; private set; }

    public string Front { get; private set; } = "*";

    public string Back { get; private set; } = "?";

    public bool IsMatched { get; private set; }

    public bool IsSelected { get; private set; }

    public static Card[] CreatePair(string front)
    {
        var id = Guid.NewGuid();
        return [new Card(id, front), new Card(id, front)];
    }

    public void SelectCard()
    {
        IsSelected = !IsSelected;
    }

    public void MatchCard()
    {
        IsMatched = true;
    }
}
