using System;
using System.Collections.Generic;
using SingleInheritance2;
namespace SingleInheritanc2;
class Program{
    public static void Main(string[] args)
    {
        List<AccoutInfo> AccounList= new List<AccoutInfo>();
        PersonalInfo person1 = new PersonalInfo("Loki","Bala",9080425005,"loki@gmail.com",new DateTime (2002,01,20),Gender.Male);
        PersonalInfo person2 = new PersonalInfo("Loki","Bala",9080425005,"loki@gmail.com",new DateTime (2002,01,20),Gender.Male);
        PersonalInfo person3 = new PersonalInfo("Loki","Bala",9080425005,"loki@gmail.com",new DateTime (2002,01,20),Gender.Male);
        AccoutInfo accout1=new AccoutInfo(person1.StudentName,person1.FatherName,person1.Mobile,person1.Mail,person1.DOB,person1.Gender,"Vadapalani","HDFC1004",1546);
        AccoutInfo accout2=new AccoutInfo(person2.StudentName,person2.FatherName,person2.Mobile,person2.Mail,person2.DOB,person2.Gender,"Vadapalani","HDFC1004",5000);
        AccoutInfo accout3=new AccoutInfo(person3.StudentName,person3.FatherName,person3.Mobile,person3.Mail,person3.DOB,person3.Gender,"Tambaram","HDFC1007",7000);

        AccounList.AddRange(new List<AccoutInfo>{accout1,accout2,accout3});

        foreach(AccoutInfo accout in AccounList)
        {
            accout.ShowStudentInfo();
            Console.WriteLine($"Your Deposite Amount is {accout.Deposite(500)}");
            Console.WriteLine($"Your WithDraw Amount is {accout.Withdraw(100)}");
            accout.ShowBalance();
        }
    }
}
