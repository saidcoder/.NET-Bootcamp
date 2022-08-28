using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class QuizLogic04
    {
        public static void no1()
        {
            var input1 = new List<int> { 1, 2, 5, 6, 9 };
            var input2 = new List<int> { 1, 2, 3, 4};
            Console.WriteLine("========NO 1===========");
            Console.Write("Input A : ");
            input1.ForEach(Console.Write);
            Console.WriteLine();
            Console.Write("Input B : ");
            input2.ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine("===================");

            var irisanAB = input1.Intersect(input2);
            Console.Write("Tampilkan element yang sama (A irisan B) : ");
            foreach (var item in irisanAB)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

         
            var unionAB = input2.Union(input1); 
            Console.Write("Merge dan tampilkan element (A union B) : ");
            foreach (var item in unionAB)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            var AtidakSamaB = input1.Except(input2);
            Console.Write("Tampilkan element di A yang tidak sama dengan B : ");
            foreach (var item in AtidakSamaB)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            var r = new HashSet<int>(input2);
            r.SymmetricExceptWith(input1);
            var tidakSamaAB = r.ToList();
            Console.Write("Tampilkan element yang tidak sama di A & B : ");
            foreach (var item in tidakSamaAB)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
        }

        public static void no2()
        {

        }
    }
}
