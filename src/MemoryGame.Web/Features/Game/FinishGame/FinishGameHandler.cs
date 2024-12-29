namespace MemoryGame.Web.Features.Game.FinishGame;

public class FinishGameHandler
{
    public Task<FinishGameResponse> Handle(FinishGameRequest request)
    {
        return Task.FromResult(new FinishGameResponse
        {
            Moves = request.Moves,
            TimeElapsed = DateTime.UtcNow - request.StartedTime,
        });
    }
}
