using MemoryGame.Web.Shared.Components;
using MemoryGame.Web.Shared.Enums;
using MemoryGame.Web.Shared.Models;

namespace MemoryGame.Web.Features.Game.StartGame;

/// <summary>
/// Handles the logic for initializing a new game session by creating a shuffled game board 
/// with card pairs based on the specified difficulty level.
/// </summary>
public class StartGameHandler
{
    private static readonly Type[] _svgs = 
    [
        typeof(AmazonSvg),
        typeof(AndroidSvg),
        typeof(AppleSvg),
        typeof(DiscordSvg),
        typeof(GoogleSvg),
        typeof(InstagramSvg),
        typeof(MetaSvg),
        typeof(MicrosoftSvg),
        typeof(NvidiaSvg),
        typeof(PlaystationSvg),
        typeof(RedditSvg),
        typeof(SnapchatSvg),
        typeof(SpotifySvg),
        typeof(SteamSvg),
        typeof(StravaSvg),
        typeof(TiktokSvg),
        typeof(TwitchSvg),
        typeof(TwitterXSvg),
        typeof(XboxSvg),
        typeof(YoutubeSvg),
    ];

    public Task<StartGameResponse> Handle(StartGameRequest request)
    {
        var shuffledSvgs = _svgs.OrderBy(_ => Random.Shared.Next()).ToList();

        var pairs = request.Difficulty switch
        {
            GameDifficulty.Easy => 4,
            GameDifficulty.Hard => 16,
            _ => 8,
        };

        var cards = Enumerable.Range(1, pairs)
                              .SelectMany(i => Card.CreatePair(shuffledSvgs[i - 1]))
                              .OrderBy(_ => Random.Shared.Next())
                              .ToList();

        return Task.FromResult(new StartGameResponse
        {
            Board = new Board { Cards = cards, Difficulty = request.Difficulty },
            StartedTime = DateTime.UtcNow
        });
    }
}
