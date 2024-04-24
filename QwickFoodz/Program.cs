using System;
using Qwick_Foodz;
namespace QwickFoodz;
class Program
{
    public static void Main(string[] args)
    {
        //calling file create method
        FileHandling.Create();

        //calling default data method
        Operation.DefaultData();


        //calling main menu
        Operation.MainMenu();

        //calling Write To cs file
        FileHandling.WriteToCSV();
    }
}

