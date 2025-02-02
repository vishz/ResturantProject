using Microsoft.AspNetCore.Mvc;
using RebornResturantApp.Services.Interfaces;

namespace RebornResturantApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantController : ControllerBase
  {
    private IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
      _restaurantService = restaurantService;
    }

    [HttpGet("{id}/items")]
    public async Task<IActionResult> GetItemsByRestaurantId(int id)
    {
      var items = await _restaurantService.GetItemsByRestaurantIdAsync(id);

      if (items == null)
        return NotFound(new { message = "No items found for this restaurant" });

      return Ok(items);
    }
  }

}


