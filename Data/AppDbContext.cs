using Microsoft.EntityFrameworkCore;
using RebornResturantApp.Models;

namespace RebornResturantApp.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemPicture> ItemPictures { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Item>()
          .HasOne(i => i.ItemPicture)
          .WithOne(ip => ip.Item)
          .HasForeignKey<ItemPicture>(ip => ip.ItemId); 
    }
  }
}
