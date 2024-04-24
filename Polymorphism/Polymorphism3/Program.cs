using System;
namespace Polymorphism3;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eee=new EEEDepartment();
        eee.BookInfo("James","Come TO fly","TNQ",2023);
        eee.DisplayInfo();
        CSEDepartment cse = new CSEDepartment();
        cse.BookInfo("Tom","Aspirants","sync",2024);
        cse.DisplayInfo();

    }
}
