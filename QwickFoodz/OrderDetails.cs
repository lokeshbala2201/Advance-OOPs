using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    //creating enum for food status
    public enum OrderStatus{Default,Initiated, Ordered, Cancelled}
    public class OrderDetails
    {
        //private //static
        private static int s_orderID=3000;

        //properties
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfOrder { get; set; }
        public OrderStatus OrderStatus { get; set; }

        //constructor
        public OrderDetails(string customerID,int totalPrice,DateTime dateOfOrder,OrderStatus status)
        {
            //auto incrementation
            s_orderID++;
            OrderID="OID"+s_orderID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfOrder=dateOfOrder;
            OrderStatus=status;
        }

    }
}