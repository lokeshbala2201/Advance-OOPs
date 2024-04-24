using System;
using SingleInheritance1;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo sample=new PersonalInfo("Loki","Bala",9080425005,"loki@gmail.com",new DateTime(2002,01,20),Gender.Male);
        StudentInfo student =new StudentInfo(sample.StudentName,sample.FatherName,sample.Mobile,sample.Mail,sample.DOB,sample.Gender,5133,12,"B",2023);
        student.ShowStudentInfo();
    }    
}
