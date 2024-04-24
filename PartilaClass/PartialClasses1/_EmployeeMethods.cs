using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses1
{
    public partial  class  EmployeeInfo
    {
        public void  Display(){
            Console.WriteLine($"Employee ID : {EmployeeID}\nEmployee Name : {EmployeeName}\nEmployee Gender : {Gender}\nEmployee DOB : {DOB}\nEmployee Phone : {Mobile}");
        }

        public void Update(string name,Gender gender,DateTime dob,long phone){
            EmployeeName=name;
            Gender=gender;
            DOB=dob;
            Mobile=phone;

        }
    }
}