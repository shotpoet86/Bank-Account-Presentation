//Programmer: Austin Parker
//Date: June 2, 2020
//Assignment: Chapter 11/ PE 7/ Banking Account
//Purpose: Display customers banking information

using static System.Console;

namespace Presentation
{
    class Checking : Bank_Account
    {
        //checking class begins
        public Checking(long account, string name)
        {
            account_no = account;
            account_holder = name;
            WriteLine("  Customer Name: " + name);
            WriteLine("  Account # " + account);

        }

        public int Overdraft()
        {
            int checkOverdraft = 0;
            if (money <= 1000)
            {
                checkOverdraft = money / 2;
                money += checkOverdraft;
            }
            return checkOverdraft;
        }
        //end of checking class
    }
}

