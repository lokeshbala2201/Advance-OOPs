using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HierachicalInheritance1;

namespace SealedClass3
{
    public class FamilyInfo:PersonalInfo
    {
        public string  FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSiblings{ get; set;}
        public string  Native { get; set; }

        public FamilyInfo(string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,string fatherName1,string motherName,int noOfSiblings,string native):base(name,fatherName,dob,phone,gender,mail)
        {
            FatherName=fatherName1;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            Native=native;
        }
        public sealed override void Update(string fatherName1,string motherName,int noOfSiblings,string native)
        {
            FatherName=fatherName1;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            Native=native;
        }



    }
}