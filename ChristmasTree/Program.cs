using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int k=0; k<=(n-i); k++)
                {
                    Console.Write(" ");
                }               
                for (int j = 0; j<i; j++)
                {
                    Console.Write("*");
                }                           
                Console.Write(" | ");

             for (int k=n; k<=1; k++)
                {
                    Console.Write(" ");
                }
             for (int j = 0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
        }
    }
}

