using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            if (n % 2 == 0)
                count += 1;
            for (int i=0; i<(n+1)/2; i++)
            {
                int newcount = (n-count)/2;
                Console.WriteLine(new string('-', newcount) + new string('*', count) + new string ('-', newcount));
                count += 2;
            }
            for (int i=0; i< (n/2); i++)
            {
                Console.WriteLine(new string('|', 1) + new string('*', (n / 2)+1) + new string('|', 1));
            }
        }
    }
}
