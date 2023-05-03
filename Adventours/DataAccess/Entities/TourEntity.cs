namespace DataAccess.Entities;

public class TourEntity : Entity
{
    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Language { get; set; } = null!;

    public UserEntity TourLeader { get; set; } = null!;

    public IList<UserTours>? Travelers { get; set; }

    public TourState State { get; private set; } = TourState.ComingSoon;

    public void CancelTour()
    {
        State = TourState.Cancelled;
        LastUpdatedUtc = DateTime.UtcNow;
    }

    public void CompleteTour()
    {
        State = TourState.Completed;
        LastUpdatedUtc = DateTime.UtcNow;
    }
}

public enum TourState
{
    ComingSoon,
    Cancelled,
    Completed
}