using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get;  }
        public string  WorkLocation { get; set; }

        public Syncfusion(string workLocation,string role,int workingDays,string name,string fatherName,Gender gender,string qualification):base(role,workingDays,name,fatherName,gender,qualification)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            WorkLocation=workLocation;
        }

        public override void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine($"Employee ID : {EmployeeID}\nWork Location : {WorkLocation}");
        }

    }
}