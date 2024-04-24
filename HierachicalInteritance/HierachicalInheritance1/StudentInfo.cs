using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierachicalInheritance1
{
    public class StudentInfo:PersonalInfo
    {
       
        private  static  int s_studentID=2000;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }  
        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,string degree,string department,int semester):base(name, fatherName,dob,phone, gender, mail)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nFather Name: {FatherName}\nDOB : {DOB}\nPhone : {Phone}\nGender : {Gender}\nStudentID : {StudentID}\nMail : {Mail}\nDegree : {Degree}\nDepartment : {Department}\nSemester : {Semester}\n");
        }
    }
}