using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    internal class Item
    {
        private static int counter = 0;
        private double price;
        private int id;

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
            }
            else
            {
                throw new Exception("Price cannot be negative.");
            }
        }


        public int GetID()
        {
            return id;
        }

        public Item(double price)
        {
            this.price = price;
            id = counter++;
        }

        public Item() : this(0) { }
    }

}
