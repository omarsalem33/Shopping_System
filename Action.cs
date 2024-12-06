using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{
    public enum ActionType
    {
        Add,
        Remove
    }
    public class Action
    {
        public ActionType Type { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public Action(ActionType type, Product product, int quantity)
        {
            Type = type;
            Product = product;
            Quantity = quantity;
        }

        public void Undo(ShoppingCart cart)
        {
            if (Type == ActionType.Remove)
            {
                cart.AddItem(Product, Quantity);
            }
            else if (Type == ActionType.Add) 
            {
                cart.RemoveItem(Product);
            }
        }
    }
}
