using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierachicalInheritance1
{
    public class Teacher:PersonalInfo
    {
       
        private static int s_teacherID=1000;
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public string Teaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Teacher(string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,string department,string subject,string teaching,string qualification,int yearOfExperience,DateTime doj):base(  name, fatherName,dob,phone, gender, mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            Subject=subject;
            Teaching=teaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=doj;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nFather Name: {FatherName}\nDOB : {DOB}\nPhone : {Phone}\nGender : {Gender}\nMail : {Mail}\nTeacherID : {TeacherID}\nDepartment : {Department}\nSubject : {Subject}\nTeaching : {Teaching}\nQualification : {Qualification}\nYear Of Experience : {YearOfExperience}\nDate Of Joining : {DateOfJoining}\n");
        }
    }
    
}