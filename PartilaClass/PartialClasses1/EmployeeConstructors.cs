using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses1
{
    public partial class EmployeeInfo
    {
       public EmployeeInfo(string name,Gender gender,DateTime dob,long phone)
       {
        s_employeeID++;
        EmployeeID="EID"+s_employeeID;
        EmployeeName=name;
        Gender=gender;
        DOB=dob;
        Mobile=phone;


       } 
    }
}