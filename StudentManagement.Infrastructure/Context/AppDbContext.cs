using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentManagement.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.FirstName).IsRequired();
                entity.Property(s => s.LastName).IsRequired();
                entity.Property(s => s.Average).IsRequired();
                entity.Property(s => s.Field).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
