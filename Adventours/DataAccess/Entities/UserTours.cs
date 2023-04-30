namespace DataAccess.Entities;

public class UserTours : EntityBase
{
    public int UserId { get; set; }

    public UserEntity? User { get; set; }

    public int TourId { get; set; }

    public TourEntity? Tour { get; set; }
}
