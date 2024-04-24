using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using SingleInheritance1;

namespace MultiLevelInheritance1
{
    public class HSCDetails : StudentInfo
    {
        public int HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage{ get; set; }

        public HSCDetails(string name, string fatherName, long phone ,string mail, DateTime dob, Gender gender,int register,int standard,string brance,int academic,int markSheet) : base(name,fatherName, phone , mail, dob,  gender,register,standard, brance,academic)
        {
            HSCMarksheetNumber=markSheet;
           
           
        }
        public void GetMarks(int physics,int chemistry,int maths){
                Physics=physics;
                Chemistry=chemistry;
                Maths=maths;

        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            double divide=Total/3;
            Percentage=divide;
        }

        public void ShowMarkSheet(){
            Console.WriteLine($"{HSCMarksheetNumber,20}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Physic Mark : {Physics}\nChemistry Mark : {Chemistry}\nMaths Mark : {Maths}\nTotal : {Total}\nPercentage : {Percentage}%");
            Console.WriteLine("-------------------------------------------");

        }


      
    }
}