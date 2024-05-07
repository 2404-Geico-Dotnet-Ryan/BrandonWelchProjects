using System;

class Program
{//---Start of Class Program---
    static void Main(string[] args)
    {//---Start of Main Method---

        //double deposit;
        //double withdrawl;
        //double balance = deposit - withdrawl;

        Login();
        Menu();
        Deposit();
        Withdrawl();

        //how to make the deposits/withdrawls accept multiple? array? list?

    }//---End of Main Method---

   
   
      public static void Withdrawl()
   {
        Console.WriteLine("Please enter the amount of your withdrawl: (Format 000.00)");
        Console.Write("Amount: ");
        double withdrawl = double.Parse(Console.ReadLine());

        //wrap this is some sort of whie loop for mutliple deposits?
        //how to add validation for double? i.e. to ensure includes decimal place.
        if (withdrawl != 0)
        {
            double total = 0;
            
            total += withdrawl;
            Console.WriteLine("You withdrawl of $" + withdrawl + " was successful.");
        }
        else
        {
            Console.WriteLine("Please enter a valid withdrawl amount. (Valid format 000.00)");
            //loop back to enter valid value or put a readline here?
        }
   }
   public static void Deposit()
   {
        Console.WriteLine("Please enter the amount of your deposit: (Format 000.00)");
        Console.Write("Amount: ");
        double deposit = double.Parse(Console.ReadLine());

        //wrap this is some sort of whie loop for mutliple deposits?
        //how to add validation for double? i.e. to ensure includes decimal place.
        if (deposit != 0)
        {
            double total = 0;
            
            total += deposit;
            Console.WriteLine("You deposit of $" + deposit + " was successful.");
        }
        else
        {
            Console.WriteLine("Please enter a valid deposit amount. (Valid format 000.00)");
            //loop back to enter valid value or put a readline here?
        }
   }
    public static void Menu()
    {
        Console.WriteLine("\nWhat can I help you with?\n"); //add firstName lookup after loggin functions
        Console.WriteLine("\t1) Make a deposit");
        Console.WriteLine("\t2) Make a withdrawl");
        Console.WriteLine("\t3) See account balance");
        Console.WriteLine("\t4)  --PENDING--");

    }
    public static void Login()
    {
        //need to create a login function
        Console.WriteLine("Welcome to .Net Bookcamp Banking!\nPlease enter your username and password to sign in.\n");

        Console.Write("Username: ");
        string userName = Console.ReadLine();
        Console.Write("Passowrd: ");
        string password = Console.ReadLine();

        //need to determine validation both on input fields then how to look up users for role based access (user/mgr/admin)
    }
}//---End of Class Program---