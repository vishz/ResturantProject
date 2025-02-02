namespace RebornResturantApp.Models
{
  public class ItemPicture
  {
    public int Id { get; set; }
    public string Picture { get; set; }
    public string Status { get; set; }
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }
  }
}
