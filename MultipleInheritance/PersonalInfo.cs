using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Gender{select,Male,Female}
    public enum Maritial{select,Married,Single}
    public class PersonalInfo:IShowData
    {
        public string Name { get; set; }
        public Gender  Gender{ get; set; }
        public DateTime DOB { get; set; }
        public long  Mobile { get; set; }
        public Maritial Status { get; set; }

        public PersonalInfo(string name,Gender gender,DateTime dob,long phone,Maritial status)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=phone;
            Status=status;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nGender : {Gender}\nDOB : {DOB}\nPhone : {Mobile}\nMaritial Status: {Status}\n");
        }

    }
}