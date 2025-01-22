using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class FoodItem
    {
        public string Name = "";
        public string Category = "";
        public int Quantity = 0;
        public string ExpireDate = "";

        //Constructor to create FoodItem objects
        public FoodItem(string name, string category, int quantity, string expireDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpireDate = expireDate;
        }
    }
}

