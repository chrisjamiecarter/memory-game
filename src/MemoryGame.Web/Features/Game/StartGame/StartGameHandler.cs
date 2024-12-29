using MemoryGame.Web.Core.Enums;
using MemoryGame.Web.Core.Models;

namespace MemoryGame.Web.Features.Game.StartGame;

public class StartGameHandler
{
    private static readonly string[] _symbols = ["!", "$", "%", "*", "@", "#", "|", "~", "=", "+", "&", "£"];


    public Task<StartGameResponse> Handle(StartGameRequest request)
    {
        var pairs = request.Difficulty switch
        {
            GameDifficulty.Easy => 4,
            GameDifficulty.Normal => 8,
            GameDifficulty.Hard => 16,
            _ => throw new ArgumentException("Invalid difficulty")
        };

        var cards = Enumerable.Range(1, pairs)
                              .SelectMany(i => Card.CreatePair(_symbols[i]))
                              .OrderBy(_ => Random.Shared.Next())
                              .ToList();

        return Task.FromResult(new StartGameResponse
        {
            Board = new Board { Cards = cards }, //, Difficulty = request.Difficulty },
            StartedTime = DateTime.UtcNow
        });
    }
}
