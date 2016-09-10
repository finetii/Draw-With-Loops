using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftright = 0;
            int mid = 0;

            leftright = (n - 1) / 2;
            
            for (int i = 1; i <= (n-1) / 2; i++)
            {
                mid = n - 2 * leftright - 2;
                if (mid >= 0)
                    Console.Write(new string('-', leftright) + "*" + new string('-', mid) + "*" + new string('-', leftright));
                else
                    Console.Write(new string('-', leftright) + "*" + new string('-', leftright));
                leftright -= 1;
                Console.WriteLine();
            }

            for (int k = n ; k > n/2; k--)
            {
                mid = n - 2 * leftright - 2;
                if (mid >= 0)
                    Console.Write(new string('-', leftright) + "*" + new string('-', mid) + "*" + new string('-', leftright));
                else
                    Console.Write(new string('-', leftright) + "*" + new string('-', leftright));
                leftright += 1;
                Console.WriteLine();
            }     

        }
    }
}
