using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Preparing array and variables///
            Console.WriteLine("Give size of an array: ");
            int arrsize = Int32.Parse(Console.ReadLine());

            int[] array = new int[arrsize];
            Random rnd = new Random();
            int result = 0;

            ///Filling array with random numbers///
            for(int i=0; i<arrsize; i++)
            {
                array[i] = rnd.Next(1,100);
                Console.WriteLine("el " + i + " = " + array[i]);
            }

            ///Summing array///
            for(int i=0; i<arrsize; i++)
            {
                result += array[i];
            }

            Console.WriteLine("Sum of your array: " + result);
        }
    }
}
