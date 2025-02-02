namespace RebornResturantApp.Models
{
  public class Item
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
    public int? ItemPictureId { get; set; }
    public int RestaurantId { get; set; }
    public int SubCategoryId { get; set; }
    public virtual ItemPicture ItemPicture { get; set; }
    public virtual Restaurant Restaurant { get; set; }
    public virtual SubCategory SubCategory { get; set; }

  }
}
