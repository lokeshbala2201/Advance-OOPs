using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace Qwick_Foodz
{
    public static class FileHandling
    {
        public static void Create()
        {
            //directory
            if(!Directory.Exists("QwickFoodz"))
            {
                System.Console.WriteLine("Directory created");
                Directory.CreateDirectory("QwickFoodz");
            }
            else{
                System.Console.WriteLine("Already Exists");
            }
            //user datails
            if(!File.Exists("QwickFoodz\\UserDetails.csv"))
            {
                System.Console.WriteLine("File created");
                File.Create("QwickFoodz\\UserDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }
            //food details
            if(!File.Exists("QwickFoodz\\FoodDetails.csv"))
            {
                System.Console.WriteLine("File created");
                File.Create("QwickFoodz\\FoodDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }
            //itemdetails
            if(!File.Exists("QwickFoodz\\ItemDetails.csv"))
            {
                System.Console.WriteLine("File created");
                File.Create("QwickFoodz\\ItemDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }//order Details
            if(!File.Exists("QwickFoodz\\OrderDatails.csv"))
            {
                System.Console.WriteLine("File created");
                File.Create("QwickFoodz\\OrderDetails.csv").Close();
            }
            else{
                System.Console.WriteLine("Already Exists");
            }
        }
    
        public static void WriteToCSV()
        {
            //user details
            string[] user=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                user[i]=Operation.customerList[i].CustomerID+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].Mobile+","+Operation.customerList[i].DOB.ToString("dd/MM/yyyy hh:mm:ss tt")+","+Operation.customerList[i].MailID+","+Operation.customerList[i].Location;

            }
            File.WriteAllLines("QwickFoodz\\UserDetails.csv",user);

            //Food Details
            string[] foods=new string[Operation.foodList.Count];
            for(int i=0;i<Operation.foodList.Count;i++)
            {
                foods[i]=Operation.foodList[i].FoodID+","+Operation.foodList[i].FoodName+","+Operation.foodList[i].PriceQuantity+","+Operation.foodList[i].QuantityAvailable;
            }
            File.WriteAllLines("QwickFoodz\\UserDetails.csv",user);

            

        }
    }
}