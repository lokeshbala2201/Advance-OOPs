using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static long s_registerNumber=51331719106000;

        public string RegisterNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
         
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public RegisterPerson(string name,Gender gender,DateTime dob,long phone,Maritial status,DateTime registrationDate,string father,string mother):base(name,gender,dob, phone,status)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            DateOfRegistration=registrationDate;
            FatherName=father;
            MotherName=mother;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nGender : {Gender}\nDOB : {DOB}\nPhone : {Mobile}\nMaritial Status: {Status}\nRegistration: {DateOfRegistration}\nRegisterNumber : {RegisterNumber}\nFatherName: {FatherName}\nMotherName : {MotherName}\nDate: {DateOfRegistration}");
        }

    }
}