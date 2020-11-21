using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = "jvalbur";
            string username2 = "JVALBUR";

            username2 = username;

            string password = "cheese";
            string password2 = "CHEESE";

            password2 = password;
            
            bool noUsernameAccess = true;
            bool noPasswordAccess = true;

            do
            {
                Console.WriteLine("What is your username: ");
                string inputUsername = Console.ReadLine();
                int attempt = 0;
                
                if (inputUsername == username)
                {
                    noUsernameAccess = false;
                }
                else if (inputUsername != username)
                {
                    attempt ++;
                    Console.WriteLine(attempt);
                }
                
            } while (noUsernameAccess);

            do
            {
                Console.WriteLine("What is you password? ");
                string inputPassword = Console.ReadLine();



                if (inputPassword == password)
                {
                    Console.WriteLine("You have gained access to your account!");
                    noPasswordAccess = false;
                }
            } while (noPasswordAccess);


            

        }
    }
}
