using JWTAuthApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthApi.Data;

public class AuthDbContext : IdentityDbContext<User>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>(entity =>
        {
            entity.Property(u => u.FirstName).HasMaxLength(100);
            entity.Property(u => u.LastName).HasMaxLength(100);
        });

        var adminRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        var userRoleId = "2301D884-221A-4E7D-B509-0113DCC043E2";
        var managerRoleId = "2301D884-221A-4E7D-B509-0113DCC043E3";

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = adminRoleId
            },
            new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = userRoleId
            },
            new IdentityRole
            {
                Id = managerRoleId,
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = managerRoleId
            }
        );

        var adminUserId = "2301D884-221A-4E7D-B509-0113DCC043A1";
        var hasher = new PasswordHasher<User>();

        var adminUser = new User
        {
            Id = adminUserId,
            UserName = "admin@jwtauth.com",
            NormalizedEmail = "ADMIN@JWTAUTH.COM",
            Email = "admin@jwtauth.com",
            NormalizedUserName = "ADMIN@JWTAUTH.COM",
            EmailConfirmed = true,
            FirstName = "System",
            LastName = "Administrator",
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = adminUserId
        };

        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123!");

        builder.Entity<User>().HasData(adminUser);

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            }
        );
    }
}