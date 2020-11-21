using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a verb? ");
            string verb = Console.ReadLine();
            Console.WriteLine("Please give me another verb? ");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Please give me a verb? ");
            string verb2 = Console.ReadLine();
            Console.WriteLine("Please give me a adjective? ");
            string adjective = Console.ReadLine();
            Console.WriteLine("Please give me another adjective? ");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Please give me another adjective? ");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Please give me another adjective? ");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("Please give me a noun? ");
            string noun = Console.ReadLine();
            Console.WriteLine("Please give me another noun? ");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Please give me another noun? ");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Please give me adverb? ");
            string adverb = Console.ReadLine();
            Console.WriteLine("Please give me another adverb? ");
            string adverb1 = Console.ReadLine();


            Console.WriteLine($"Today I went to the zoo. I saw a(n) {adjective}\n" +
                $"{noun} jumping up and down in its tree.\n" +
                $" He {verb} {adverb} through the large tunnel that led to its {adjective1}\n" +
                $" {noun1}. I got some peanuts and passed them through the cage to a gigantic\n" +
                $" gray {noun2} towering above my head. Feading that animal made me hungry.\n" +
                $" I went to get a {adjective2} scoop of ice cream. It filled my stomach.\n" +
                $" Afterwards I had to {verb1} {adverb1} to catch our bus.\n" +
                $" When I got home I {verb2} my mom for a {adjective3} day at the zoo.");
            
        }
    }
}
