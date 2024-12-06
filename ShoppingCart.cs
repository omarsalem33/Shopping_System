using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{
    public class ShoppingCart
    {
        private List<CartItem> Items { get; set; } = new List<CartItem>();
        
        public void AddItem(Product product , int quantity)
        {
            var existItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existItem == null)
                Items.Add(new CartItem (product,quantity));
            else
            {
                existItem.Quantity += quantity;
                product.ReduceStock(quantity);
            }
        }

        public void RemoveItem(Product product) 
        {
            var existItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if(existItem != null) 
            {
                product.IncreasStock(existItem.Quantity);
                Items.Remove(existItem);
            }
            else
                Console.WriteLine("Invaild Product");
        }


        public void View()
        {
            if (Items.Count == 0)
                Console.WriteLine("Cart is empty");

            else
            {
                foreach (var item in Items)
                {
                    Console.WriteLine(item.Product.Name);
                }
                Console.WriteLine($"Total Price: ${Items.Sum(item => item.GetTotalPrice())}");
            }
        }

      

        public void Clear()
        {
            foreach(var item in Items)  
                item.Product.IncreasStock(item.Quantity);

            Items.Clear();
        }


    }
}
