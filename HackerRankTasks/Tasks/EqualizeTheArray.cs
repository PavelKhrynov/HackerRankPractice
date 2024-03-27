using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class EqualizeTheArray
    {
        /*
            Given an array of integers, determine the minimum number of elements to delete to leave only elements of equal value.
        */
        public static int SolveProblem(List<int> arr)
        {
            int result = 0;
            var numberCounts = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                int number = arr[i];

                if (!numberCounts.ContainsKey(number))
                {
                    numberCounts.Add(number, 0);
                }

                numberCounts[number]++;
            }

            int maxNumberCount = 0;
            foreach (var numberData in numberCounts)
            {
                result += numberData.Value;
                maxNumberCount = Math.Max(maxNumberCount, numberData.Value);
            }

            return result - maxNumberCount;
        }
    }
}
