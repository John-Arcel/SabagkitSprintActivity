namespace SabagkitSprintActivity.Models;

public class PostVoteModel
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }
    public int VoteValue { get; set; } // +1 or -1
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}