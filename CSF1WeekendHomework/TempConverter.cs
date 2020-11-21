using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class TempConverter
    {
        static void Main(string[] args)
        {

            bool anotherTemp = true;


            do
            {
                Console.WriteLine("Would you like a temperature in C or F?\n "+
                    "If you dont want the temperature hit N? ");
                ConsoleKey Temp = Console.ReadKey().Key;

                


                switch (Temp)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("What is the temperature outside in celsius? ");
                        double userTemp = Convert.ToDouble(Console.ReadLine());
                        double userTempF = userTemp * (9.0 / 5.0) + 32;

                        Console.WriteLine($"The temperature outside in Fahrenheit is: {userTempF:n1} ");
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("What is the temperature outside in Fahrenheit? ");
                        double userTemp1 = Convert.ToDouble(Console.ReadLine());
                        double userTempC = (userTemp1 - 32) / (9.0 / 5.0);

                        Console.WriteLine($"The temperature outside in Celsius is: {userTempC:n1} ");
                        break;
                    case ConsoleKey.N:
                        anotherTemp = false;
                        Console.WriteLine("Thank you for checking the temperature!");
                        break;

                    default:
                        Console.WriteLine(Console.ReadKey() + "is not a valid choice. " +
                            "Please choose again. ");
                        break;


                }
            } while (anotherTemp);

            
            
            
               



        }//end Main()
    }//end class
}//end namespace
