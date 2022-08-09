using BlazorApp_CRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_CRUD.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("userdetails");
                entity.Property(e => e.Userid).HasColumnName("Userid");
                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
