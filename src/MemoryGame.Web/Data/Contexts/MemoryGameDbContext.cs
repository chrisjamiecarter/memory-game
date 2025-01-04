using MemoryGame.Web.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryGame.Web.Data.Contexts;

public class MemoryGameDbContext(DbContextOptions<MemoryGameDbContext> options) : DbContext(options)
{
    public DbSet<Score> Scores { get; set; }

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
