using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClass1
{
    public sealed class EmployeeInfo
    {
        public int KeyInfo=100;
        public string UserID { get; set; }
        public int Password { get; set; }

        public EmployeeInfo(string userID,int password)
        {
            UserID=userID;
            Password=password;
        }
        public void UpdateInfo(string userID,int password)
        {
            UserID=userID;
            Password=password;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"User ID : {UserID}\nPassword : {Password}");
            

        }
    }
}