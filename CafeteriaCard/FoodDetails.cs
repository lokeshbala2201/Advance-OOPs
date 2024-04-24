using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    /// <summary>
    /// This class contain details of food <see cref="FoodDetails"/> 
    /// </summary>
    public class FoodDetails
    {
        //fields
        //static
        private static int s_foodID=100;
        //properties
        public string FoodID { get;  }//Readonly property
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }

         //constructor
         /// <summary>
         /// THis constructor used for initialize a object for food 
         /// </summary>
         /// <param name="foodName"></param>
         /// <param name="foodPrice"></param>
         /// <param name="available"></param> <summary>
    
        public FoodDetails(string foodName,int foodPrice,int available)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=available;
        }
    }
}