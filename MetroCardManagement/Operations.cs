using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class contains Operation of MetroCardMangement<see cref="Operations"/>
    /// </summary>
    public static class Operations
    {

        public static void Line()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
        //assign current user object
        public static UserDetails currentuser;
        
        //list creation
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList=new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketList=new CustomList<TicketFairDetails>();


        //add default data 
        public static void DefaultData()
        {
            //userDetails default data
            UserDetails user1=new UserDetails(" Ravi",9848812345,1000);
            UserDetails user2=new UserDetails("Baskaran",	9948854321,	1000);
            userList.AddRange(new CustomList<UserDetails>{user1,user2});

            //Traval details default data
            TravelDetails travel1=new TravelDetails("CMRL1001",	"Airport",	"Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2=new TravelDetails("CMRL1001",	"Egmore",	"Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3=new TravelDetails("CMRL1002",	"Alandur",	"Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4=new TravelDetails("CMRL1002",	"Egmore",	"Thirumangalam",new DateTime(2023,11,10),25);
            travelList.AddRange(new CustomList<TravelDetails>{travel1,travel2,travel3,travel4});

            //Ticket details default data
            TicketFairDetails ticket1=new TicketFairDetails("Airport","Egmore",	55);
            TicketFairDetails ticket2=new TicketFairDetails("Airport",	"Koyambedu",	25);
            TicketFairDetails ticket3=new TicketFairDetails("Alandur",	"Koyambedu"	,25);
            TicketFairDetails ticket4=new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticket5=new TicketFairDetails("Vadapalani",	"Egmore",	45);
            TicketFairDetails ticket6=new TicketFairDetails("Arumbakkam",	"Egmore",	25);
            TicketFairDetails ticket7=new TicketFairDetails("Vadapalani",	"Koyambedu",	25);
            TicketFairDetails ticket8=new TicketFairDetails("Arumbakkam",	"Koyambedu",	16);
            ticketList.AddRange(new CustomList<TicketFairDetails>{ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});

        }//add default ends
    
        //Main menu 
        public static void MainMenu()
        {
            Console.WriteLine("*************WELCOME TO CHENNAI METRO******************");
            Line();
            string mainLoop="yes";
            do{
                //show the main menu option
                Console.WriteLine("1.  New User Registration\n2.  Login User\n3.  Exit");
                Console.Write("Select the Option :  ");
                //need to ask user input
                int mainMenuChoice=int.Parse(Console.ReadLine());
                switch(mainMenuChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("                  Registrstion                 ");
                        Line();
                        Registration();
                        
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("                  Log IN                 ");
                       
                        Line();
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application closed Succesfully :-)");
                        mainLoop="no";
                        break;
                    }
                }
            }while(mainLoop=="yes");
        }//main menu ends

        //Registration
        public static void Registration()
        {
            //need to ask user inputs
            Console.Write("Enter Your Name : ");
            string name=Console.ReadLine();
            Console.Write("Enter Your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter Your Balance : ");
            int balance=int.Parse(Console.ReadLine());
            //create object for user details using user input
            PersonalDetails person=new PersonalDetails(name,phoneNumber);
            UserDetails user = new UserDetails(person.UserName,person.PhoneNumber,balance);
            //add the object to the user list
            userList.Add(user);
            //need to show the user card number
            Console.WriteLine($"Your Card Number is {user.CardNumber}");
        }//reginstration end

        //Log in 
        public static void LogIn()
        {
            //need to ask card number to validate
            Console.Write("Enter your Card Number : ");
            string login=Console.ReadLine().ToUpper();
            //validate the cardnumber
            foreach(UserDetails user in userList)
            {
                if(login.Equals(user.CardNumber))
                {
                    Console.WriteLine($"Hi {user.UserName},");
                    currentuser=user;   
                    SubMenu();
                }
            }
        }//log in ends

        //submenu
        public static void SubMenu()
        {
            string subLoop="yes";
            do{
            //show the submenu choices
            Console.WriteLine("a.	Balance Check\nb.	Recharge\nc.	View Travel History\nd.	Travel\ne.	Exit ");
            //need to ask option input from user
            Console.Write("Select the option : ");
            string subMenuChoice=Console.ReadLine();
            switch(subMenuChoice)
            {
                case "a":
                {
                    Console.WriteLine("               Balance Check              ");
                    Line();
                    BalanceCheck();
                    break;
                }
                case "b":
                {
                    Console.WriteLine("               Recharge              ");
                    Line();
                    Recharge();
                    break;
                }
                case "c":
                {
                    Console.WriteLine("               View Travel History             ");
                    Line();
                    ViewTravelHistory();
                    break;
                }
                case "d":
                {
                    Console.WriteLine("               Travel              ");
                    Line();
                    Travel();
                    break;
                }
                case "e":
                {
                    Console.WriteLine("Returning to Main Menu ");
                    subLoop="no";
                    break;
                }
            } 
            }while(subLoop=="yes");
            

        }//submenu ends

        //balance check
        public static void BalanceCheck()
        {
            //show the balance of current user
            Console.WriteLine($"Your Available balance is {currentuser.Balance}");
        }//balance check ends

        //Recharge
        public static void Recharge()
        {
            //need to ask recharge amount from user
            Console.Write("Enter The Amount: ");
            int money=int.Parse(Console.ReadLine());
            // add the amount to balance
            currentuser.WalletRecharge(money);
            Console.WriteLine($"{money} is Recharged.");
            Console.WriteLine();

        }//Recharge ends

        //view travel history
        public static void ViewTravelHistory()
        {
            Console.WriteLine("|Travel ID|Card Number|FromLocation|ToLocation|Date              |TravelCost|");
            Console.WriteLine("-------------------------------------------------------------------------------");
            // need to check cardnumber in travel details
            foreach(TravelDetails travel in travelList)
            {
                if(currentuser.CardNumber.Equals(travel.CardNummber))
                {
                    //need to display travel history
                    Console.WriteLine($"|{travel.TravelID}|{travel.CardNummber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Date}|{travel.TravelCost}|");
                }

            }

        }//view travel histroy ends

        //Travel
        public static void Travel()
        {
            //need to show fair details list
           Console.WriteLine("|Ticket ID|From Location |To Location|Fair|"); 
           foreach(TicketFairDetails ticket in ticketList)
           {
                Console.WriteLine($"|{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}|");
           }
           //need to ask enter ticket id
           Console.Write("Enter the Ticket ID : ");
           string ticketID=Console.ReadLine().ToUpper();
           //check the ticket id correct or not
           bool flag = true;
           foreach(TicketFairDetails ticket in ticketList)
           {
                
                if(ticket.TicketID.Equals(ticketID))
                {
                    string balanceLoop="yes";
                    while(balanceLoop=="yes")
                    {
                    flag=false;
                    //need to ticket price availabel in account
                    if(currentuser.Balance>=ticket.TicketPrice)
                    {
                        //deduct the amount from the balance
                        currentuser.DeductBalance(ticket.TicketPrice);
                        Console.WriteLine($"Ticket price {ticket.TicketPrice}rs Deducted from your balance.");
                        //create object for travel details
                        TravelDetails travel = new TravelDetails(currentuser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);
                        //add the trave details object in travel details
                        travelList.Add(travel);
                        Console.WriteLine($"Your travel ID is {travel.TravelID}");
                        Console.WriteLine($"Happy Journey {currentuser.UserName}");
                        break;
                    }
                    else{
                        //need to show insuffient message
                       Console.WriteLine("Insuffient balance");
                       //need to ask recharge option
                       Console.Write("Do you want to Recharge (yes/no) : ");
                       string wishToRecharge=Console.ReadLine();
                       if(wishToRecharge.Equals("yes"))
                       {
                            Console.Write("Enter the amount :  ");
                            int money=int.Parse(Console.ReadLine());
                            currentuser.WalletRecharge(money);
                       }
                       else{
                        balanceLoop="no";
                       } 
                    }
                    }
                }
           }
           if(flag){
            Console.WriteLine("Enter the Valid ticket ID");
           }
        }//traval  ends

    }
}