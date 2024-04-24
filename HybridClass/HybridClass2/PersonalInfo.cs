using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridClass2
{
    public enum Gender{select,Male,Female}
    public class PersonalInfo
    {
       
        public string Name { get; set; }  
        public Gender Gender { get; set; }  
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        
     

        public PersonalInfo(string name,DateTime dob,long phone,Gender gender)
        {
        
            Name=name;
            DOB=dob;
            Phone=phone;
            Gender=gender;
      
        }
    }
}