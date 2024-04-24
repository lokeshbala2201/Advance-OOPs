using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class used for create object of Travel Details<see cref="TravelDetails"/>
    /// </summary>
    public class TravelDetails
    {
        //field
        //static
        private static int s_traveID=2000;

        //properties
        public string TravelID { get; }//readonly property
        public string CardNummber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public int TravelCost { get; set; }

        //Constructor
        /// <summary>
        /// This Constructor initialize the TravelDetails class
        /// </summary>
        /// <param name="cardID"></param>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="date"></param>
        /// <param name="cost"></param>
        public TravelDetails(string cardID,string fromLocation,string toLocation,DateTime date,int cost)
        {
            s_traveID++;
            TravelID="TID"+s_traveID;
            CardNummber=cardID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=cost;

        
        }
        public TravelDetails(string[] travel)
        {
            s_traveID=int.Parse(travel[0].Remove(0,3));
            TravelID=travel[0];
            CardNummber=travel[1];
            FromLocation=travel[2];
            ToLocation=travel[3];
            Date=DateTime.ParseExact(travel[4],"dd/MM/yyyy hh:mm:ss tt",null);
            TravelCost=int.Parse(travel[5]);

        }

    }
}