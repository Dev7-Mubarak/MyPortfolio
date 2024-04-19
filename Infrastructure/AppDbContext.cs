using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options )
            : base(options)
        {
            
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Owner>()
                .Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<PortfolioItem>()
                .Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>()
                .HasData(
                    new Owner() { 
                        Id = Guid.NewGuid(),
                        Avator = "avator.jpg",
                        FullName = "Mubarak Bamazahem",
                        Profil = "Microsoft MVP / .NeT Develepor"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
