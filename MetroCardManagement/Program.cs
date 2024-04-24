using System;
namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        //calling create  method in fileHandliing
        FileHandling.Create();


        //default data method calling
        //Operations.DefaultData();


        //calling ReadFromCSV  method in fileHandliing
        FileHandling.ReadFromCSV();

        //main menu calling
        Operations.MainMenu();

        //calling WriteToCSV  method in fileHandliing
        FileHandling.WriteToCsv();
    }
}
