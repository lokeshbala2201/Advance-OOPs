using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    public static class Operation
    {
        public static CustomerDetails currentUser;
        public static void Line()
        {
            System.Console.WriteLine("----------------------------------------------------------");
           
        }
        //list creatio nfor all classes
        public static CustomList<CustomerDetails>customerList=new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails>foodList=new CustomList<FoodDetails>();
        public static CustomList<OrderDetails>orderList=new CustomList<OrderDetails>();
        public static CustomList<ItemDetails>itemList=new CustomList<ItemDetails>();
        //default data
        public static void DefaultData()
        {
            //customer details default data
            CustomerDetails customer1=new CustomerDetails("Ravi"	,"Ettapparajan",	Gender.Male,	"974774646",new DateTime(1999,11,11),"ravi@gmail.com",	"Chennai",10000	);
            CustomerDetails customer2=new CustomerDetails("Baskaran",	"Sethurajan",	Gender.Male	,"847575775"	,new DateTime(1999,11,11),	"baskaran@gmail.com",	"Chennai",15000);
            customerList.AddRange(new CustomList<CustomerDetails>{customer1,customer2});

            //Food Details defauklt data
            FoodDetails food1=new FoodDetails("Chicken Briyani 1Kg",	100,	12);
            FoodDetails food2=new FoodDetails("Mutton Briyani 1Kg",	150,	10);
            FoodDetails food3=new FoodDetails("Veg Full Meals",	80,	30);
            FoodDetails food4=new FoodDetails("Noodles",	100,	40);
            FoodDetails food5=new FoodDetails("Dosa",	40,	40);
            FoodDetails food6=new FoodDetails("Idly(2 Pieces)",	20,	50);
            FoodDetails food7=new FoodDetails("Pongal",	40,	20);
            FoodDetails food8=new FoodDetails("Vegetable Briyani",	80,	15);
            FoodDetails food9=new FoodDetails("Lemon Rice",	50,	30);
            FoodDetails food10=new FoodDetails("Veg Pulav",	120,	30);
            FoodDetails food11=new FoodDetails("Chicken 65(200 grams)",	75,	30);
            foodList.AddRange(new CustomList<FoodDetails>{food1,food2,food3,food4,food5,food6,food7,food8,food9,food10,food11});

            //order details default data
            OrderDetails order1=new OrderDetails("CID1001",	580	,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("CID1002",	870	,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order3=new OrderDetails("CID1001",	820	,new DateTime(2022,11,26),OrderStatus.Cancelled);
            orderList.AddRange(new CustomList<OrderDetails>{order1,order2,order3});

            //ItemDetails default data
            ItemDetails item1= new ItemDetails("OID3001",	"FID2001",	2,	200);
            ItemDetails item2= new ItemDetails("OID3001",	"FID2002",	2,	300);
            ItemDetails item3= new ItemDetails("OID3001",	"FID2003",	1,	80);
            ItemDetails item4= new ItemDetails("OID3002",	"FID2001",	1,	100);
            ItemDetails item5= new ItemDetails("OID3002",	"FID2002",	4,	600);
            ItemDetails item6= new ItemDetails("OID3002",	"FID2010",	1,	120);
            ItemDetails item7= new ItemDetails("OID3002",	"FID2009",	1,	50);
            ItemDetails item8= new ItemDetails("OID3001",	"FID2002",	2,	300);
            ItemDetails item9= new ItemDetails("OID3001",	"FID2008",	4,	320);
            ItemDetails item10= new ItemDetails("OID3001",	"FID2001",	2,	200);
            itemList.AddRange(new CustomList<ItemDetails>{item1,item2,item3,item4,item5,item6,item7,item8,item9,item10});
            

        }//default data end

        //Main menu
        public static void MainMenu()
        {
            System.Console.WriteLine("****************QWICK FOODZ**********************");
            Line();
            string mainLoop="yes";
            do{
                //need to show main menu option
                Console.WriteLine("1.	Customer Registration\n2.	Customer Login\n3.	Exit");
                //need to ask input from user
                Console.Write("Select the Choice: ");
                int mainChoice=int.Parse(Console.ReadLine());
                switch(mainChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("                  Registration");
                        
                        Line();
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("                  Log In");
                        Line();
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application Closed Successfully.");
                        mainLoop="no";
                        break;
                    }
                }


            }while(mainLoop=="yes");

        }//Main menu ends

        //Registration
        public static void Registration()
        {
            //need to ask parameter of userdatails class from user
            Console.Write("Enter Your Name : ");
            string name=Console.ReadLine();
            Console.Write("Enter Your Father Name : ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter Your Gender : ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter Your Mobile Number : ");
            string mobile=Console.ReadLine();
            Console.Write("Enter Your Date Of Birth : ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter Your Mail ID : ");
            string mailID=Console.ReadLine().ToLower();
            Console.Write("Enter Your Loation : ");
            string location=Console.ReadLine();
            Console.Write("Enter Your WalletBalance : ");
            int balance=int.Parse(Console.ReadLine());
            //create object for  userdetails class
            PersonalDetails person=new PersonalDetails(name,fatherName,gender,mobile,dob,mailID,location);
            CustomerDetails customer=new CustomerDetails(person.Name,person.FatherName,person.Gender,person.Mobile,person.DOB,person.MailID,person.Location,balance);
            //add the object into list
            customerList.Add(customer);
            //need to display customer id
            Console.WriteLine($"Registered Succesfully. your customer ID is {customer.CustomerID}");


            
        }//Registered ends

        //Log in 
        public static void LogIn()
        {
            //need to ask customer ID from user
            Console.Write("Enter your Registeres Customer ID :  ");
            string logIn=Console.ReadLine().ToUpper();
            //validate the customer id
            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerID.Equals(logIn))
                {
                    //assign login user details
                    currentUser=customer;
                    SubMenu();
                }
            }
        }// log in ends

        //submenu 
        public static void SubMenu()
        {
            string subLoop="yes";
            do{
                //need to show the submenu options
                Console.WriteLine("i.	Show Profile\nii.	Order Food\niii.	Cancel Order\niv.	Modify Order\nv.	Order History\nvi.	Recharge Wallet\nvii.	Show Wallet Balance\nviii.	Exit");
                //need to ask select 
                Console.Write("Select the option : ");
                string subMenuChoice=Console.ReadLine();
                switch(subMenuChoice)
                {
                    case "i":
                    {
                        Console.WriteLine("             Your Profile");
                        Line();
                        Profile();
                        break;
                    }
                    case "ii":
                    {
                        Console.WriteLine("             Order Food");
                        Line();
                        OrderFood();
                        break;
                    }
                    case "iii":
                    {
                        Console.WriteLine("             Cancel Food");
                        Line();
                        CancelFood();
                        break;
                    }
                    case "iv":
                    {
                        Console.WriteLine("             Modify Food");
                        Line();
                        ModifyFood();
                        break;
                    }
                    case "v":
                    {
                        Console.WriteLine("             Order History");
                        Line();
                        OrderHistory();
                        break;
                    }
                    case "vi":
                    {
                        Console.WriteLine("             Recharge Wallet");
                        Line();
                        RechargeWallet();
                        break;
                    }
                    case "vii":
                    {
                        Console.WriteLine("             Show Wallet Balance");
                        Line();
                        WalletBalance();
                        break;
                    }
                    case "viii":
                    {
                        Console.WriteLine("Returning to main menu");
                        subLoop="no";
                        break;
                    }
                    
                }

            }while(subLoop=="yes");
        }
    
        //Wallet balance
        public static void WalletBalance()
        {
            //need to show wallet balance
            Console.WriteLine($"Hi {currentUser.Name},");
            Console.WriteLine($"Your Wallet balance is {currentUser.WalletBalance}");
        }//walletbalance ends

        //Wallet recharge
        public static void RechargeWallet()
        {
            //nee to ask recharge amount
            Console.Write("Enter the Amount :  ");
            int money=int.Parse(Console.ReadLine());
            //calling the walletrecharge method 
            currentUser.WalletRecharge(money);
            //need to show the message
            System.Console.WriteLine($"{money} Recharged in your wallet.");
        }
    
        //profile
        public static void Profile()
        {
            //need to show the current your profile
            Console.WriteLine($"Name :{currentUser.Name}\nFather Name :{currentUser.FatherName}\nGender :{currentUser.Gender}\nMobile :{currentUser.Mobile}\nDate Of Birth :{currentUser.DOB}\nMail ID :{currentUser.MailID}\nLocation :{currentUser.Location}\n");

        }//profile ends

        //order History
        public static void OrderHistory()
        {
            //need to show order history of current user 
            System.Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach(OrderDetails order in orderList)
            {
                //check current user orders
                if(currentUser.CustomerID.Equals(order.CustomerID))
                {
                    System.Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.DateOfOrder}|{order.OrderStatus}|");

                }
            }
        }
    
        //order food
        public static void OrderFood()
        {
            //create object for order class
            OrderDetails order= new OrderDetails(currentUser.CustomerID,0,DateTime.Now,OrderStatus.Initiated);
            orderList.Add(order);
            //create local Item list
            CustomList<ItemDetails> localItemList=new CustomList<ItemDetails>();
            
            //need to ask food id
            string wish="yes";
            int totalPrice=0;
            do{
                //need to show the food list
                System.Console.WriteLine("|FoodID|FoodName|PriceOfQuantity|QuuantityAvailable|");
                Line();
                foreach(FoodDetails food in foodList)
                {
                    System.Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.PriceQuantity}|{food.QuantityAvailable}|");

                }
            
                System.Console.Write("Enter the food ID: ");
                string orderFood=Console.ReadLine().ToUpper();
                System.Console.Write("how much you want : ");
                int quantity=int.Parse(Console.ReadLine());
                //validate food id
                bool flag=true;
                foreach(FoodDetails food in foodList)
                {
                    if(food.FoodID.Equals(orderFood))
                    {
                        flag=false;
                        
                        //check the available quantity
                        if(food.QuantityAvailable>=quantity)
                        {
                            totalPrice+=food.PriceQuantity*quantity;
                            //create ItemDetails object
                            ItemDetails items=new ItemDetails(order.OrderID,food.FoodID,quantity,food.PriceQuantity*quantity);
                            localItemList.Add(items);
                            food.QuantityAvailable-=quantity;
                            System.Console.Write("Do you want order more (yes/no) : ");
                            wish=Console.ReadLine();
                        

                        }
                        else{
                            System.Console.WriteLine("Sorry, order quantity not available.");
                        }
                    }
                }
                if(flag){
                    System.Console.WriteLine("Invalid food it");
                }
            }while(wish=="yes");
            //need to ask confirmation order
            System.Console.Write("Confirm the order (yes/no) :");
            string confimation=Console.ReadLine();
            if(confimation.Equals("yes"))
            {
                string wish1="yes";
                do{
                //need to check having suffient balance or not
                    if(currentUser.WalletBalance>=totalPrice)
                    {
                        //change status of order object
                        order.TotalPrice=totalPrice;
                        order.OrderStatus=OrderStatus.Ordered;

                        //deduct the price amount
                        currentUser.DeductBalance(totalPrice);
                        System.Console.WriteLine($"{totalPrice} deducted from your account");
                        itemList=localItemList;
                        break;
                    }
                    else{
                        System.Console.WriteLine("Insufficient Balance");
                        System.Console.Write("Do you want Recharge your wallet(yes/no) : ");
                        wish1=Console.ReadLine();
                        //recharge the wllet
                        if(wish1=="yes")
                        {
                            RechargeWallet();
                            
                        }
                        
                    }
                    
                }while(wish1.Equals("yes"));
            }else
            {
                //need to return the quantity to food list
                foreach(FoodDetails food in foodList)
                {
                    foreach(ItemDetails item in localItemList)
                    {
                        if(item.FoodID.Equals(food.FoodID))
                        {
                            food.QuantityAvailable+=item.PurchaseCount;
                        }
                    }
                }
            }
            


        }
    
        //cancel order
        public static void CancelFood()
        {
            //need the show the current logged user order list
            OrderHistory();
            //need to ask uset input for order id 
            System.Console.Write("Enter the Order ID : ");
            string orderID=Console.ReadLine().ToUpper();
            //validate the order id
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID.Equals(orderID)&& order.OrderStatus==OrderStatus.Ordered)
                {
                    order.OrderStatus=OrderStatus.Cancelled;
                    //refund the amount
                    currentUser.WalletRecharge(order.TotalPrice);
                    System.Console.WriteLine($"{order.TotalPrice} Refunded to your account");
                    //return the quantity to food list
                    foreach(ItemDetails item in itemList)
                    {
                        if(order.OrderID==item.OrderID)
                        {
                            foreach(FoodDetails food in foodList)
                            {
                                if(item.FoodID==food.FoodID)
                                {
                                    food.QuantityAvailable+=item.PurchaseCount;
                                }
                            }
                        }
                    }

                }
            }            
        }//cancel food ends

        //modify the food
        public static void ModifyFood()
        {
            System.Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            Line();
            foreach(OrderDetails order in orderList)
            {
                //check current user orders
                if(currentUser.CustomerID.Equals(order.CustomerID)&& order.OrderStatus==OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.DateOfOrder}|{order.OrderStatus}|");

                }
            } 
            System.Console.Write("Enter the Order ID : ");
            string orderID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("|ItemID|OrderID|FoodID|PurchaseCount|PriceOfOrder|");
            Line();
            bool flag1=true; 
            foreach(ItemDetails item in itemList)
            {
                        
                if(orderID==item.OrderID)
                {
                    System.Console.WriteLine($"|{item.ItemID}|{item.OrderID}|{item.FoodID}|{item.PurchaseCount}|{item.PriceOfOrder}|");
                }
            }    
                
            //validate the order id
            bool flag =true;
            foreach(OrderDetails order in orderList)
            {
                if(orderID.Equals(order.OrderID)&&order.OrderStatus==OrderStatus.Ordered)
                {
                    flag =false;
                    
                    //validate the item number
                    
                    Console.Write("Enter The Item ID: ");
                    string itemID=Console.ReadLine().ToUpper();
                    foreach(ItemDetails item in itemList)
                    {                 
                  
                
                        
                        
                        if(item.ItemID==itemID)
                        {
                            flag1=false;
                            //need to ask new quantity
                            System.Console.Write("Enter the Ne Quantity : ");
                            int newQty=int.Parse(Console.ReadLine());
                            //modify the quantity ot item 
                            item.PurchaseCount=newQty;
                            
                            //need to find the new price amount
                            int newAmount=item.PriceOfOrder;
                            
                            foreach(FoodDetails food in foodList)
                            {
                                if(item.FoodID==food.FoodID)
                                {
                                    currentUser.WalletRecharge(newAmount-newQty*food.PriceQuantity);
                                    //refund the amount or deduct the amount
                                    if(newAmount-newQty*food.PriceQuantity>0)
                                    {
                                        System.Console.WriteLine($"{newAmount-newQty*food.PriceQuantity} Refund to your wallet");
                                    }
                                    else{
                                        System.Console.WriteLine($"{newAmount-newQty*food.PriceQuantity} deducted to your wallet");
                                    }
                                    //return the quantity to food list
                                    int newCount=item.PurchaseCount-newQty;
                                    
                                    food.QuantityAvailable+=newCount;
                                    order.TotalPrice=food.PriceQuantity*newQty;
                                    item.PriceOfOrder=newQty*food.PriceQuantity;

                                }
                            }


                        }
                    }
                    if(flag1)
                    {
                        System.Console.WriteLine("Invalid Cart ID");
                    }
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid Order ID.");
            }
               

            

        }
    }
}