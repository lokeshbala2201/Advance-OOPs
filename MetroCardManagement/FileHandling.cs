using System;
using System.IO;

namespace MetroCardManagement
{
    /// <summary>
    /// THis class used for File manipulation < see cref="FileHandling">
    /// </summary>
    public static class FileHandling
    {
        //file and directory creation
        public static void Create()
        {
            //directory creation
            if(!Directory.Exists("MetroCardFiles"))
            {
                //create a direcotory
                Console.WriteLine("Directory Created");
                Directory.CreateDirectory("MetroCardFiles");
            }else{
                Console.WriteLine("Already exixts");
            }
            //userDetails file
            if(!File.Exists("MetroCardFiles\\UserDetails.csv"))
            {
                //create user csv file
                Console.WriteLine("File Created");
                File.Create("MetroCardFiles\\UserDetails.csv").Close();
            }else{
                Console.WriteLine("Already exixts");
            }
            //Travel Details
            if(!File.Exists("MetroCardFiles\\TravelDetails.csv"))
            {
                //create travel file
                Console.WriteLine("File Created");
                File.Create("MetroCardFiles\\TravelDetails.csv").Close();
            }else{
                Console.WriteLine("Already exixts");
            }
            //TicketFairDetails
            if(!File.Exists("MetroCardFiles\\TicketFairDetails.csv"))
            {
                Console.WriteLine("File Created");
                File.Create("MetroCardFiles\\TicketFairDetails.csv").Close();
            }else{
                Console.WriteLine("Already exixts");
            }
        }//file and directory creation end

        //WriteToCsv
        public static void WriteToCsv()
        {
            //userdetails
            string[] users=new string [Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                //conver the data into string
                users[i]=Operations.userList[i].CardNumber+","+Operations.userList[i].UserName+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;

            }
            File.WriteAllLines("MetroCardFiles\\UserDetails.csv",users);

            //Travel Details
            string[] travels=new string [Operations.travelList.Count];
            for(int i=0;i<Operations.travelList.Count;i++)
            {
                //convert into single Line
                travels[i]=Operations.travelList[i].TravelID+","+Operations.travelList[i].CardNummber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date.ToString("dd/MM/yyyy hh:ss:mm tt")+","+Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardFiles\\TravelDetails.csv",travels);

            //TicketFai details
            string[] tickets=new string [Operations.ticketList.Count];
            for(int i=0;i<Operations.ticketList.Count;i++)
            {
                //convert the data into single string
                tickets[i]=Operations.ticketList[i].TicketID+","+Operations.ticketList[i].FromLocation+","+Operations.ticketList[i].ToLocation+","+Operations.ticketList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardFiles\\TicketFairDetails.csv",tickets);

        }
    
        //readFromcsv
        public static void ReadFromCSV()
        {
            //userdetails
            string[] users=File.ReadAllLines("MetroCardFiles\\UserDetails.csv");
            foreach(string user in users)
            {
                 //split the string 
                string[] split=user.Split(",");
                UserDetails user1 = new UserDetails(split);
                Operations.userList.Add(user1);
                
            }
            //travel details
            string[] travels=File.ReadAllLines("MetroCardFiles\\TravelDetails.csv");
            foreach(string travel in travels)
            {
                 //split the string 
                string[] split=travel.Split(",");
                TravelDetails travel1 = new TravelDetails(split);
                Operations.travelList.Add(travel1);
                
            }
            //ticket details
            string[] tickets=File.ReadAllLines("MetroCardFiles\\TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                //split the string 
                string[] split=ticket.Split(",");
                TicketFairDetails ticket1 = new TicketFairDetails(split);
                Operations.ticketList.Add(ticket1);
                
            }
        }
    
    }
}