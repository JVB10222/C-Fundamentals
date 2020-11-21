using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class FibonacciSeq
    {
        public static void fibonacciSeq(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1}", a, b);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine(" {0}", c);
                a = b;
                b = c;

                /*
             * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
             * f1, f2,f3, f4, f5, f6, f7, f8,f9,f10,f11,f12, f13, f14
             * 
             * fn = f(n-2) +f(n-1) 
             */
                /*
                 * 
                 * public static int GetNthFibonacci_Ite(int n)  
   {  
       int number = n - 1; //Need to decrement by 1 since we are starting from 0  
       int[] Fib = new int[number + 1];  
       Fib[0]= 0;  
       Fib[1]= 1;  
       for (int i = 2; i <= number;i++)  
       {  
          Fib[i] = Fib[i - 2] + Fib[i - 1];  
       }  
       return Fib[number];  
   }  


            public static int GetNthFibonacci_Rec(int n)  
{  
    if ((n == 0) || (n == 1))  
    {  
        return n;  
    }  
    else  
        returnGetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);  
}  
                 */
            }

        }
        static void Main(string[] args)
        {
            fibonacciSeq(20);




        }
    }
}
