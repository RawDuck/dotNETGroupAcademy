using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Preparing variables///
            Console.WriteLine("Give any number: ");
            int num = Int32.Parse(Console.ReadLine());
            
            if(num < 0)
            {
                num = -num;
            }

            Console.WriteLine("Absolute value of your number: " + num);
        }
    }
}
