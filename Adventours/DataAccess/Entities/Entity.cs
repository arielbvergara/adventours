namespace DataAccess.Entities;

public abstract class Entity : EntityBase
{
    public DateTime? LastUpdatedUtc { get; set; }

    public DateTime DateCreated { get; set; }
}
