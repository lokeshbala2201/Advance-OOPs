using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism3
{
    public class EEEDepartment:Library
    {
        private static int s_serialNumber=1000;
        public  string SerialNum { get; set; }
        public override string AuthorName { get; set; }
        public  override string BookName { get; set; }
        public override string Publisher { get; set; }
        public override int Year { get; set; }

        
       
        public override void BookInfo(string author,string book,string publisher,int year)
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
            AuthorName=author;
            BookName=book;
            Publisher=publisher;
            Year=year;
            
        }
        public  override void DisplayInfo()
        {
            Console.WriteLine($"Serial No:{SerialNumber}\nAuthor Name : {AuthorName}\nBook Name : {BookName}\nPublisher Name : {Publisher}\nYear : {Year}\n");
        }
    }
}