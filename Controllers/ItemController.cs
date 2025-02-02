using Microsoft.AspNetCore.Mvc;
using RebornResturantApp.Dtos.Item;
using RebornResturantApp.Services.Interfaces;

namespace RebornResturantApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ItemController : Controller
  {
    private readonly IItemService _itemService;

    public ItemController(IItemService itemService)
    {
      _itemService = itemService;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateItem(int id, [FromBody] UpdateItemDto updateItemDto)
    {
      if (id != updateItemDto.Id)
        return BadRequest("Item ID mismatch");

      await _itemService.UpdateItemAsync(updateItemDto);
      return Ok(new { message = "Item updated successfully" });
    }
  }
}
