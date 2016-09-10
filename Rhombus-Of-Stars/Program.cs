using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i<= n; i++)
            {
                for (int k = 1; k <= (n - i); k++)
                {
                    Console.Write(" ");
                }                  
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");                   
                }
                Console.WriteLine();
            }
            for (int i = n; i>=1 ; i--)
            {
                for (int k = 0; k <= (n - i); k++)
                {
                    Console.Write(" ");
                }
                    
                for (int j=0; j < (i-1); j++)
                {
                    Console.Write("* ");                    
                }
                    
                Console.WriteLine();              
            }
            
        }
    }
}
