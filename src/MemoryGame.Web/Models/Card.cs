namespace MemoryGame.Web.Models;

public class Card
{
    private Card(string front)
    {
        Id = Guid.NewGuid();
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

    public static Card Create(string front)
    {
        return new Card(front);
    }

    public void SelectCard()
    {
        IsSelected = !IsSelected;
    }
}
