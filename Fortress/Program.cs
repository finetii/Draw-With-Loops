using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n * 2 - 4 - 2 * (n / 2);

            Console.WriteLine("/" + new string('^', n / 2) + @"\" + new string('_', m) + "/" + new string('^', n / 2) + @"\");
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string(' ', n * 2 - 2) + "|");
            }

            Console.WriteLine("|" + new string(' ', n / 2 + 1) + new string('_', m) + new string(' ', n / 2 + 1) + "|");
            Console.WriteLine(@"\" + new string('_', n / 2) + "/" + new string(' ', m) + @"\" + new string('_', n / 2) + "/");
        }
    }
}
