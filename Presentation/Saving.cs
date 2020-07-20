//Programmer: Austin Parker
//Date: June 2, 2020
//Assignment: Chapter 11/ PE 7/ Banking Account
//Purpose: Display customers banking information

using static System.Console;

namespace Presentation
{
    class Saving : Bank_Account
    {
        //start of savings class
        public Saving(long account, string name)
        {
            account_no = account;
            account_holder = name;
            WriteLine("  Customer Name: " + name);
            WriteLine("  Account # " + account);

        }

        public int Interest_rate()
        {
            int interest = 0;
            if (money >= 20000)
            {
                interest = (money * 5) / 100;
                money += interest;
            }
            return interest;
        }
        //end of savings class
    }
}

