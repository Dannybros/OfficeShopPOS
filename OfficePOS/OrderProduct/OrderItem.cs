using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePOS
{
    public class OrderItem
    {
        private string proID;
        private double price;
        private int amount;
        private double total;
        private string name;

        public OrderItem(string proID, string name, double price, int amount)
        {
            this.proID = proID;
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.total = price*amount;
        }

        public string ProID 
        {
            get { return proID; }
            set { proID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
