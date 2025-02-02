using RebornResturantApp.Dtos.Restaurant;
using RebornResturantApp.Models;

namespace RebornResturantApp.Services.Interfaces
{
  public interface IRestaurantService
  {
    Task<RestaurantItemListDto> GetItemsByRestaurantIdAsync(int restaurantId);
  }
}


