using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        //field
        //private
        private int _balance;
        private static int s_customerID=1000;

        //properties
        public int WalletBalance { get{return _balance;} } //read only
        public string CustomerID { get;  }

        //Constractor
        public CustomerDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location,int walletBalance):base(name,fatherName,gender, mobile, dob, mailID,location)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            _balance=walletBalance;
        }
        //methods
        public void WalletRecharge(int money)
        {
            _balance+=money;
        }
        public void DeductBalance(int money)
        {
            _balance-=money;
        }
    }
}