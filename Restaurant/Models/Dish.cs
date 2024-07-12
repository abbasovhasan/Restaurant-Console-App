using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; }
    public Dish(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public static List<Dish> FinishedByCategory(List<Dish> dishes, Category category)
    {
        List<Dish> baseDishes = dishes.Where(d => d.Category.Id == category.Id).ToList();
        return baseDishes;
    }
}

public static class DishExtension
{
    public static decimal Sum(this List<Dish> dishes)
    {
        decimal totatlPrice = dishes.Sum(d => d.Price);

        return totatlPrice;
    }
}
