using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i=0; i<(n-2); i++)          
                Console.Write(" -");
            Console.WriteLine(" +");
            for (int p=0; p<(n-2); p++)
            {
                Console.Write("|");
                for (int row = 0; row < (n - 2); row++)
                    Console.Write(" -");                
                Console.WriteLine(" |");
            }
            
            Console.Write("+");
            for (int col = 0; col < (n - 2); col++)
                Console.Write(" -");
            Console.WriteLine(" +");
                
        }
    }
}
static void Main(string[] args)
{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1)
            {
                if (i == 0 || i == n - 1)
                    Console.Write("+ ");
                else
                    Console.Write("| ");
            }
            else
            {
                Console.Write("- ");
            }
        }
        Console.WriteLine();
    }
}