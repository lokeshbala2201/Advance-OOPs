using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClass1
{
    public class Hack:EmployeeInfo //sealed class cannot inherit
    {
        public string StoreUserID { get; set; }
        public int StorePassword { get; set; }

        public Hack(string userID,int password,string storePassword,int storeUserID):base(userID,password)
        {
            StoreUserID=storeUserID;
            StorePassword=storePassword;
        }
    }
}