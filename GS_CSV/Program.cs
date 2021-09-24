using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GS_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string filename in args)
            {
                using var reader = new StreamReader(filename);
                reader.ReadLine();
            }
            var prices = new[] { 12, 43.5, 32, 9, 3.0 };
            var sum = 0d;
            for (int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];
            }
            var average = sum / prices.Length;
            Console.WriteLine("The prices are 12, 43.5, 32, 9, and 3.0\n");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            using var writer = new StreamWriter("results.csv");
            Console.ReadKey();
        }
    }
}
