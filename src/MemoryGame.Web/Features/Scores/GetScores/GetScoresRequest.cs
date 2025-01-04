using MemoryGame.Web.Core.Enums;
using MemoryGame.Web.Features.Scores.Enums;

namespace MemoryGame.Web.Features.Scores.GetScores;

public class GetScoresRequest
{
    public string? UsernameFilter { get; set; }

    public GameDifficulty? DifficultyFilter { get; set; }

    public DateTime? DateFromFilter { get; set; }

    public DateTime? DateToFilter { get; set; }

    public ScoresOrderBy OrderBy { get; set; } = ScoresOrderBy.DatePlayedDescending;
}
