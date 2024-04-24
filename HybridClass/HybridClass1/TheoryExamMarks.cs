using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HierachicalInheritance1;

namespace HybridClass1
{
    public class TheoryExamMarks:PersonalInfo
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }

        public TheoryExamMarks(int Rnumber,string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,int[] sem1,int[] sem2,int[] sem3,int[] sem4):base(Rnumber,name,fatherName,dob,phone,gender,mail)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
    }
}