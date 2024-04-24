using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace HybridClass2
{
    public enum AccountType{select,Saving,Balance}
    public class SavingAccount:IDInfo,ICalculate,IBankInfo
    {
        public long AccountNumber { get; set; }   
        public AccountType Type { get; set; }
        public int Balance { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Brance { get; set; }

        public SavingAccount(string name,DateTime dob,long phone,Gender gender,int voterID,long aadharId,string panID,long acountNumber,AccountType type,int balance,string bankName,string ifsc,string branch ):base(name,dob,phone,gender,voterID,aadharId,panID )
        {
            AccountNumber=acountNumber;
            Type=type;
            Balance=balance;
            BankName=bankName;
            IFSC=ifsc;
            Brance=branch;
        }

        public void Deposit(int money)
        {
            Balance+=money;
        }
        public void WithDraw(int money)
        {
            Balance-=money;
        }
        public void BalanceCheck()
        {
            System.Console.WriteLine($"Your Balance is {Balance}");
        }


    }
}