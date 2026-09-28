namespace SabagkitSprintActivity.Models;

public class PostModel
{
    public string Author { get; set; } = "User";
    public string Content { get; set; } = "";
    public DateTime Timestamp { get; set; }
    public int Score { get; set; } = 0;
    public int UserVote { get; set; } = 0;
    public List<CommentModel> Comments { get; set; } = new();
}

public class CommentModel
{
    public string Author { get; set; } = "User";
    public string Content { get; set; } = "";
    public DateTime Timestamp { get; set; }
}