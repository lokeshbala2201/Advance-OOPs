using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    /// <summary>
    /// This class is used for create instance of CartItem <see cref="CartItem"/>
    /// </summary>
    public class CartItem
    {
        
        //field
        private static int s_itemID=100;
        //properties
        
        public string ItemID { get;  } //Readonly properties
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        //Constructor
        /// <summary>
        /// This constror create object for cart item
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="orderPrice"></param>
        /// <param name="orderQuantity"></param>
        public CartItem(string orderID,string foodID,int orderPrice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
    }
}