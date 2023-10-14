using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Given an array of integers and a positive integer k, determine the number of (i, j) pairs where i < j and ar[i] + ar[j] is divisible by k.
    */
    internal class DivisibleSumPairs
    {
        /// <summary>
        /// Calculate pairs of numbers where (i < j) and ar[i] + ar[j] divisible by k
        /// </summary>
        /// <param name="n">Lenght of array</param>
        /// <param name="k">Divisor</param>
        /// <param name="ar">Array on int numbers</param>
        /// <returns>Number of pairs from description</returns>
        public static int StartTask(int n, int k, List<int> ar)
        {
            int result = 0;

            // Проходим по массиву
            for (int i = 0; i < n; i++)
            {
                int firstNumber = ar[i];
                // Проходим по массиву второй раз, начиная со следуюущего после текущего числа
                for (int j = i + 1; j < n; j++)
                {
                    int secondNumber = ar[j];
                    // Проверяем условие задачи и увеличиваем счётчик
                    if ((firstNumber + secondNumber) % k == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
