using Microsoft.EntityFrameworkCore;
using RebornResturantApp.Data;
using RebornResturantApp.Models;
using RebornResturantApp.Repositories.Interfaces;

namespace RebornResturantApp.Repositories.Implementations
{
  public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
  {
    private readonly AppDbContext _context;

    public RestaurantRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task<Restaurant?> GetByUsernameAndPassword(string username, string password)
    {
      var restaurant = await _context.Restaurants
          .FirstOrDefaultAsync(r => r.Username == username && r.Password == password);
      return restaurant;
    }

    //Status 1 = Active
    public async Task<Restaurant?> GetRestaurantByIdWithItemsAsync(int restaurantId)
    {
      var restaurant = await _context.Restaurants
          .Include(r => r.Items.Where(i => i.Status == "1"))
              .ThenInclude(i => i.ItemPicture)  
          .Include(r => r.Items)
              .ThenInclude(i => i.SubCategory) 
                  .ThenInclude(sc => sc.Category) 
          .Where(r => r.Id == restaurantId && r.Status == "1")
          .FirstOrDefaultAsync();

      return restaurant;
    }
  }

}
