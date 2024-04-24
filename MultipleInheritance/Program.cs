using System;
namespace MultipleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person = new PersonalInfo("Loki",Gender.Male,new DateTime(2002,01,22),9080425005,Maritial.Single);
        person.ShowInfo();
        RegisterPerson register=new RegisterPerson(person.Name,person.Gender,person.DOB,person.Mobile,person.Status,new DateTime(2024,04,18),"Bala","Veni");
        register.ShowInfo();

        PersonalInfo person1 = new PersonalInfo("Mani",Gender.Male,new DateTime(2002,06,11),9123573138,Maritial.Married);
        person1.ShowInfo();
        RegisterPerson register1=new RegisterPerson(person1.Name,person1.Gender,person1.DOB,person1.Mobile,person1.Status,new DateTime(2024,04,18),"Murugan","Mala");
        register1.ShowInfo();



    }
}
