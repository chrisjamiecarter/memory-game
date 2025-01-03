﻿using MemoryGame.Web.Core.Enums;

namespace MemoryGame.Web.Features.Scores.SaveScore;

public class SaveScoreRequest
{
    public DateTime DatePlayed { get; set; }

    public GameDifficulty Difficulty { get; set; }

    public int Moves { get; set; }

    public int TimeTakenInSeconds { get; set; }

    public int TotalScore { get; set; }

    public string Username { get; set; } = string.Empty;
}
