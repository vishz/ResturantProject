using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RebornResturantApp.Dtos.Authentication;
using RebornResturantApp.Services.Interfaces;

namespace RebornResturantApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AuthenticationController : ControllerBase
  {
    private readonly IRestaurantAuthenticationService _restaurantAuthenticationService;

    public AuthenticationController(IRestaurantAuthenticationService restaurantAuthenticationService)
    {
      _restaurantAuthenticationService = restaurantAuthenticationService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthenticationRequestDto loginDto)
    {
      var result = await _restaurantAuthenticationService.Authenticate(loginDto);

      if (result == null)
        return Unauthorized(new { message = "Invalid username or password" });

      return Ok(result);
    }
  }
}

