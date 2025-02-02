namespace RebornResturantApp.Models
{
  public class SubCategory
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int CategoryId { get; set; }
    public virtual ICollection<Item> Items { get; set; }
    public virtual Category Category { get; set; }
  }
}
