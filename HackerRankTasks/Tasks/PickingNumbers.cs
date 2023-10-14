using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Given an array of integers, find the longest subarray where the absolute difference between any two elements is less than or equal to 1.
     */
    internal class PickingNumbers
    {
        /// <summary>
        /// Calculate subarrays with difference between elements less or equal to 1
        /// </summary>
        /// <param name="a">Initial list on int numbers</param>
        /// <returns>Lenght of longest subarray that meets the criterion (always >= 2)</returns>
        public static int SolveProblem(List<int> a)
        {
            int maxLenght = 0;
            var numCountDict = new Dictionary<int, int>();

            // За первый проход посчитаем сколько раз каждое число повторяется в списке
            for (int i = 0; i < a.Count; i++)
            {
                int currentNumber = a[i];
                if (numCountDict.ContainsKey(currentNumber))
                {
                    numCountDict[currentNumber]++;
                }
                else
                {
                    numCountDict[currentNumber] = 1;
                }
            }

            // За второй проход, уже по списку количеств повторений, посчитаем будет ли сумма повторений числа и ближайшего к нему наибольшей
            foreach (var item in numCountDict)
            {
                maxLenght = Math.Max(maxLenght, item.Value + numCountDict.GetValueOrDefault(item.Key - 1, 0));
            }

            return maxLenght;
        }
    }
}
