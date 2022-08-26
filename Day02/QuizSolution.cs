using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class QuizSolution
    {
        public static int[] RandomPosition(int[] n)
        {
            int[] array = n ;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0,n.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        public static int[] ShiftArray(int[] n)
        {
            // local variable untuk return
            int[] array = n;
            var temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = temp;

            return array;
        }
    }
}
