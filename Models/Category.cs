namespace RebornResturantApp.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public ICollection<SubCategory> SubCategories { get; set; }
  }
}
