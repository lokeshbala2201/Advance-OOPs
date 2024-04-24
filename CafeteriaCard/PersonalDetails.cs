using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    //enum creation for gender
    public enum Gender{select,Male,Female,Transgender}
    public class PersonalDetails
    {
        //properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public string MailId { get; set; }

        //constructor
        public PersonalDetails(string name, string fatherName, Gender gender, long phone ,string mail)
        {
            Name = name;
            FatherName =fatherName;
            Gender=gender;
            Mobile=phone;
            MailId=mail;
        }    
       
           
    }
}