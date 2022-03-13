namespace Game_API.Models.Requests;

public class GetScoresRequest
{
    public int ScoreId { get; set; }
    public string UserName { get; set; } = null!;
    public int Points { get; set; }
    public DateTime TimeStamp { get; set; }
}