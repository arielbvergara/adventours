using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories;

public class AdventourContext : DbContext
{
    public AdventourContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<PermissionEntity> Permissions => Set<PermissionEntity>();

    public DbSet<RoleEntity> Roles => Set<RoleEntity>();

    public DbSet<RolePermissions> RolePermissions => Set<RolePermissions>();

    public DbSet<TourEntity> Tours => Set<TourEntity>();

    public DbSet<UserEntity> Users => Set<UserEntity>();

    public DbSet<UserTours> UserTours => Set<UserTours>();

    public DbSet<UserRoles> UserRoles => Set<UserRoles>();
}