using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Shared.Models;

public class Score
{
    public required Guid Id { get; set; }

    public required string Username { get; set; }

    public required GameDifficulty Difficulty { get; set; }

    public required int Moves { get; set; }

    public required int TimeTakenInSeconds { get; set; }

    public required int TotalScore { get; set; }

    public required DateTime DatePlayed { get; set; }
}
