using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        Then print the respective minimum and maximum values as a single line of two space-separated long integers.
    */
    internal class MinMaxSum
    {        
        /// <summary>
        /// Calculate min-max sum of 4 numbers
        /// </summary>
        /// <param name="arr">Array of 5 integers</param>
        /// <returns>Pair of max and min sum</returns>
        public static (long, long) StartTask(List<long> arr)
        {
            long min = arr.Min();
            long max = arr.Max();
            long sum = arr.Sum();

            return (sum - max, sum - min);
        }
    }
}
