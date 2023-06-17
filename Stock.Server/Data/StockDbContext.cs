using Microsoft.EntityFrameworkCore;
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
      optionsBuilder.UseSqlServer("jdbc:jtds:sqlserver://DB-MSSQL16/2019SBD/s24328");
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Company>().HasNoKey();
      modelBuilder.Entity<User>().Property(u=>u.Id).ValueGeneratedOnAdd();
   }
}