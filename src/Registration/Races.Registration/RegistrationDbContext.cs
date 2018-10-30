using Microsoft.EntityFrameworkCore;
using Races.Registrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Races.Registrations
{
    public partial class RegistrationDbContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }

        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName)
                    .IsRequired();
                entity.Property(e => e.LastName)
                    .IsRequired();
            });
        }
    }
}
