using Microsoft.EntityFrameworkCore;
using ResortManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagement.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Villa> Villas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ////base.OnModelCreating(modelBuilder);
        ////modelBuilder.Entity<Villa>().ToTable("Villas");
        ////modelBuilder.Entity<Villa>().HasKey(v => v.Id);
        ////modelBuilder.Entity<Villa>().Property(v => v.Name).IsRequired().HasMaxLength(100);
        ////modelBuilder.Entity<Villa>().Property(v => v.Description).HasMaxLength(500);
        ////modelBuilder.Entity<Villa>().Property(v => v.Price).IsRequired();
        ////modelBuilder.Entity<Villa>().Property(v => v.Sqft).IsRequired();
        ////modelBuilder.Entity<Villa>().Property(v => v.Occupancy).IsRequired();
        ////modelBuilder.Entity<Villa>().Property(v => v.ImageUrl).HasMaxLength(200);
        ////modelBuilder.Entity<Villa>().Property(v => v.VillaNumber).IsRequired();
        ///

        modelBuilder.Entity<Villa>().HasData(new Villa
        {
            Id = 1,
            Name = "Royal Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 200,
            Sqft = 550,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        },
        new Villa
        {
            Id = 2,
            Name = "Premium Pool Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 300,
            Sqft = 600,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        },
        new Villa
        {
            Id = 3,
            Name = "Luxury Pool Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 400,
            Sqft = 700,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        },
        new Villa
        {
            Id = 4,
            Name = "Medium Pool Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 500,
            Sqft = 800,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        },
        new Villa
        {
            Id = 5,
            Name = "South face Pool Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 600,
            Sqft = 900,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        },
        new Villa
        {
            Id = 6,
            Name = "Simantw Villa",
            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 700,
            Sqft = 1000,
            CreatedDate = new DateTime(2025, 04, 21),
            UpdatedDate = new DateTime(2025, 04, 21)
        });
    }

}

