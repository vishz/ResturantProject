namespace RebornResturantApp.Models
{
  public class Restaurant
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Status { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public virtual ICollection<Item> Items { get; set; }
  }
}
