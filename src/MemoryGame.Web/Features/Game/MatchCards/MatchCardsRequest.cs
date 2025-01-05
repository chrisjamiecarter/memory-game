namespace MemoryGame.Web.Features.Game.MatchCards;

/// <summary>
/// Represents the request to check if two specified cards form a matching pair, identified by their unique IDs.
/// </summary>
public class MatchCardsRequest
{
    public Guid FirstCardId { get; set; }

    public Guid SecondCardId { get; set; }
}
