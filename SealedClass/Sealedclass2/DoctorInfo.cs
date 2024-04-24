using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealedclass2
{
    public class DoctorInfo:Patientinfo   //sealed class cannot inheritate
    {
        public static int s_doctorID=2000;
       public string DoctorID { get; set; } 
       public string Dname { get; set; }
       public string FatherName { get; set; }

       public DoctorInfo(string name,string fatherName,int bedNo,string native,string admitfor,string dname,string fatherName):base(name,fatherName,bedNo, native, admitfor);
       public void DisplayInfo()
       {
        Console.WriteLine($"Doctor ID : {DoctorID}\nDoctor Name : {Dname}\nFatherName : {FatherName}\nDoctor ID : {DoctorID}\n");
       }
    }
}