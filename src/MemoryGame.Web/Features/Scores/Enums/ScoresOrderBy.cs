namespace MemoryGame.Web.Features.Scores.Enums;

/// <summary>
/// Represents the possible sorting options for high scores, including different criteria 
/// such as username, difficulty, moves, time taken, total score, and date played, 
/// with options for ascending or descending order.
/// </summary>
public enum ScoresOrderBy
{
    UsernameAscending,
    UsernameDescending,
    DifficultyAscending,
    DifficultyDescending,
    MovesAscending,
    MovesDescending,
    TimeTakenInSecondsAscending,
    TimeTakenInSecondsDescending,
    TotalScoreAscending,
    TotalScoreDescending,
    DatePlayedAscending,
    DatePlayedDescending,
}
