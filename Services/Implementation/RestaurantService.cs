using RebornResturantApp.Dtos.Restaurant;
using RebornResturantApp.Repositories.Interfaces;
using RebornResturantApp.Services.Interfaces;

namespace RebornResturantApp.Services.Implementation
{
  public class RestaurantService : IRestaurantService
  {
    private readonly IRestaurantRepository _restaurantRepository;

    public RestaurantService(IRestaurantRepository restaurantRepository)
    {
      _restaurantRepository = restaurantRepository;
    }

    public async Task<RestaurantItemListDto> GetItemsByRestaurantIdAsync(int restaurantId)
    {
      var restaurant = await _restaurantRepository.GetRestaurantByIdWithItemsAsync(restaurantId);

      if (restaurant == null)
        throw new Exception("restaurant not found");

      var restaurantDto = new RestaurantItemListDto
      {
        Id = restaurant.Id,
        Name = restaurant.Name,
        Address = restaurant.Address,
        ContactNumber = restaurant.ContactNumber,
        Items = restaurant.Items.Select(item => new ItemListDto
        {
          Id = item.Id,
          Name = item.Name,
          Description = item.Description,
          Price = item.Price,
          ItemPicture = item.ItemPicture?.Picture ?? string.Empty,
          Status = item.Status,
          SubCategoryId = item.SubCategoryId,
          SubCategoryName = item.SubCategory.Name,
          CategoryId = item.SubCategory.CategoryId,
          CategoryName = item.SubCategory.Category.Name
        }).ToList()
      };

      return restaurantDto;
    }
  }
}

