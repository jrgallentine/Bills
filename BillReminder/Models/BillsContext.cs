using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BillReminder.Models
{
    public partial class BillsContext : DbContext
    {
        public BillsContext()
        {
        }

        public BillsContext(DbContextOptions<BillsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database= Bills;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(144);

                entity.Property(e => e.Due).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Url)
                    .HasMaxLength(144)
                    .HasColumnName("URL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
