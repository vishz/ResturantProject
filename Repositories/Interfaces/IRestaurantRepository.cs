using RebornResturantApp.Models;

namespace RebornResturantApp.Repositories.Interfaces
{
  public interface IRestaurantRepository : IRepository<Restaurant>
  {
    Task<Restaurant?> GetByUsernameAndPassword(string username, string password);
    Task<Restaurant?> GetRestaurantByIdWithItemsAsync(int restaurantId);
  }

}
