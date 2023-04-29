namespace DataAccess.Entities;

public class PermissionEntity : Entity
{
    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public ICollection<RolePermissions>? RolePermissions { get; set; }
}