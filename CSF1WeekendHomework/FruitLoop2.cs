using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop");


            string[] fruit = { "apple", "orange", "banana", "grapes", "blueberries", "raspberries" };
            
            string fruitByIndex = "";

            for (int fruitA = 0; fruitA <= 5; fruitA++)
            {
                Console.WriteLine(fruit[fruitA]);
                if (fruitA != 0)
                {
                    fruitByIndex += ".";
                }
                Console.WriteLine(fruitByIndex);
               
            }//end for
        }
    }
}
