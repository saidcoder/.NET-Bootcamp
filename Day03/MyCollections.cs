using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class MyCollections
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($"{item} ");
            }

            //remove element  for list
            alfabet.Remove("Y");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "X");

            //declare list int
            var number = new List<int> { 2, 5, 7, 11, 13, 17, 19 };
            number.Add(23);
            /*number.Remove(13);
            number.RemoveAll(v => v == 7);*/

            //find element
            var a = number.Find(e => e < 10);
            var b = number.FindLast(e => e < 11);
            var c = number.FindAll(e => e <= 10);
            Console.WriteLine();

            //find element
            var d = number.FindIndex(e => e <= 11);
            var e = number.FindLastIndex(e => e <= 11);
            var f = number.IndexOf(13);
            var g = number.BinarySearch(11);
            Console.WriteLine();
        }

        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(5);
            numbers.Push(7);

            //remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "C#" },
                {2, "Java" },
                {3, "Python" }
            };

            //add element
            pl2.Add(4, "Golang");
            pl2.TryAdd(4, "SQl");

            //update element value
            pl2[4] = "SQL";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();
        }

        //store Uniqe Element
        public static void InitHastSet()
        {
            var numbers = new HashSet<int>() { 1, 2, 3, 5, 8 };
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(hs1);
            r1.IntersectWith(hs2); //inner join,  result = 1, 2

            var r2 = new HashSet<int>(hs1);
            r2.UnionWith(hs2); // union => 1,2,3,4,5,6,9

            var r3 = new HashSet<int>(hs1);
            r3.ExceptWith(hs2); // output 5,6,9

            var r4 = new HashSet<int>(hs1);
            r4.SymmetricExceptWith(hs2); //output 3,4,5,6,9

            //Convert hashset to list
            var myNumber = r4.ToList();

            Console.WriteLine();
        }

        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Asep");
            queue.Enqueue("Budi");
            queue.Enqueue("Charlie");

            Console.WriteLine($" Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");
        }

        //return List<T>
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }
    }
}
