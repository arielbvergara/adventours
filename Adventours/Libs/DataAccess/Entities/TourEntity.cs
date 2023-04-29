namespace DataAccess.Entities;

public class TourEntity : Entity
{
    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Language { get; set; } = null!;

    public UserEntity TourLeader { get; set; } = null!;

    public List<UserTours>? Travelers { get; set; }
}