using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention_Struct
{
    internal static class Person
    {
        public static string Name { get; set; }

        public static void Test()
        {
            Console.WriteLine("Test method");
        }


       
        static Person()
        {
            Console.WriteLine("Static person");
        }


        




        //public static Person()

        //{
        //    Console.WriteLine("Non static");
        //}

    }
}
