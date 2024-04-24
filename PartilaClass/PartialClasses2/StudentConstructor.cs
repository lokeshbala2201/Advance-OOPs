using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses2
{
    public partial class StudentInfo
    {
         public StudentInfo(string name,Gender gender,DateTime dob,long phone,double physics,double chemistry,double maths)
       {
        s_studentID++;
        StudentID="EID"+s_studentID;
        Name=name;
        Gender=gender;
        DOB=dob;
        Mobile=phone;
        Physics=physics;
        Chemistry=chemistry;
        Maths=maths;


       } 
    }
}