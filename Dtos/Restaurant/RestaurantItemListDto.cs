namespace RebornResturantApp.Dtos.Restaurant
{
  public class RestaurantItemListDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public List<ItemListDto> Items { get; set; } 
  }
}
