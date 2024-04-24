using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    /// <summary>
    /// This is enum creation for Order Status
    /// </summary>
    public enum Status{Default,Initiated,Ordered,Cancelled}

    /// <summary>
    ///This class used for make instance for Order Details<see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDatails
    {
        //field
        //static
        private static int s_orderId=1000;
        //properties
        public string OrderID { get;  }//read only
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrcie { get; set; }
        public Status Status { get; set; }

        /// <summary>
        /// This constractor used for create object of Order Details
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="orderDate"></param>
        /// <param name="totalprice"></param>
        /// <param name="status"></param>
        //Constructor
        public OrderDatails(string userID,DateTime orderDate,int totalprice,Status status)
        {
            //auto increment
            s_orderId++;
            OrderID="OID"+s_orderId;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrcie=totalprice;
            Status=status;

        }

    }
}