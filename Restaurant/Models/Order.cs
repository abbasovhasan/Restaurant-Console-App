namespace RestaurantApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public List<Dish> Dishes { get; set; }
    public decimal TotalAmount => Dishes.Sum();

    public Order(int id)
    {
        OrderId = id;
        Dishes = new List<Dish>();
    }
}
