﻿using System;
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
            Console.WriteLine("Give number you are looking for: ");
            int num = Int32.Parse(Console.ReadLine());

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

            ///Looking for chosen value///
            int pos = -1;
            for(int i = 0; i < arrsize; i++)
            {
                if(array[i] == num)
                {
                    pos = i;
                    break;
                }
            }
            if(pos > -1)
            {
                Console.WriteLine("The number you are looking for lies in " + pos + " position.");
            }
            else
            {
                Console.WriteLine("The number you are looking for doesn't exist in this array.");
            }
            
        }
    }
}
