using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
{
    public class StudentInfo : PersonalInfo
    {
        public int RegisterNo  { get; set; } 
        public int Standard { get; set; }
        public string Brance  { get; set; }
        public int AcademicYear{ get; set; }

        public StudentInfo(string name, string fatherName, long phone ,string mail, DateTime dob, Gender gender,int register,int standard,string brance,int academic) : base( name, fatherName, phone , mail, dob,gender){
            RegisterNo=register;
            Standard=standard;
            Brance=brance;
            AcademicYear=academic;
        }

         public void ShowStudentInfo(){
            Console.WriteLine($"Name : {StudentName}\nFather : {FatherName}\nPhone : {Mobile}\nMail : {Mail}\nDOB : {DOB}\nGender : {Gender}\nRegister No : {RegisterNo}\nStandard : {Standard}\nSection : {Brance}\nAcademic Year : {AcademicYear}");
        }
    }
}