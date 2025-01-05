namespace MemoryGame.Web.Features.Scores.SaveScore;

/// <summary>
/// Represents the response after attempting to save a score, including a success indicator 
/// and an optional message with additional information.
/// </summary>
public class SaveScoreResponse
{
    public bool IsSuccess { get; set; }
    
    public string Message { get; set; } = string.Empty;
}
