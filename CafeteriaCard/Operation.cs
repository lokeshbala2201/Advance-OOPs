using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Transactions;

namespace CafeteriaCard
{
    public static class Operation
    {
        //Default data adding
        static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();
        static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        static CustomList<OrderDatails> orderList=new CustomList<OrderDatails>();
        static CustomList<CartItem> itemList=new CustomList<CartItem>();
        //need to store current user details.
        static UserDetails currentUser;
        public static void DefaultData()
        {
            //default data for food details
            FoodDetails food1=new FoodDetails("Coffee",	20	,100);
            FoodDetails food2=new FoodDetails("Tea",	15	,100);
            FoodDetails food3=new FoodDetails("Biscuit",	10	,100);
            FoodDetails food4=new FoodDetails("Juice",	50	,100);
            FoodDetails food5=new FoodDetails("Puff",	40	,100);
            FoodDetails food6=new FoodDetails("Milk",	10	,100);
            FoodDetails food7=new FoodDetails("Popcorn",	20	,20);
            foodList.AddRange(new CustomList<FoodDetails>{food1,food2,food3,food4,food5,food6,food7});

            //default data for user details
            UserDetails user1=new UserDetails("Ravichandran",	"Ettapparajan",Gender.Male,	8857777575	,"ravi@gmail.com",	"WS101",	400);
            UserDetails user2=new UserDetails("Baskaran",	"Sethurajan",Gender.Male,	9577747744	,"baskaran@gmail.com",	"WS105",	500);
            userList.AddRange(new CustomList<UserDetails>{user1,user2});

            //default data for order details
            OrderDatails order1=new OrderDatails("SF1001",new	DateTime(2022,06,15)	,70	,Status.Ordered);
            OrderDatails order2=new OrderDatails("SF1002",new	DateTime(2022,06,15),	100	,Status.Ordered);
            orderList.AddRange(new CustomList<OrderDatails>{order1,order2});

            //default data for Cartitem
            CartItem item1=new CartItem("OID1001",	"FID101",	20	,1);
            CartItem item2=new CartItem("OID1001",	"FID103",	10	,1);
            CartItem item3=new CartItem("OID1001",	"FID105",	40	,1);
            CartItem item4=new CartItem("OID1002",	"FID103",	10	,1);
            CartItem item5=new CartItem("OID1002",	"FID104",	50	,1);
            CartItem item6=new CartItem("OID1002",	"FID105",	40	,1);
            itemList.AddRange(new CustomList<CartItem>{item1,item2,item3,item4,item5,item6});
        }// default adding end

        //Main menu
        static void line(){
            Console.WriteLine("-----------------------------------------");
        }
        public static void MainMenu()
        {
            //structure of main menu
            Console.WriteLine();
            Console.WriteLine("*************WELCOME TO SYNCFUSION CAFETERIA***************");
            Console.WriteLine();
            line();
            //looping condition
            string mainLoop="yes";
            do{
                Console.WriteLine("           MAIN MENU           ");
                line();
                Console.WriteLine("1. User Registration\n2. User Login\n3. Exit");
                //need to ask input from user
                Console.Write("Select An Option:  ");
                string mainChoice=Console.ReadLine();
                switch(mainChoice)
                {
                    case "1":
                    {
                        Console.WriteLine("           Registration           ");
                        line();
                        Registration();
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("           LogIn           ");
                        line();
                        Login();
                        break;
                    }
                    case "3":
                    {
                        Console.WriteLine("Application Closed Successfully :-)");
                        mainLoop="no";
                        break;
                    }
                }
            }while(mainLoop.Equals("yes"));   

            
        }//main menu ends

        //registration
        public static void Registration()
        {
            //need to ask personal information from user
            Console.Write("Enter Your Name:  ");
            string name=Console.ReadLine();
            Console.Write("Enter Your Father Name:  ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter Phone No:  ");
            long mobile=long.Parse(Console.ReadLine());
            Console.Write("Enter Your Gender:  ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter Your Mail ID:  ");
            string mail=Console.ReadLine();
            Console.Write("Enter Your Workstation Number:  ");
            string Workstation=Console.ReadLine();
            Console.Write("Enter Your Balance:  ");
            int balance=int.Parse(Console.ReadLine());
            //create object of userdetails
            UserDetails user = new UserDetails(name,fatherName,gender,mobile,mail.ToLower(),Workstation,balance);
            //add to List 
            userList.Add(user);
            //show the user details
            Console.WriteLine($"Registered Succesfully. Your User ID is {user.UserID}");
            Console.WriteLine();

        }//Registration ends

        //Login start
        public static void Login()
        {
            //need to ask user id for log in verification
            Console.Write("Enter Your Registered UserID:  ");
            string logIn=Console.ReadLine();
            //verification user id present or not
            foreach(UserDetails user in userList)
            {
                if(logIn.ToUpper().Equals(user.UserID))
                {
                    currentUser=user;
                    SubMenu();
                    
                }
            }
        }//Login ends

        //Submenu
        public static void SubMenu(){
            string subMenuLoop="yes";
                //structure of submenu    
                do{
                    Console.WriteLine("              Sub Menu               ");
                    line();
                    Console.WriteLine();
                    //need to show submenu 
                    Console.WriteLine($"a.	 Show My Profile\nb.	 Food Order\nc.	 Modify Order\nd.	 Cancel Order\ne.	 Order History\nf.	 Wallet Recharge\ng.	 Show WalletBalance\nh.	 Exit");
                    //need to ask input from user
                    Console.Write("Select the Option:  ");
                    string subMenuChoice=Console.ReadLine();
                    switch(subMenuChoice)
                    {
                        case "a":
                        {
                            Console.WriteLine("                 Your Profile                ");
                            line();
                            ShowProfile();
                            break;
                        }
                        case "b":
                        {
                            Console.WriteLine("                 Food Order                ");
                            line();
                            FoodOrder();
                            break;
                        }
                        case "c":
                        {
                            Console.WriteLine("                 Modify Order                ");
                            line();
                            ModifyOrder();
                            break;
                        }
                        case "d":
                        {
                            Console.WriteLine("                 Cancel Order                ");
                            line();
                            CancelOrder();

                            break;
                        }
                        case "e":
                        {
                            Console.WriteLine("                 Order Histrory                ");
                            line();
                            OrderHistory();
                            break;
                        }
                        case "f":
                        {
                            Console.WriteLine("                 Wallet Recharge                ");
                            line();
                            WalletRecharge();
                            break;
                        }
                        case "g":
                        {
                            Console.WriteLine("                 Wallet Balance                ");
                            line();
                            WalletBalance();
                            break;
                        }
                        case "h":
                        {
                            Console.WriteLine("Returning to Main Menu");
                            subMenuLoop="no";
                            break;
                        }
                    }
                }while(subMenuLoop.Equals("yes"));
        }//submenu ends

        //Show profile
        public static void ShowProfile()
        {
            foreach(UserDetails user in userList)
            {
                //need to check current user id in user Details
                if(currentUser.UserID.Equals(user.UserID))
                {
                    //need to Show profile
                    Console.WriteLine($"Name : {currentUser.Name}\nFather Name : {currentUser.FatherName}\nGender : {currentUser.Gender}\nPhone No : {currentUser.Mobile}\nMail ID : {currentUser.MailId}");
                    Console.WriteLine();
                }
            }
        }//show Profile ends

        //Food Order
        public static void FoodOrder()
        {
            
            //temporary cartlist
            CustomList<CartItem> tempCartList=new CustomList<CartItem>();
            OrderDatails order;
            string wish="";
            bool flag=false;
            order=new OrderDatails(currentUser.UserID,DateTime.Now,0,Status.Initiated);
            do{
                //need to show food details
                Console.WriteLine("|Food ID|Food Name|Price|Available Qty|");
                line();
                foreach(FoodDetails food in foodList)
                {
                    Console.WriteLine($"|{food.FoodID,-7}|{food.FoodName,-9}|{food.FoodPrice,-5}|{food.AvailableQuantity,-13}|");
                }
                //create object for oderDetails
                
                //need to ask food selection via food id & qty
                Console.Write("Select Your Food via Food ID:  ");
                string foodItem=Console.ReadLine();
                Console.Write("Enter the Quantity:  ");
                int qtyFood=int.Parse(Console.ReadLine());
                int totalPrice;
                
                foreach(FoodDetails food in foodList)
                {
                    if(foodItem.Equals(food.FoodID) && food.AvailableQuantity>qtyFood)
                    {
                        flag=true;
                        totalPrice=food.FoodPrice*qtyFood;
                        food.AvailableQuantity-=qtyFood;
                        CartItem cart=new CartItem(order.OrderID,food.FoodID,totalPrice,qtyFood);
                        tempCartList.Add(cart);
                        Console.Write("You want to pick another food (yes/no):  ");
                        wish=Console.ReadLine();
                    }
                }

            }while(wish.Equals("yes"));
            if(flag==false)
            {
               Console.WriteLine("Enter the correct Food ID Or Stock is anot available"); 
            }else{
                Console.Write("Confirm to Purchase (yes/no): ");
                string confirmation=Console.ReadLine();
                if(confirmation.Equals("yes"))
                {
                    int totalPriceCalculate=0;
                    //caclulate total price
                    foreach(CartItem cart in tempCartList)
                    {
                        totalPriceCalculate+=cart.OrderPrice;
                    }
                    int wishRechargeint=0;
                    while(wishRechargeint<1)
                    {
                    // need to check sufficient balance
                    if(totalPriceCalculate<currentUser.WalletBalance)
                    {
                        currentUser.DeductAmount(totalPriceCalculate);
                        itemList=tempCartList;
                        OrderDatails order1=order;
                        order1.TotalPrcie=totalPriceCalculate;
                        order1.Status=Status.Ordered;
                        orderList.Add(order1);
                        Console.WriteLine($"{totalPriceCalculate} is deducted from your Wallet");
                        Console.WriteLine($"Order placed successfully, and OrderID is {order1.OrderID}");
                        wishRechargeint=2;
                    }else{
                        Console.WriteLine("In sufficient balance to purchase");
                        Console.WriteLine("Recharge Option (yes/no): ");
                        string wishRecharge=Console.ReadLine();
                        if(wishRecharge.Equals("yes"))
                        {
                            WalletRecharge();
                        }
                        else{
                            Console.WriteLine("Exiting without Order due to insufficient balance");
                            
                            wishRechargeint=2;
                            foreach(FoodDetails foodrev in foodList)
                            {
                                foreach(CartItem cart in tempCartList)
                                {
                                    if(foodrev.FoodID.Equals(cart.FoodID))
                                    {   
                                        foodrev.AvailableQuantity+=cart.OrderQuantity;
                                    }
                                }
                            }
                        }
                        
                

                    }
                    }
                }else
                {
                    foreach(FoodDetails foodrev in foodList)
                    {
                        foreach(CartItem cart in tempCartList)
                        {
                            if(foodrev.FoodID.Equals(cart.FoodID))
                            {
                                foodrev.AvailableQuantity+=cart.OrderQuantity;
                            }
                        }
                    }
                }
            }
            //need to ask confirmation
            
            



        }//food order ends

        //modify order
        public static void ModifyOrder()
        {
            //need  to show current user order list
            Console.WriteLine("|OrderID|UserID|OrderDate            |TotalPrice|OrderStatus|");
            Console.WriteLine("--------------------------------------------------------------");
            foreach(OrderDatails order in orderList)
            {
                if(currentUser.UserID.Equals(order.UserID)&&order.Status==Status.Ordered)
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.OrderDate,-21}|{order.TotalPrcie,-10}|{order.Status,-11}|");
                }
            }
            string newOderID="0";
            Console.WriteLine();
            //need to ask orderid which one is modify
            Console.Write("Choose the order ID which is modify:  ");
            string orderID=Console.ReadLine();
            Console.WriteLine("|ItemID |OrderID|FoodID|OrderPrice|OrderQuantity|");
            Console.WriteLine("------------------------------------------------");
            bool flag1=true;
            //need show the cartitems 
            foreach(CartItem cart in itemList)
            {
                if(cart.OrderID.Equals(orderID))
                {
                    flag1=false;
                    newOderID=orderID;
                    Console.WriteLine($"|{cart.ItemID}|{cart.OrderID}|{cart.FoodID}|{cart.OrderPrice,-11}|{cart.OrderQuantity,-12}|");
                }
            }
            if(flag1)
            {
                Console.WriteLine("Enter Correct Order ID");
            }
            //need to ask cart item which one is modify
            Console.Write("Choose the cart ID which is modify: ");
            string itemID=Console.ReadLine();
            bool flag2=true;
            //check the cartid present in cartitem list
            foreach(CartItem cart in itemList)
            {
                if(cart.ItemID.ToUpper().Equals(itemID))
                {
                    flag2=false;
                    //need to ask new quantity
                    Console.Write("Enter the new Quantity: ");
                    int newQty=int.Parse(Console.ReadLine());
                    int returnqty=cart.OrderQuantity-newQty;
                    cart.OrderQuantity=newQty;
                    foreach(FoodDetails food in foodList)
                    {
                        if(cart.FoodID==food.FoodID)
                        {
                            if(0>returnqty)
                            {
                               food.AvailableQuantity+= returnqty;
                            }else{
                                food.AvailableQuantity+= returnqty;
                            }
                            
                            cart.OrderPrice=food.FoodPrice*newQty;
                        }
                    }
                    int totalPriceCalculate=0;
                    //caclulate total price
                    foreach(CartItem cart1 in itemList)
                    {
                        if(newOderID==cart1.OrderID){
                            totalPriceCalculate+=cart1.OrderPrice;
                        }
                    }
                    foreach(OrderDatails order in orderList)
                    {
                        if(newOderID==order.OrderID && order.Status==Status.Ordered)
                        {
                            order.TotalPrcie=totalPriceCalculate;
                            Console.WriteLine("Order modified successfully.");
                            
                        }
                    }
                }
                break;
            }
            if(flag2)
            {
                Console.WriteLine("Enter the correct Cart ID:  ");
            }

        }//end modify order

        //cancel order
        public static void CancelOrder()
        {
            //need to show order history
            OrderHistory();
            Console.WriteLine();
            //ask input from user for cancel order
            Console.Write("Choose the order ID which is Cancel:  ");
            string orderID=Console.ReadLine();
            bool flag=true;
            foreach(OrderDatails order in orderList)
            {
                //need to check orderid present or not
                if(orderID==order.OrderID && order.Status==Status.Ordered)
                {
                    flag=false;
                    //return the amount to the wallet of currentuser
                    currentUser.WalletBalance+=order.TotalPrcie;
                    
                    foreach(CartItem cart in itemList)
                    {
                        //retun the quantity of food to food list
                        if(order.OrderID.Equals(cart.OrderID))
                        {
                            foreach(FoodDetails food in foodList)
                            {
                                if(food.FoodID==cart.FoodID)
                                {
                                    //change the oder status ordered to cancelled
                                    food.AvailableQuantity+=cart.OrderQuantity;
                                    order.Status=Status.Cancelled;
                                }
                            }
                        }
                    }
                    
                            
                }
            }
            if(flag)
            {
                Console.WriteLine("Enter the correct OrderID.");
            }else{
                Console.WriteLine("Order Cancel Successfully");
            }
            
            

        }//end cancel order

        //order history
        public static void OrderHistory()
        {
            //need to show the order history
            Console.WriteLine("|OrderID|UserID|OrderDate            |TotalPrice|OrderStatus|");
            Console.WriteLine("------------------------------------------------------------");
            foreach(OrderDatails order in orderList)
            {
                //check the current userid with orderlist
                if(currentUser.UserID.Equals(order.UserID)&&order.Status==Status.Ordered)
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.OrderDate}|{order.TotalPrcie,-10}|{order.Status,-11}|");
                }
            }
        }//end order History

        //Wallent Recharge
        public static void WalletRecharge()
        {
            //need to ask wish to recharge
            Console.Write("Do You want to Recharge (yes/no):  ");
            string wish=Console.ReadLine();
            if(wish.Equals("yes"))
            {
                //need to ask money
                Console.Write("Enter The Amount How much you Want Recharge:  ");
                int money=int.Parse(Console.ReadLine());
                currentUser.WalletRecharge(money);
                Console.WriteLine($"{money}Rs Recharged to Your Wallet");

            }

        }//Wallet recharge Ends

        //wallet balance
        public static void WalletBalance()
        {
            //need to show balance o cureent user
            Console.WriteLine($"Your Current Wallet Balance is {currentUser.WalletBalance}");
        }//Wallet balance ends
    }

    
}
