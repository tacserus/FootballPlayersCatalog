using FootballPlayersCatalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballPlayersCatalog;

public class CatalogDbContext : DbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

    public virtual DbSet<FootballPlayer?> Players { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FootballPlayer>(entity =>
        {
            entity.ToTable("footballplayer");

            entity.HasKey(e =>
                e.PlayerId).HasName("footballplayer_pkey");

            entity.Property(e => e.PlayerId)
                .HasColumnName("id");
            
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("name");

            entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("surname");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasColumnName("gender");

            entity.Property(e => e.BirthDate)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("birthDate");

            entity.Property(e => e.TeemName)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("teemName");

            entity.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("country");
        });
    }
}