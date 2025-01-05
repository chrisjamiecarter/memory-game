namespace MemoryGame.Web.Features.Game.MatchCards;

/// <summary>
/// Handles the logic for determining whether two selected cards form a matching pair.
/// </summary>
public class MatchCardsHandler
{
    public Task<MatchCardsResponse> Handle(MatchCardsRequest request)
    {
        return Task.FromResult(new MatchCardsResponse { IsMatch = request.FirstCardId == request.SecondCardId });
    }
}
