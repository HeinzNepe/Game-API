namespace Game_API.Models;

public class Score
{
    public int Id { get; set; }
    public User User { get; set; } = null!;
    public int Points { get; set; }
    public DateTime TimeStamp { get; set; }
}