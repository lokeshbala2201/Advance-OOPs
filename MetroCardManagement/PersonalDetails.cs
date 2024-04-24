using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class used for create object to persinalDetails <see cref="PersonalDetails"/> 
    /// </summary> 
    public class PersonalDetails
    {
        //properties
        
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }

        //constructor
        /// <summary>
        /// This constructor initialize the object with parameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param> 
       
        public PersonalDetails(string name,long phone)
        {
            UserName=name;
            PhoneNumber=phone;
        }
        
        public PersonalDetails(string[] user)
        {
            UserName=user[1];
            PhoneNumber=long.Parse(user[2]);
        }
    }
}