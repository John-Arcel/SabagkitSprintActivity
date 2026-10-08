using System.ComponentModel.DataAnnotations;

namespace SabagkitSprintActivity.Models;

public class UserModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Username is required.")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Username must be 3-30 characters.")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; } = string.Empty;

    public string Role { get; set; } = "Runner";
    public string AvatarUrl { get; set; } = "/images/default-avatar.png";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<PostModel> Posts { get; set; } = new();
    public List<CommentModel> Comments { get; set; } = new();
    public List<MeetupRsvpModel> Rsvps { get; set; } = new();
}