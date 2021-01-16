using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareRoot rt = new SquareRoot();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter n: ");
                Console.SetCursorPosition(9, 0);
                int n = int.Parse(Console.ReadLine());
                double res = rt.solver(n);
                if (res % 1 == 0)
                {
                    Console.WriteLine($"Sqrt of {n} is {res}");
                }
                else
                {
                    Console.WriteLine($"Sqrt of {n} is closely equal {res}");
                }
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
