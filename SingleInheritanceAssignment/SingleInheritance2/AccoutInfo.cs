using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccoutInfo : PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber  { get; set; } 
        public string Branch { get; set; }
        public string IFCSCode  { get; set; }
        public int Balance{ get; set; }

        public AccoutInfo(string name, string fatherName, long phone ,string mail, DateTime dob, Gender gender, string branch, string ifscode,int balance) : base( name, fatherName, phone , mail, dob,gender){
            AccountNumber="AID"+s_accountNumber;
            Branch=branch;
            IFCSCode=ifscode;
            Balance=balance;
        }

        public void ShowStudentInfo(){
            Console.WriteLine($"Name : {StudentName}\nFather : {FatherName}\nPhone : {Mobile}\nMail : {Mail}\nDOB : {DOB}\nGender : {Gender}\nAccount No : {AccountNumber}\nBranch : {Branch},\nIFSC Code : {IFCSCode}\nBalance : {Balance}");
        }

        public int Deposite(int money)
        {
            return Balance+=money;
        }

        public int Withdraw(int money)
        {
            return Balance-=money;
        }

        public void ShowBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}