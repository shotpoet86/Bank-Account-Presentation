//Programmer: Austin Parker
//Date: June 2, 2020
//Assignment: Chapter 11/ PE 7/ Banking Account
//Purpose: Display customers banking information

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Presentation

    {
        static void Main(string[] args)
        {
            int bank, interestEarned;
            WriteLine("Functionality of checking class: ");

            Checking check = new Checking(0055598765, "Young Jeezy");
            check.Credit(1000);
            check.beginDisplay();
            bank = check.Overdraft();
            WriteLine("Overdraft protection for statement cycle: $ " + bank);
            check.endDisplay();
            WriteLine();
            WriteLine("Functionality of savings class: ");

            Saving save = new Saving(0055556789, "Ying Yang Twins");
            save.Credit(50000);
            save.beginDisplay();
            interestEarned = save.Interest_rate();
            WriteLine("Interest for statement cycle: $ " + interestEarned);
            save.endDisplay();
            ReadLine();
            //Main ends here
        }

    }

    abstract class Bank_Account
    {
        //base class variables
        public int money;
        public long account_no;
        public string account_holder;

        //base class function
        public void beginDisplay()
        {
            WriteLine("Beginning balance was: $ " + money);
        }
        public void endDisplay()
        {
            WriteLine("Statement ending balance is: $ " + money);
        }
        public void Credit(int value)
        {
            money += value;

        }

        public void Debit(int value)
        {
            money += value;
        }
        //end of base class
    }
}

