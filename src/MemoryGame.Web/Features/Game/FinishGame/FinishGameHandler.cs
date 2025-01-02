using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Game.FinishGame;

public class FinishGameHandler
{
    private readonly static double _basePoints = 5_000.0;

    public Task<FinishGameResponse> Handle(FinishGameRequest request)
    {
        double difficultyMultiplier = GetDifficultyMultiplier(request.Difficulty);
        double movePenaltyMultiplier = GetMovePenaltyMultiplier(request.Difficulty);
        double timePenaltyMultiplier = GetTimePenaltyMultiplier(request.Difficulty);

        double score = (_basePoints * difficultyMultiplier) / ((request.ElapsedTime.TotalSeconds * timePenaltyMultiplier) + (request.Moves * movePenaltyMultiplier));

        return Task.FromResult(new FinishGameResponse
        {
            Score = Math.Max(Convert.ToInt32(score), 0),
        });
    }

    private static double GetDifficultyMultiplier(GameDifficulty difficulty)
    {
        return difficulty switch
        {
            GameDifficulty.Easy => 1.0,
            GameDifficulty.Hard => 4.0,
            _ => 2.0,
        };
    }

    private static double GetMovePenaltyMultiplier(GameDifficulty difficulty)
    {
        return difficulty switch
        {
            GameDifficulty.Easy => 2.0,
            GameDifficulty.Hard => 0.5,
            _ => 1.0,
        };
    }

    private static double GetTimePenaltyMultiplier(GameDifficulty difficulty)
    {
        return difficulty switch
        {
            GameDifficulty.Easy => 2.0,
            GameDifficulty.Hard => 0.5,
            _ => 1.0,
        };
    }
}
