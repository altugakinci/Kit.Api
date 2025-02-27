using Domain.Entities;
using Domain.Entities.RelationEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<UserForgotPassword> UsersForgotPassword { get; set; }
    public DbSet<UserMailConfirmation> UsersMailConfirmation { get; set; }
}
