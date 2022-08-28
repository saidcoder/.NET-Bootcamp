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
            var temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arrRotate[i] = arr[i + 1];
            }
            arrRotate[arr.Length - 1] = temp;
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
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arrRotate[i] = arr[i - 1];

                }
                arrRotate[0] = last;
                DisplayArray(arrRotate);
                arr = arrRotate;
            }
            return arrRotate;
        }

        //No 5
        public static int[] CountDuplicateArray()
        {
            int[] array = { 5, 2, 30, 12, 10, 5, 2, 10, 5 };
            Array.Sort(array);
            int count;

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = 0; j <= array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (i < array.Length - 1 && array[i] != array[i + 1])
                {
                    Console.WriteLine($"{array[i]} muncul sebanyak {count}");
                }
                else if (i == array.Length - 1)
                {
                    Console.WriteLine($"{array[i]} muncul sebanyak {count}");
                }

            }
            return array;
        }


        //No 6
        public static void ArrayMaker()
        {
            Console.WriteLine("Before Marker");
            int[] array = { 1, 5, 3, 7, 8, 5, 1 };
            DisplayArray(array);
            Console.WriteLine();
            Console.WriteLine("After Marker");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                int x = array[i];
                if (i < array.Length - 1 && x == array[i + 1])
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        if (j == array.Length - 1)
                        {
                            array[j] = -1;
                        }
                        else
                        {
                            array[j] = array[j + 1];
                        }
                    }
                }
            }
            DisplayArray(array);
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

        //No 8
        public static void CountChar()
        {
            Console.WriteLine("=======================");
            var alpa = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            char[] array = new char[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = alpa[rand.Next(0, 26)];
            }
            int count;
            foreach (var item in array)
            {
                Console.Write($"{ item } ");
            }
            Console.WriteLine();
            Console.WriteLine("========Result========");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = 0; j <= array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (i < array.Length - 1 && array[i] != array[i + 1])
                {
                    Console.Write($"{count}{array[i]} ");
                }
                else if (i == array.Length - 1)
                {
                    Console.Write($"{count}{array[i]} ");
                }

            }

        }

        //no 9
        public static int[,] MatrixDiagonalReverse(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = baris;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal baris == colom
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        //no 10
        public static int[,] MatrixDiagonalSum(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = baris;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal baris == colom
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                        sum += matrix[i, j];
                    }
                }
            }
            //DisplayMatrix(matrix);
            Console.WriteLine($"Total Sum Diagonal Value : {sum}");
            return matrix;
        }

        //no 11
        public static int[,] MatrixSquare(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int n = baris - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            matrix[i, j] = 0;
                        }

                    }

                }
            }
            return matrix;
        }

        //12
        public static int[,] MatrixSumSquare(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int n = baris - 1;
            int sum = 0;
            int sum2 = 0;
            //int loop = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i != n && j != n)
                    {
                        matrix[i, j] = i + j;
                        if (j <= n)
                        {
                            sum += matrix[i, j];
                            matrix[i, n] = sum;
                            matrix[n, i] = sum;

                            if (i == j)
                            {
                                sum2 += matrix[i, j];
                                matrix[n, n] = sum2;
                            }

                            if (j == n - 1)
                            {
                                sum = 0;
                            }
                        }
                    }
                }
            }
            return matrix;
        }

        //No 15
        public static int StudentQuiz(char[,] soaljawaban, char[] kunci)
        {
            char[,] jawaban = soaljawaban;
            char[] kunciJawaban = kunci;
            int count = 0;

            for (int i = 0; i < jawaban.GetLength(0); i++)
            {
                count = 0;
                Console.Write($"Jawaban Siswa {i} yang benar : ");
                for (int j = 0; j < jawaban.GetLength(1); j++)
                {
                    //Console.Write($"{jawaban[i,j]}");
                    if (jawaban[i, j] == kunciJawaban[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(count);
            }

            return count;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //looping colom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
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
