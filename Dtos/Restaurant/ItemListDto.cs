namespace RebornResturantApp.Dtos.Restaurant
{
  public class ItemListDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
    public string ItemPicture { get; set; }
    public int SubCategoryId { get; set; }
    public string SubCategoryName { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

  }
}
