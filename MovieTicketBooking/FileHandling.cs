using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace MovieTicketBooking
{
    public class FileHandling
    {
        public static void Create()
        {
            //Ticketbooking directory created
            if(!Directory.Exists("TicketBookingFiles"))
            {
                System.Console.WriteLine("Directory Creating...,");
                Directory.CreateDirectory("TicketBookingFiles");
            }
            else{
                System.Console.WriteLine("Already Exists");
            }

            //customer details csv file created

            if(!File.Exists("TicketBookingFiles\\CustomerDetails.csv"))
            {
                System.Console.WriteLine("File Creating...,");
                File.Create("TicketBookingFiles\\CustomerDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }

             //Theatre details csv file created

            if(!File.Exists("TicketBookingFiles\\TheatreDetails.csv"))
            {
                System.Console.WriteLine("File Creating...,");
                File.Create("TicketBookingFiles\\TheatreDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }

             //Screening details csv file created

            if(!File.Exists("TicketBookingFiles\\ScreeningDetails.csv"))
            {
                System.Console.WriteLine("File Creating...,");
                File.Create("TicketBookingFiles\\ScreeningDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }

            //Movie Details csv file created
            if(!File.Exists("TicketBookingFiles\\MovieDetails.csv"))
            {
                System.Console.WriteLine("File Creating...,");
                File.Create("TicketBookingFiles\\MovieDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }

             //Booking details csv file created

            if(!File.Exists("TicketBookingFiles\\BookingDetails.csv"))
            {
                System.Console.WriteLine("File Creating...,");
                File.Create("TicketBookingFiles\\BookingDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }


            
        }
    
        public static void WriteToCsv()
        {
            //write data of users into csv file
            string[] users=new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                users[i]=Program.userDetailsList[i].UserID+","+Program.userDetailsList[i].WalletBalance+","+Program.userDetailsList[i].Name+","+Program.userDetailsList[i].Age+","+Program.userDetailsList[i].PhoneNumber;

            }
            File.WriteAllLines("TicketBookingFiles\\CustomerDetails.csv",users);


            string[] theatres=new string[Program.theatreDetailsList.Count];
            for(int i=0;i<Program.theatreDetailsList.Count;i++)
            {
                theatres[i]=Program.theatreDetailsList[i].TheatreID+","+Program.theatreDetailsList[i].TheatreName+","+Program.theatreDetailsList[i].TheatreLocation;
            }
            File.WriteAllLines("TicketBookingFiles\\TheatreDetails.csv",theatres);


            string[] screenings=new string[Program.screeningDetailsList.Count];
            for(int i=0;i<Program.screeningDetailsList.Count;i++)
            {
                screenings[i]=Program.screeningDetailsList[i].MovieID+","+Program.screeningDetailsList[i].TheatreID+","+Program.screeningDetailsList[i].NoOfSeats+","+Program.screeningDetailsList[i].TicketPrice;
            }
            File.WriteAllLines("TicketBookingFiles\\ScreeningDetails.csv",screenings);

            string[] movies=new string[Program.movieDetailsList.Count];
            for(int i=0;i<Program.movieDetailsList.Count;i++)
            {
                movies[i]=Program.movieDetailsList[i].MovieID+","+Program.movieDetailsList[i].MovieName+","+Program.movieDetailsList[i].Language;
            }
            File.WriteAllLines("TicketBookingFiles\\MovieDetails.csv",movies);

            string[] bookings=new string[Program.bookingDetailsList.Count];
            for(int i=0;i<Program.bookingDetailsList.Count;i++)
            {
                bookings[i]=Program.bookingDetailsList[i].BookingID+","+Program.bookingDetailsList[i].UserID+","+Program.bookingDetailsList[i].MovieID+","+Program.bookingDetailsList[i].TheatreID+","+Program.bookingDetailsList[i].SeatCount+","+Program.bookingDetailsList[i].TotalAmount+","+Program.bookingDetailsList[i].BookingStatus;
            }
            File.WriteAllLines("TicketBookingFiles\\BookingDetails.csv",bookings);


        }


        public static  void ReadFromCSV()
        {
            //userdetails
            string[] users=new string[Program.userDetailsList.Count];
            for(int i=Program.userDetailsList.Count-1;i<=0;i--)
            {
                string[] split=users[i].Split(",");
                //UserDetails user=UserDetails(split);
            } 
        }

    }
}