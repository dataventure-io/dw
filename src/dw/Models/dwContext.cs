using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dw.Models
{
    public partial class dwContext : DbContext
    {
        public dwContext()
        {
        }

        public dwContext(DbContextOptions<dwContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=dw;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingEmployee(modelBuilder);
            OnModelCreatingConfig(modelBuilder);
        }

        //partial void OnModelCreatingEmployee(ModelBuilder modelBuilder);
        // partial void OnModelCreatingConfig(ModelBuilder modelBuilder);
    }
}