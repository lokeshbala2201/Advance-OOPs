using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses1
{
    public enum Gender{select,Male,Female}
    public class  EmployeeProps
    {
        
    }
    public partial class EmployeeInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID  { get; set; } 
        public string EmployeeName { get; set; }
        public Gender Gender{ get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
       
    }
}