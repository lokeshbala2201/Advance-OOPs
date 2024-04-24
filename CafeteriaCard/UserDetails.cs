using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    /// <summary>
    /// This class used for make object to User<see cref="UserDetails"/> 
    /// </summary>
    public class UserDetails:PersonalDetails,IBalance
    {
        //field
        //private
        private int _balance;
        //static
        private static int s_userID=1000;
        //properties
        public string UserID { get;  }//readonly properties
        public string WorkStationNumber { get; set; }
        public int WalletBalance { get{return _balance;}set{_balance=value;}}

        //Constructor
        /// <summary>
        /// This constructor initialize the user object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="phone"></param>
        /// <param name="mail"></param>
        /// <param name="workStationNumber"></param>
        /// <param name="walletBalance"></param> <summary>
        
        public UserDetails(string name, string fatherName, Gender gender, long phone ,string mail,string  workStationNumber,int walletBalance):base(name,fatherName,gender,phone ,mail)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            _balance=walletBalance;
        }
        //method
        /// <summary>
        /// This method used for wallet recharge
        /// </summary>
        /// <param name="money"></param>
        public void WalletRecharge(int money)
        {
            _balance+=money;
        }
        /// <summary>
        /// This method used for deduct the amount from wallet
        /// </summary>
        /// <param name="money"></param>
        public void DeductAmount(int money)
        {
            _balance-=money;
        }

    }
}