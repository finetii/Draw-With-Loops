using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
                stars += 1;
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                int count = (n - stars) / 2;
                Console.WriteLine(new string('-', count) + new string('*', stars) + new string('-', count));
                stars += 2;
            }                       
            for (int i = 0; i <(n/2); i++)
            {
                Console.WriteLine('|' + new string ('*', n-2) + '|');
            }
            Console.ReadKey();               
        }
    }
}
