using MemoryGame.Web.Enums;

namespace MemoryGame.Web.Models;

public class Game
{
    public Guid Id { get; set; }

    public GameDifficulty Difficulty { get; private set; } = GameDifficulty.Normal;

    public Board? Board { get; private set; }

    public int Moves { get; set; } = 0;

    public int TimeInSeconds { get; set; } = 0;

    public bool IsStarted { get; set; } = false;

    public bool IsFinished { get; set; } = false;

    public void ChangeDifficulty(GameDifficulty difficulty)
    {
        this.Difficulty = difficulty;
        this.Board = new Board(difficulty);
    }
}
