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
            var input2 = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("========NO 1===========");
            Console.Write("Input A : ");
            input1.ForEach(Console.Write);
            Console.WriteLine();
            Console.Write("Input B : ");
            input2.ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine("======================");

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


        //No 2
        public static List<T> ReverseList<T>(ref List<T> list)
        {
            var input = new List<T>();

            Console.WriteLine("Input : ");
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Return : ");

            foreach (var item in list)
            {
                input.Add(item);
            }

            List<T> revers = Enumerable.Reverse(input).ToList();
            return revers;
        }

        //No 3
        public static List<T> RemoveDuplicate<T>(ref List<T> list)
        {
            var input = new List<T>();
            Console.WriteLine("Input : ");
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Return : ");

            return list.Distinct().ToList();
        }

        //No 4
        public static void FindLongestSequence()
        {
            /*var input = new List<T>();
            int count = 1;
            int longestCount = 1;

            for (int i = 0; i < list.Count; i++)
            {
               
                Console.Write(list[i]);
            }*/
            var list = new List<int> { 7, 2, 7, 1, 2, 5, 7, 1 };

            /*int longestSequenceLength = 0;
            int startIndexOfLongestSequence = 0;
            int currentSequenceLength = 0;
            int currentStartSequenceIndex = 0;*/
            int n = 1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == list.Count - 1)
                {
                    n = 0;
                }
                if (list[i] == list[i + n] - 1)
                {
                    Console.Write(list[i] + " ");
                    Console.Write(list[i+1] + " ");
                }
                /*else if (list[i] == list.Count-1)
                {
                    Console.Write(list[i]+" ");
                }*/

            }

        }


        public static List<T> DisplayList<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            return myList;
        }

    }
}
