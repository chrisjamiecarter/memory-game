using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.HighScores.Models;

/// <summary>
/// Represents an individual high score, including the rank, username, score, and difficulty level.
/// </summary>
public record HighScore(int Rank, string Username, int Score, GameDifficulty Difficulty);
