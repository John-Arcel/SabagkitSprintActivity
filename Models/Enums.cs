namespace SabagkitSprintActivity.Models;

public enum RsvpStatus
{
    Registered,
    Waitlisted,
    Cancelled
}

public enum MeetupStatus
{
    Scheduled,
    InProgress,
    Completed,
    Cancelled
}

public enum VoteDirection
{
    Downvote = -1,
    None = 0,
    Upvote = 1
}