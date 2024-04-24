using System;
namespace HybridClass2;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Loki",new DateTime(2002,01,22),9080425005,Gender.Male);
        IDInfo ID=new IDInfo(person.Name,person.DOB,person.Phone,person.Gender,45234567,814531453187,"GWCP8021N");
        SavingAccount savings=new SavingAccount(person.Name,person.DOB,person.Phone,person.Gender,ID.VoteID,ID.AdharID,ID.PanID,6364767890,AccountType.Saving,500,"Indian BanK","IB500034","vadapalani");
        savings.Deposit(50);
        savings.WithDraw(25);
        savings.BalanceCheck();
    }
}
