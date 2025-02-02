using RebornResturantApp.Dtos.Authentication;
using RebornResturantApp.Models;

namespace RebornResturantApp.Services.Interfaces
{
  public interface IRestaurantAuthenticationService
  {
    Task<AuthenticationResponseDto?> Authenticate(AuthenticationRequestDto authenticationRequest);
  }
}
