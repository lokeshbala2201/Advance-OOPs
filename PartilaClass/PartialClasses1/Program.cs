using System;
using PartialClasses1;
namespace Partialclasses1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee =new EmployeeInfo("Lokesh",Gender.Male,new  DateTime (2002,01,22),9080425005);
        employee.Display();
        employee.Update("Loki",Gender.Male,new  DateTime (2002,01,20),9080425005);
        employee.Display();
    }
}
