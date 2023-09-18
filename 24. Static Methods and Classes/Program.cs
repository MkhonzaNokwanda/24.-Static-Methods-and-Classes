using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            SayHi salute=new SayHi();
            salute.sayHello("Nono","Mudau");

            //freeze
            Console.ReadLine();
        }
    }
}
