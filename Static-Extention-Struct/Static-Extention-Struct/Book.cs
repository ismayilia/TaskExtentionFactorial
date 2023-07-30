using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention_Struct
{
    internal class Book
    {
        public string Name { get; set; }
        public int  age { get; set; }


        public void test(string a)
        {
            this.Name= a;
            Console.WriteLine(this.Name);
        }




    }
}  
