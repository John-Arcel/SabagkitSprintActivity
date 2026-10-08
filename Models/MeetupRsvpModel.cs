namespace SabagkitSprintActivity.Models;

public class MeetupRsvpModel
{
    public int Id { get; set; }
    public int MeetupId { get; set; }
    public TrainingMeetupModel? Meetup { get; set; }

    public int UserId { get; set; }
    public UserModel? User { get; set; }

    public RsvpStatus Status { get; set; } = RsvpStatus.Registered;
    public DateTime RsvpDate { get; set; } = DateTime.UtcNow;
}