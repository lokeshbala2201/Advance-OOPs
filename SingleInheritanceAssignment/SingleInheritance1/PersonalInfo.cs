using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
{
    public enum Gender{select,Male,Female}
    public class PersonalInfo
    {
        
        public string StudentName  { get; set; } 
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Mail{ get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }

        public PersonalInfo(string name, string fatherName, long phone ,string mail, DateTime dob, Gender gender)
        {
            StudentName = name;
            FatherName =fatherName;
            Mobile=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }

       
        
    }
}