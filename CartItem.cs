using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity {  get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name} - Quantity {Quantity} Totle Price: ${GetTotalPrice}";
        }
    }
}
