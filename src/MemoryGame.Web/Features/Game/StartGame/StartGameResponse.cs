using MemoryGame.Web.Shared.Models;

namespace MemoryGame.Web.Features.Game.StartGame;

public class StartGameResponse
{
    public Board? Board { get; set; }

    public DateTime StartedTime { get; set; }
}
