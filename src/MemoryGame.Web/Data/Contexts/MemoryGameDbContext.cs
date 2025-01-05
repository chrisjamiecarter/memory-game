using MemoryGame.Web.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Data.Contexts;

/// <summary>
/// The Entity Framework database context for the application.
/// Configures the entity model and provides access to the database tables.
/// </summary>
/// <param name="options">
/// The <see cref="DbContextOptions{MemoryGameDbContext}"/> used to configure the database context.
/// </param>
public class MemoryGameDbContext(DbContextOptions<MemoryGameDbContext> options) : DbContext(options)
{
    public DbSet<Score> Scores { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Score>().ToTable(nameof(Score));

        modelBuilder.Entity<Score>().HasKey(pk => pk.Id);

        modelBuilder.Entity<Score>().Property(pk => pk.Username).IsRequired();
        modelBuilder.Entity<Score>().Property(pk => pk.Difficulty).IsRequired();
        modelBuilder.Entity<Score>().Property(pk => pk.Moves).IsRequired();
        modelBuilder.Entity<Score>().Property(pk => pk.TimeTakenInSeconds).IsRequired();
        modelBuilder.Entity<Score>().Property(pk => pk.TotalScore).IsRequired();
        modelBuilder.Entity<Score>().Property(pk => pk.DatePlayed).IsRequired();

        modelBuilder.Entity<Score>().Property(pk => pk.DatePlayed).HasColumnType("date");

        base.OnModelCreating(modelBuilder);
    }
}
