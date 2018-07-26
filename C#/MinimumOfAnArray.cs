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
            int[] array = new int[arrsize];
            Random rnd = new Random();

            ///Filling array///
            Console.Write("Array ={ ");
            for (int i = 0; i < arrsize; i++)
            {
                array[i] = rnd.Next(-100, 100);
                if((i+1) == arrsize)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
            Console.WriteLine("}");

            ///Looking for minimum///
            int min = array[0];
            for(int i = 0; i < arrsize; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The minimum value of your array: " + min);
        }
    }
}
