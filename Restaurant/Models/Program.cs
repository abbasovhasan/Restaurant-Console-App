using System;
using System.Collections.Generic;
using RestaurantApp.Models;

public class Program
{
    public static void Main()
    {
        // Create categories
        var mainCourseCategory = new Category(1, "Main Course");
        var dessertCategory = new Category(2, "Dessert");

        // Create dishes
        var pizza = new Dish(1, "Pizza", 12.50m);
        pizza.Category = mainCourseCategory;
        var pasta = new Dish(2, "Pasta", 10.00m);
        pasta.Category = mainCourseCategory;
        var iceCream = new Dish(3, "Ice Cream", 5.00m);
        iceCream.Category = dessertCategory;

        // Create restaurant
        var restaurant = new Restaurant("Lezzet Durağı", "123 Sokak, İstanbul");

        // Add dish to menu
        restaurant.AddDishToMenu(pizza);
        restaurant.AddDishToMenu(pasta);
        restaurant.AddDishToMenu(iceCream);

        // Create orders
        var order1 = new Order(1);
        order1.Dishes.Add(pizza);
        order1.Dishes.Add(iceCream);

        var order2 = new Order(2);
        order2.Dishes.Add(pasta);

        // Add orders to restaurant
        restaurant.AddOrder(order1);
        restaurant.AddOrder(order2);

        //  Find order by order id
        var retrievedOrder = restaurant.GetOrderId(restaurant.Orders, 1);

        // Print order details
        if (retrievedOrder != null)
        {
            Console.WriteLine($"Order Id: {retrievedOrder.OrderId}, Total Amount: {retrievedOrder.TotalAmount}");
            Console.WriteLine("Ordered Dishes:");
            foreach (var dish in retrievedOrder.Dishes)
            {
                Console.WriteLine($"- {dish.Name}");
            }
        }
        else
        {
            Console.WriteLine("Order not found.");
        }

        // Calculate and print the total price of all dishes in the menu
        decimal totalMenuPrice = restaurant.Menu.Sum();
        Console.WriteLine($"Total Price of All Dishes in Menu: {totalMenuPrice}");
    }
}
