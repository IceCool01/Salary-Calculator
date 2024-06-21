using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Calculator.DataBase
{
    public partial class WorkersContext : DbContext
    {
        public WorkersContext()
        {
        }

        public WorkersContext(DbContextOptions<WorkersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=workers;Username=postgres;Password=2323");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.WorkersId).HasName("workers_pkey");

                entity.ToTable("workers");

                entity.Property(e => e.WorkersId).HasColumnName("workers_id");
                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .HasColumnName("last_name");
                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("middle_name");
                entity.Property(e => e.Post)
                    .HasMaxLength(150)
                    .HasColumnName("post");
                entity.Property(e => e.Salary)
                    .HasPrecision(8, 2)
                    .HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}



