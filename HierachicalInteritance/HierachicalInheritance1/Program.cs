using System;
namespace HierachicalInheritance1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Lokesh","Bala",new DateTime(2002,01,20),9080425005,Gender.Male,"loki@gmail.com");
        PersonalInfo person2=new PersonalInfo("Mani","Murugan",new DateTime(2001,11,20),6734567865,Gender.Male,"Mani@gmail.com");
        Teacher teacher1=new Teacher(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"ECE","VLSI","Venakt","M.E",2,new DateTime(2002,01,06));
        teacher1.ShowInfo();
    
        Teacher teacher2=new Teacher(person2.Name,person2.FatherName,person2.DOB,person2.Phone,person2.Gender,person2.Mail,"ECE","C#","Meena","M.E (Ph.D)",5,new DateTime(2002,04,06));
        teacher2.ShowInfo();
        StudentInfo student1=new StudentInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"B.E","ECE",01);
        student1.ShowInfo();
    
        StudentInfo Student2=new StudentInfo(person2.Name,person2.FatherName,person2.DOB,person2.Phone,person2.Gender,person2.Mail,"B.E","EEE",02);
        Student2.ShowInfo();
        PrincipalInfo principle1=new  PrincipalInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"Ph.D",10,new DateTime(2013,01,14));
        principle1.ShowInfo();
        PrincipalInfo principle2=new  PrincipalInfo(person2.Name,person2.FatherName,person2.DOB,person2.Phone,person2.Gender,person2.Mail,"Ph.D",11,new DateTime(2012,01,23));
        principle2.ShowInfo();

    }
}
