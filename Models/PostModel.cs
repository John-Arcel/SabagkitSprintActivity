using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SabagkitSprintActivity.Models;

public class PostModel
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public UserModel? Author { get; set; }

    [Required(ErrorMessage = "Post content cannot be empty.")]
    [StringLength(2000, ErrorMessage = "Content cannot exceed 2,000 characters.")]
    public string Content { get; set; } = string.Empty;

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public int Score { get; set; } = 0;
    public VoteDirection CurrentUserVote { get; set; } = VoteDirection.None;

    public bool IsPinned { get; set; } = false;
    public bool IsLocked { get; set; } = false;

    // Optional 1-to-1 training meetup
    public TrainingMeetupModel? MeetupDetails { get; set; }

    public List<CommentModel> Comments { get; set; } = new();

    [JsonIgnore]
    public bool IsMeetup => MeetupDetails is not null;

    [JsonIgnore]
    public int CommentCount => Comments.Count;
}