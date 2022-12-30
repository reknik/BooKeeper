using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BooKeeper.Models;
using System.Configuration;

#nullable disable

namespace BooKeeper.Data
{
    public partial class BookDbContext : DbContext
    {
        public BookDbContext()
        {
        }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["BookDatabase"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("category");

                entity.HasOne(d => d.LoanerNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Loaner)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("loaner");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
