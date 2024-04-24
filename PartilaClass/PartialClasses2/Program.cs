using System;
using System.Diagnostics;
using PartialClasses2;
namespace PartlaClasses2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student =new StudentInfo("Lokesh",Gender.Male,new  DateTime (2002,01,22),9080425005,89,78,87);
        student.Display();
        Console.WriteLine(student.Total());
        Console.WriteLine(Math.Round(student.Percentage(),2));
        
    }
}