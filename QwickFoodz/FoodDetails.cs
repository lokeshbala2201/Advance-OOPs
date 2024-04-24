using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    public class FoodDetails
    {
        //field 
        //static
        private static int s_foodId=2000;

        //properties
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public int PriceQuantity { get; set; }
        public int QuantityAvailable { get; set; }

        //constructor
        public FoodDetails(string foodName,int price,int quantityAvailable)
        {
            //auto incrementation
            s_foodId++;
            FoodID="FID"+s_foodId;
            FoodName=foodName;
            PriceQuantity=price;
            QuantityAvailable=quantityAvailable;
        }

    }
}