namespace DataAccess.Entities;

public class UserEntity : Entity
{
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}