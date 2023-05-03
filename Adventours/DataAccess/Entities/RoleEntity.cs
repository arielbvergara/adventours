namespace DataAccess.Entities;

public class RoleEntity : Entity
{
    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public ICollection<PermissionEntity>? Permissions { get; set; }

    public ICollection<UserEntity>? Users { get; set; }
}