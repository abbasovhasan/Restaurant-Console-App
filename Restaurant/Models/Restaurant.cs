using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dish> Menu { get; set; }
        public List<Order> Orders { get; set; }

        public Restaurant(string name, string address)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name property geçerli olmalıdır.");
            }

            Name = name;
            Address = address;
            Menu = new List<Dish>();
            Orders = new List<Order>();
        }

        public void AddDishToMenu(Dish dish)
        {
            Menu.Add(dish);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public Order? GetOrderId(List<Order> orders, int id)
        {
            return Orders.SingleOrDefault(o => o.OrderId == id);
        }

        public void PlaceOrder(int orderId, List<Dish> dishes)
        {
            var order = new Order(orderId);
            order.Dishes.AddRange(dishes);
            AddOrder(order);
        }
    }
}
