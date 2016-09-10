using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= (n - i); i--)
            {
                for (int k = 0; k <= (n - i); k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (i - 1); j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();                
            }

        }
    }
}
