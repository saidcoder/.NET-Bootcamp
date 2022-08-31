using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] numbers = new int[] { 89, 44, 864, 356, 356, 86, 44, 3 };

            //sum from 89 to 3
            var sum = numbers.Sum(x => x++);
            Console.WriteLine($"SUM : {sum}");

            var min = numbers.Min();
            Console.WriteLine($"Min : {min}");

            var max = numbers.Max();
            Console.WriteLine($"MAx : {max}");

            Console.WriteLine();

            var duplicate = numbers.Distinct();
            foreach (var item in duplicate)
            {
                Console.WriteLine(item);
            }

        }

    }
}
