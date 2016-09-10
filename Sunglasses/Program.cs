using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           

            for (int i = 1; i<=n; i++)
            {
                if (i==1 || i==n)
                {
                    for (int j = 0; j < (2 * n); j++)
                        Console.Write("*");
                    for (int k = 0; k < n; k++)
                        Console.Write(" ");
                    for (int j = 0; j < (2 * n); j++)
                        Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    for (int m = 0; m < ((2*n)-2) ; m++)
                        Console.Write("/");
                    Console.Write("*");
                    if (i==(n-1)/2)
                        {
                        for (int k = 0; k < n; k++)
                            Console.Write("|");
                        }
                    else
                    {
                        for(int k = 0; k < n; k++)
                            Console.Write(" ");
                    }
                   
                    Console.Write("*");
                    for (int m = 0; m < ((2*n)-2); m++)
                        Console.Write("/");
                    Console.Write("*");
                }               
                Console.WriteLine();
            }
        }
    }
}
