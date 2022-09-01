using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinalTest
{
    internal class Test
    {
        // Soal No 1
        public static void KatakLompat()
        {
            int posisiX = 10;
            int posisiY = 85;
            int jarakTempuh = 30;
            int xK = posisiX + jarakTempuh;
            int jumlahLompatan = 1;

            while (xK <= posisiY)
            {
                jumlahLompatan++;
                xK += jarakTempuh;
            }
            Console.WriteLine($"Jumlah Lompatan : {jumlahLompatan}");
        }

        //Soal No 2
        public static int CountFactorial()
        {
            int n = 8;
            int factorial = n;

            for (int i = n - 1; i > 0; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        //Soal No 3
        public static int SumNumber()
        {
            int n = 8;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        //Soal No 4
        public static int Fibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int fibonacci = 0;
            int number = 8;
            for (int i = 1; i < number; i++)
            {
                fibonacci = n1 + n2;
                n1 = n2;
                n2 = fibonacci;

            }
            return fibonacci;
        }

        //Soal No 5
        public static void AllFibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int fibonacci = 0;
            int number = 7;
            Console.Write($"Fibonacci 7 = {n2} ");
            for (int i = 1; i < number; ++i)   
            {
                fibonacci = n1 + n2;
                Console.Write($"{fibonacci} ");
                n1 = n2;
                n2 = fibonacci;
            }
        }

        //Soal No 6
        public static bool CheckKurawal()
        {
            var input = "{{}";
            char kurawalBuka = '{';
            char kurawalTutup = '}';
            char cek;
            int countB = 0;
            int countT = 0;
            for (int i = 0; i < input.Length; i++)
			{
                cek = input[i];
                if (cek == kurawalBuka)
                {
                    countB++;
                } if (cek == kurawalTutup)
                {
                    countT++;
                }
            }
            if (countB == countT)
            {
                return true;
            }
            return false;
        }

        //No 7
        public static bool IsAnagram()
        {
            string kata1 = "Hello";
            string kata2 = "Heoll";
            int count = 0;
            char[] kalimat1 = kata1.ToLower().ToCharArray();
            char[] kalimat2 = kata2.ToLower().ToCharArray();

            if (kalimat1.Length == kalimat2.Length)
            {
                for (int i = 0; i < kalimat1.Length; i++)
                {
                    if (kalimat2[i] == 'h' || kalimat2[i] == 'e' || kalimat2[i] == 'l' || kalimat2[i] == 'o')
                    {
                        count++;
                    }
                }
                if (count == kalimat1.Length)
                {
                    return true;
                }

            }
            return false;
        }

        //No 8
        public static int[,] Matrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = -1;
            int x = 2;
            int y = 5;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal baris == colom
                    if (i == j)
                    {
                        matrix[i, j] = counter+=2;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (j == 0)
                    {
                        matrix[i, j] = x++;
                    }
                    else if (i == matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = x++;
                    }
                    else if (i == matrix.GetLength(1) - 2 && j == 1 || j == 2)
                    {
                        matrix[i, j] = y++;
                    }
                    else if (i == 2 && j == 1)
                    {
                        matrix[i, j] = 4;
                    }
                }
            }
            return matrix;
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

    }
}
