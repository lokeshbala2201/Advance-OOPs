using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class FreeLancer:PersonalDetails
    {
        public string Role { get; set; }
        public int SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        

        public FreeLancer(string role,int workingDays,string name,string fatherName,Gender gender,string qualification):base(name,fatherName,gender,qualification)
        {
            Role=role;
            
            NoOfWorkingDays=workingDays;
        }

        public virtual void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Name : {Name}\nFather Name:{FatherName}\nGender : {Gender}\nQualification : {Qualification}\nRole : {Role}\nSalary Amount : {SalaryAmount}");
        }
    }
}