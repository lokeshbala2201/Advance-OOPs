using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class used for create object of UserDetail<see cref="UserDetails">
    /// </summary> 
    public class UserDetails:PersonalDetails,IBalance
    {
        //field
        //static
        private static int s_cardnumber=1000;
        
        //properties
        public string CardNumber { get;  }//readonly property
        public int Balance { get; set; }

        //Constructor
        /// <summary>
        /// This constructor initialize the UserDetails class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public UserDetails(string name,long phone,int balance):base(name,phone)
        {
            //auto incrementation
            s_cardnumber++;
            CardNumber="CMR"+s_cardnumber;
           
            Balance=balance;
        }
        public UserDetails(string[] user):base(user[1],long.Parse(user[2]))
        {
            
            s_cardnumber=int.Parse(user[0].Remove(0,3));
            CardNumber=user[0];
           
            Balance=int.Parse(user[3]);
        }
        //methods
        public void WalletRecharge(int money)
        {
            Balance+=money;
        }
        public void DeductBalance(int money)
        {
            Balance-=money;
        }
    }
}