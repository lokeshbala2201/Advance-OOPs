using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealedclass2
{
    public sealed class Patientinfo
    {
        private static int s_patientID=1000;
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string  FatherName { get; set; }
        public int BedNo { get; set; }
        public string  NativePlace { get; set; }
        public string  Admittedfor { get; set; }

        public Patientinfo(string name,string fatherName,int bedNo,string native,string admitfor )
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=native;
            Admittedfor=admitfor;
        }
        public void DisplayFor()
        {
            Console.WriteLine($"PatientNo : {PatientID}\nName : {Name}\nFatherName: {FatherName}\nBedNo : {BedNo}\nNative : {NativePlace}\nAdmitfor : {Admittedfor}\n");
        }
    }
}    