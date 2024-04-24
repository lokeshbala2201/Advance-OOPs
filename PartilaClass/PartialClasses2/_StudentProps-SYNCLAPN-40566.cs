using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses2
{
    public enum Gender{select,Male,Female}
    public partial class  StudentInfo
    {
         private static int s_studentID=1000;
        public string StudentID  { get; set; } 
        public string Name { get; set; }
        public Gender Gender{ get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
    }
}