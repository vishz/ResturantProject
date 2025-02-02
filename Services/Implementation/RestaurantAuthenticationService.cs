using RebornResturantApp.Dtos.Authentication;
using RebornResturantApp.Repositories.Interfaces;
using RebornResturantApp.Services.Interfaces;

namespace RebornResturantApp.Services.Implementation
{
  public class RestaurantAuthenticationService : IRestaurantAuthenticationService
  {
    private readonly IRestaurantRepository _restaurantRepository;

    public RestaurantAuthenticationService(IRestaurantRepository restaurantRepository)
    {
      _restaurantRepository = restaurantRepository;
    }


    public async Task<AuthenticationResponseDto?> Authenticate(AuthenticationRequestDto authenticationRequest)
    {
      var restaurant = await _restaurantRepository.GetByUsernameAndPassword(authenticationRequest.Username, authenticationRequest.Password);
      if (restaurant == null) return null;

      return new AuthenticationResponseDto
      {
        Id = restaurant.Id,
        Name = restaurant.Name,
        Address = restaurant.Address,
        ContactNumber = restaurant.ContactNumber,
      };
    }
  }
}
