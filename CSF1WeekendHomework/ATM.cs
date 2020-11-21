using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "Bank of Jose";

            int account = 456123;
            int pin = 741852;
            decimal accountBalance = 0;

            bool noUsernameAccess = true;
            bool noPasswordAccess = true;
            bool accountMenu = true;

            do
            {
                Console.WriteLine("What is your account #: ");
                int inputAccount = Convert.ToInt32(Console.ReadLine());
                
                if (inputAccount == account)
                {
                    noUsernameAccess = false;
                }
               
            } while (noUsernameAccess);

            do
            {
                Console.WriteLine("What is your pin? ");
                int inputPin = Convert.ToInt32(Console.ReadLine());

                
                if (inputPin == pin)
                {
                    Console.WriteLine("You have gained access to your account!");
                    noPasswordAccess = false;
                }
            } while (noPasswordAccess);
            

            Console.WriteLine($"You have {accountBalance:c} in your account.");
            
            do
            {
                
                Console.WriteLine("Would you like to W)ithdraw, D)eposit, V)iew current balance or E)xit" +
                    " your account? ");
                ConsoleKey userChoice = Console.ReadKey().Key;
                
                switch(userChoice)
                {
                    //if the user pushes the d on the keyboard, it makes the 
                    case ConsoleKey.D:
                        Console.WriteLine($"How much would you like to Deposit to account # {account}?");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        accountBalance = accountBalance + deposit;
                        Console.Clear();
                        Console.WriteLine($"You deposited {deposit:c} into your account.");
                        break;

                    case ConsoleKey.W:
                        Console.WriteLine($"How much would you like to Withdraw from account # {account}? ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        accountBalance = accountBalance - withdraw;
                        Console.Clear();
                        Console.WriteLine($"You withdrew {withdraw:c} from your account.");
                        break;

                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine($"You have a balance of {accountBalance:c} in account # {account}.");
                        break;
                        
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine("Thank you for your business!");
                        accountMenu = false;
                        break;
                    default:
                        break;

                }


            } while (accountMenu);




        }

    }
 }

