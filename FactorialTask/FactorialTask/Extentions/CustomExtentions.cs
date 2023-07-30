using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTask.Extentions
{
    internal static class CustomExtentions
    {
        public static int Factorial(this int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;

        }


        public static void NumFactorial(this int num)
        {
            int result = 1;
            if (num==0 || num<0)
            {
                Console.WriteLine("Don`t convert");
            }
            else
            {
                for (int i = 1; i <=num; i++)
                {
                    result *= i;
                }
                Console.WriteLine(result);
            }
            

        }




   
        }









    }
}
