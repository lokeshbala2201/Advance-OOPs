using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace HierachicalInheritance1
{
    public class PrincipalInfo:PersonalInfo
    {
        
        private static int s_principleID=500;
        public string PrincipleID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,string qualification,int yearOfExperience,DateTime doj): base( name, fatherName,dob,phone, gender, mail)
        {
            s_principleID++;
            PrincipleID="PID"+s_principleID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=doj;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nFather Name: {FatherName}\nDOB : {DOB}\nPhone : {Phone}\nGender : {Gender}\nMail : {Mail}\nPrincipleID : {PrincipleID}\nQualification : {Qualification}\nYear Of Experience : {YearOfExperience}\nDate Of Joining : {DateOfJoining}\n");
        }

    }

    
}