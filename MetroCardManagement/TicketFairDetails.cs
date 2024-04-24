using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class used for create object of TicketFairDetails<see cref="TicketFairDetails"/> 
    /// </summary> 
    public class TicketFairDetails
    {
        //field 
        //static
        private static int s_ticketID=3000;
        //properties
        public string TicketID { get; }//readonly properties
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int TicketPrice { get; set; }

        //Constructor
        /// <summary>
        /// This Constructor initialize the TicketFairDetails class
        /// </summary>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="price"></param>
        public TicketFairDetails(string fromLocation,string toLocation,int price)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=price;
        }
        public TicketFairDetails(string[] ticket )
        {
            s_ticketID=int.Parse(ticket[0].Remove(0,3));
            TicketID=ticket[0];
            FromLocation=ticket[1];
            ToLocation=ticket[2];
            TicketPrice=int.Parse(ticket[3]);
        }
    }
}