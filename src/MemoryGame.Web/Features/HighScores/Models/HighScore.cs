using MemoryGame.Web.Shared.Enums;

namespace MemoryGame.Web.Features.HighScores.Models;

public record HighScore(int Rank, string Username, int Score, GameDifficulty Difficulty);
