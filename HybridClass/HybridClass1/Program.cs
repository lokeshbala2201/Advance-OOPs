using System;
using HierachicalInheritance1;
namespace HybridClass1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo(5133,"Loki","Bala",new DateTime(2002,01,22),9080425005,Gender.Male,"loki@gmail.com");
        PersonalInfo person2=new PersonalInfo(5133,"Mani","Murugan",new DateTime(2003,10,22),9123573132,Gender.Male,"mani@gmail.com");
        TheoryExamMarks theory1=new TheoryExamMarks(5133,"Loki","Bala",new DateTime(2002,01,22),9080425005,Gender.Male,"loki@gmail.com",new int[]{89,78,67,89,76,87},new int[]{98,78,65,82,77,87},new int[]{89,08,77,89,55,87},new int[]{89,78,45,67,89,87});
        TheoryExamMarks theory2=new TheoryExamMarks(5133,"Mani","Murugan",new DateTime(2003,10,22),9123573132,Gender.Male,"mani@gmail.com",new int[]{82,78,64,82,77,87},new int[]{34,73,65,33,44,87},new int[]{78,48,77,23,56,89},new int[]{67,34,56,86,89,87});
        Marksheet mark1=new Marksheet(5133,"Loki","Bala",new DateTime(2002,01,22),9080425005,Gender.Male,"loki@gmail.com",new int[]{89,78,67,89,76,87},new int[]{98,78,65,82,77,87},new int[]{89,08,77,89,55,87},new int[]{89,78,45,67,89,87},1001,new DateTime(2023,11,09));
        Marksheet mark2=new Marksheet(5133,"Mani","Murugan",new DateTime(2003,10,22),9123573132,Gender.Male,"mani@gmail.com",new int[]{82,78,64,82,77,87},new int[]{34,73,65,33,44,87},new int[]{78,48,77,23,56,89},new int[]{67,34,56,86,89,87},1002,new DateTime(2023,05,10));
        mark1.CalculateUG();
        mark2.CalculateUG();
        mark1.ShowUGMarkSheet();
        mark2.ShowUGMarkSheet();
    }
}
