using System;
namespace Polymorphism4;

class Program
{
    
    public static void Main(string[] args)
    {
        PersonalDetails person =new PersonalDetails("Loki","Bala",Gender.male,"B.E");
        FreeLancer free=new FreeLancer("Software Developer",20,person.Name,person.FatherName,person.Gender,person.Qualification);
        free.CalculateSalary();
        free.Display();
        Syncfusion sync=new Syncfusion("Chennai",free.Role,free.NoOfWorkingDays,free.Name,free.FatherName,free.Gender,free.Qualification);
        sync.CalculateSalary();
        sync.Display();

    }
}
