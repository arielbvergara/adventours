using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess;

public class AdventourContext : DbContext
{
    public AdventourContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<PermissionEntity> Permissions => Set<PermissionEntity>();

    public DbSet<RoleEntity> Roles => Set<RoleEntity>();

    public DbSet<TourEntity> Tours => Set<TourEntity>();

    public DbSet<UserEntity> Users => Set<UserEntity>();

    public DbSet<UserTours> UserTours => Set<UserTours>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .HasMany(e => e.Roles)
            .WithMany(e => e.Users)
            .UsingEntity("UserRoles");

        modelBuilder.Entity<RoleEntity>()
            .HasMany(e => e.Permissions)
            .WithMany(e => e.Roles)
            .UsingEntity("RolePermissions");
    }
}