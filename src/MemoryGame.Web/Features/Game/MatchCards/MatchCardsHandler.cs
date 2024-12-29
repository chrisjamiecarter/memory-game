namespace MemoryGame.Web.Features.Game.MatchCards;

public class MatchCardsHandler
{
    public Task<MatchCardsResponse> Handle(MatchCardsRequest request)
    {
        return Task.FromResult(new MatchCardsResponse { IsMatch = request.FirstCardId == request.SecondCardId });
    }
}
