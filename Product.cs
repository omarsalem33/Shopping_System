using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ReduceStock(int quantity)
        {
            if (quantity <= Stock )
                Stock -= quantity;
            else
                Console.WriteLine("Insufficient stock");
            
        }

        public void IncreasStock(int quantity)
        {
             Stock += quantity;
        }


        public override string ToString()
        {
            return $"{Id}. {Name} - ${Price} (Stock: {Stock})";
        }
    }

} 