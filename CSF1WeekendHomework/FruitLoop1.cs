using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop");


            string[] fruit = { "apple", "orange", "banana", "grapes", "blueberries", "raspberries"};

            for (int fruitA = 0; fruitA <= 5; fruitA++)
            {
                Console.WriteLine( fruit[fruitA]);
            }//end for

            int multipler = 10;
            string TenAs = new string('A', multipler);
        }
    }
}
