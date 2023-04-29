namespace DataAccess.Entities;

public class UserRoles : EntityBase
{
    public int UserId { get; set; }

    public UserEntity? User { get; set; }

    public int RoleId { get; set; }

    public RoleEntity? Role { get; set; }
}
