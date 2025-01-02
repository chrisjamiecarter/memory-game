using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Scores.SaveScore;

public class SaveScoreHandler
{
    private readonly static double _basePoints = 10_000.0;
    private readonly static double _movePenalty = 1.0;

    public Task<SaveScoreResponse> Handle(SaveScoreRequest request)
    {
        double difficultyMultiplier = GetDifficultyMultiplier(request.Difficulty);
        double score = Math.Max(_basePoints * difficultyMultiplier / (request.ElapsedTime.TotalSeconds + request.Moves * _movePenalty), 0);

        return Task.FromResult(new SaveScoreResponse
        {
            Username = request.Username,
            Score = Convert.ToInt32(score)
        });
    }

    private static double GetDifficultyMultiplier(GameDifficulty difficulty)
    {
        return difficulty switch
        {
            GameDifficulty.Easy => 0.75,
            GameDifficulty.Hard => 1.5,
            _ => 1.0,
        };
    }
}
