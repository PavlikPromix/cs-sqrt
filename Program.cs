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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter n: ");
                Console.SetCursorPosition(9, 0);
                int n = int.Parse(Console.ReadLine());
                double max = n;
                double min = 0;
                double mid = (max + min) / 2;
                int step = 0;
                while (true)
                {
                    step++;
                    mid = (max + min) / 2;
                    if (mid * mid > n)
                    {
                        max = mid;
                        mid = (max + min) / 2;
                    }
                    else if (mid * mid < n)
                    {
                        min = mid;
                        mid = (max + min) / 2;
                    }
                    if (mid * mid == n)
                    {
                        mid = Math.Round(mid, 2);
                        Console.WriteLine($"Sqrt of {n} is {mid}");
                        break;
                    }
                    if (step > 75)
                    {
                        mid = Math.Round(mid, 2);
                        Console.WriteLine($"Sqrt of {n} is closely equal {mid}");
                        break;
                    }
                    //Console.WriteLine($"{min}, {mid}, {max}");

                }
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
