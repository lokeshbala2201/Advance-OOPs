using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HierachicalInheritance1;

namespace HybridClass1
{
    public class Marksheet:TheoryExamMarks,ICalculate
    {
        public int MarksheetNumber { get; set; }
        public DateTime DOI { get; set; }
        public int Total{ get; set; }
        public int ProjectMark { get; set; }
        public double Percentage { get; set; }
        
        

        
        public Marksheet(int Rnumber,string name,string fatherName,DateTime dob,long phone,Gender gender,string mail,int[] sem1,int[] sem2,int[] sem3,int[] sem4,int marksheetNumber,DateTime doi):base(Rnumber,name,fatherName,dob,phone,gender,mail,sem1,sem2,sem3,sem4)
        {
            MarksheetNumber=marksheetNumber;
            DOI=doi;
        }
        public void CalculateUG()
        {
            int totalMark=0;
            foreach(int i in Sem1)
            {
               totalMark+=i;  
            }
            foreach(int i in Sem2)
            {
               totalMark+=i;  
            }
            foreach(int i in Sem3)
            {
               totalMark+=i;  
            }  
            foreach(int i in Sem4)
            {
               totalMark+=i;  
            }
            Total=totalMark;
            Percentage=(double)Total/2400.00*100;
        }
        public void ShowUGMarkSheet()
        {
            Console.WriteLine($"Register No : {RNumber}\nName : {Name}\nFather Name : {FatherName}\nPhone : {Phone}\nDOB : {DOB}\nGender : {Gender}");
            Console.WriteLine("SEMESTER1");
            Console.WriteLine($"Mark1: {Sem1[0]}\nMark2: {Sem1[1]}\nMark3: {Sem1[2]}\nMark4: {Sem1[3]}\nMark5: {Sem1[4]}\nMark6: {Sem1[5]}\n");
            Console.WriteLine("SEMESTER2");
            Console.WriteLine($"Mark1: {Sem2[0]}\nMark2: {Sem2[1]}\nMark3: {Sem2[2]}\nMark4: {Sem2[3]}\nMark5: {Sem2[4]}\nMark6: {Sem2[5]}\n");
            Console.WriteLine("SEMESTER1");
            Console.WriteLine($"Mark1: {Sem1[0]}\nMark2: {Sem3[1]}\nMark3: {Sem3[2]}\nMark4: {Sem3[3]}\nMark5: {Sem3[4]}\nMark6: {Sem3[5]}\n");
            Console.WriteLine("SEMESTER1");
            Console.WriteLine($"Mark1: {Sem1[0]}\nMark2: {Sem4[1]}\nMark3: {Sem4[2]}\nMark4: {Sem4[3]}\nMark5: {Sem4[4]}\nMark6: {Sem4[5]}\n");
            Console.WriteLine($"Total : {Total}");
            Console.WriteLine($"Percentage : {Percentage} %");
        }
        

    }
}