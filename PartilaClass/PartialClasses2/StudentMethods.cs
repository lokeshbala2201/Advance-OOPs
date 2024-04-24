using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses2
{
    public partial class StudentInfo
    {
        public double Total(){
            return Physics+Chemistry+Maths;
        }
        public double Percentage()
        {
            double total=Physics+Chemistry+Maths;
            return total/3;
        }
         public void  Display(){
            Console.WriteLine($"Employee ID : {StudentID}\nEmployee Name : {Name}\nEmployee Gender : {Gender}\nEmployee DOB : {DOB}\nEmployee Phone : {Mobile}\nPhysics : {Physics}\nChemistry : {Chemistry}\nMaths : {Maths}");
        }
    }
}