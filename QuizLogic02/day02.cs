using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizLogic02
{
    internal class day02
    {
        //01
        public static int[] RandomArray(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }
            Console.WriteLine($"Before Random");
            return arr;
        }
        public static int[] RandomIndex(int[] arr)
        {
            Random rand = new Random();
            //int[] arrRandom = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = rand.Next(0, arr.Length);
                arr[i] = arr[j];
                arr[j] = temp;

            }
            Console.WriteLine($"After Random");

            return arr;
        }

        //no.2
        public static int[] SwitchArray(int[] arr)
        {
            int[] arrRotate = new int[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arrRotate[i] = arr[i + 1];
            }
            arrRotate[arr.Length - 1] = arr[0];
            return arrRotate;
        }

        //no.3
        public static int[] RotateArray(int[] arr)
        {
            int[] arrRotate = new int[arr.Length];
            Console.WriteLine($"Before Rotate :");
            DisplayArray(arr);

            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotate ke {j} :");
                int last = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arrRotate[i] = arr[i + 1];

                }
                arrRotate[arr.Length - 1] = last;
                DisplayArray(arrRotate);
                arr = arrRotate;
            }
            return arrRotate;
        }

        //no.4
        public static int[] RotateRightArray(int[] arr)
        {
            int[] arrRotate = new int[arr.Length];
            Console.WriteLine($"Before Rotate :");
            DisplayArray(arr);

            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotate ke {j} :");
                int last = arr[arr.Length - 1];
                for (int i = arr.Length - 1 ; i > 0;  i--)
                {
                    arrRotate[i] = arr[i - 1];

                }
                arrRotate[0] = last;
                DisplayArray(arrRotate);
                arr = arrRotate;
            }
            return arrRotate;
        }

        //no 7
        public static int[] DuplicateArray()
        {
            var arr = new[] { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
            Console.WriteLine("Before Remove");
            DisplayArray(arr);
            Console.WriteLine();
            var uniqueArray = arr.Distinct().ToArray();
            Console.WriteLine("After Remove");
            Array.Sort(uniqueArray);
            return uniqueArray;
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
