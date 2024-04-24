using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    public class ItemDetails
    {
        //private //ststic
        private static int s_itemID=4000;
        public string ItemID { get; set; }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        //constructor
        public ItemDetails(string orderID,string foodId,int purchaseCount,int priceOfOrder)
        {
            //auto incrementation
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
    }
}