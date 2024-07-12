namespace RestaurantApp.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish> Dishes { get; set; }
    public Category(int id, string name)
    {
        Id = id;
        Name = name;
        Dishes = new List<Dish>();
    }
}



