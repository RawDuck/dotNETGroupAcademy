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
            Console.WriteLine("Give size of an array: ");
            int arrsize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give the value you are looking for: ");
            int val = Int32.Parse(Console.ReadLine());
            int[] array = new int[arrsize];
            Random rnd = new Random();
            int result = 0;

            ///Filling array///
            for(int i = 0; i < arrsize; i++)
            {
                array[i] = rnd.Next(0, 10);
            }

            for(int i = 0; i < arrsize; i++)
            {
                if(array[i] == val)
                {
                    result += 1;
                }
            }

            Console.WriteLine("The value you are looking for occurs " + result + " times" );
        }
    }
}
