﻿using Microsoft.EntityFrameworkCore;
using Stock.Shared.Models;
namespace Stock.Server.Data;

public class StockDbContext : DbContext
{
   public DbSet<Company> Companies { get; set; }
   public DbSet<PriceData> PriceData { get; set; }
   public DbSet<User> Users { get; set; }
   public DbSet<PriceCollection> PriceCollections { get; set; }
   
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=true;");
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Company>().HasKey(c => c.Symbol);
      modelBuilder.Entity<User>().Property(u=>u.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<PriceData>().Property(p => p.Id).ValueGeneratedOnAdd();
   }
}