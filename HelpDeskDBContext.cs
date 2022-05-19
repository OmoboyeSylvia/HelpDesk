using System;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HelpDesk
{
    public class HelpDeskDBContext : DbContext
    {
        public HelpDeskDBContext()
        {

        }

        public HelpDeskDBContext(DbContextOptions<HelpDeskDBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\;Database=DESKTOP-VGB2UAT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
 
                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

            });

      
        }

    }
}
