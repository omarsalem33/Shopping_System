using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{
    public class Shop
    {
        private List<Product> Products { get; set; } = new List<Product>();
        private ShoppingCart Cart { get; set; } = new ShoppingCart();
        private ActionHistory History { get; set; } = new ActionHistory();

        public Shop()
        {
            SeedProducts();
        }

       

        private void SeedProducts()
        {
            Products.Add(new Product(1, "Laptop", 1000, 5));
            Products.Add(new Product(2, "Phone", 700, 10));
            Products.Add(new Product(3, "Headphones", 100, 20));
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Display Available Products");
                Console.WriteLine("2. Add Product to Cart");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Remove Product from Cart");
                Console.WriteLine("5. Place an Order");
                Console.WriteLine("6. Undo Last Action");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayProducts();
                        break;
                    case "2":
                        AddToCart();
                        break;
                    case "3":
                        Cart.View();
                        break;
                    case "4":
                        RemoveFromCart();
                        break;
                    case "5":
                        PlaceOrder();
                        break;
                    case "6":
                        UndoLastAction();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void DisplayProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }

        private void AddToCart()
        {
            Console.Write("Enter Product ID: ");
            var productId = int.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            var quantity = int.Parse(Console.ReadLine());

            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                Console.WriteLine("Invalid product ID.");
                return;
            }

            try
            {
                if (quantity > product.Stock)
                    Console.WriteLine("Quantity is not available");
                else
                {
                    Cart.AddItem(product, quantity);
                    History.PushAction(new Action(ActionType.Add, product, quantity));
                    product.Stock -= quantity;
                    Console.WriteLine($"{product.Name} added to cart.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RemoveFromCart()
        {
            Console.Write("Enter Product ID: ");
            var productId = int.Parse(Console.ReadLine());

            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                Console.WriteLine("Invalid product ID.");
                return;
            }

            Cart.RemoveItem(product);
            History.PushAction(new Action(ActionType.Remove, product, 0));
            Console.WriteLine($"{product.Name} removed from cart.");
        }

        private void PlaceOrder()
        {
            Console.WriteLine("Order placed successfully!");
            Cart.Clear();
        }

        private void UndoLastAction()
        {
            History.UndolastAction(Cart);
        }
    }
}
