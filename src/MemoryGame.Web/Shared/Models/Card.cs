using MemoryGame.Web.Shared.Components;

namespace MemoryGame.Web.Shared.Models;

/// <summary>
/// Represents a card on the game board, with properties for the front and back SVGs, 
/// selection and matching states, and a unique identifier. Provides methods for creating 
/// pairs of cards, selecting, and matching cards.
/// </summary>
public class Card
{
    private Card(Guid id, Type frontSvg)
    {
        Id = id;
        FrontSvg = frontSvg;
        BackSvg = typeof(QuestionSvg);
        IsMatched = false;
        IsSelected = false;
    }

    public Guid Id { get; private set; }

    public Type FrontSvg { get; private set; }

    public Type BackSvg { get; private set; }

    public bool IsMatched { get; private set; }

    public bool IsSelected { get; private set; }

    public static Card[] CreatePair(Type frontSvg)
    {
        var id = Guid.NewGuid();
        return [new Card(id, frontSvg), new Card(id, frontSvg)];
    }

    public void SelectCard()
    {
        IsSelected = !IsSelected;
    }

    public void MatchCard()
    {
        IsSelected = false;
        IsMatched = true;
    }
}
