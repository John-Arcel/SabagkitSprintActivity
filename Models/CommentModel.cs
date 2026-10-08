using System.ComponentModel.DataAnnotations;

namespace SabagkitSprintActivity.Models;

public class CommentModel
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public PostModel? Post { get; set; }

    public int AuthorId { get; set; }
    public UserModel? Author { get; set; }

    [Required(ErrorMessage = "Comment cannot be empty.")]
    [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
    public string Content { get; set; } = string.Empty;

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsEdited => UpdatedAt.HasValue;
}