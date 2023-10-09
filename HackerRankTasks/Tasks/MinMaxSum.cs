using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class MinMaxSum
    {
        public static (long, long) StartTask(List<long> arr)
        {
            long min = arr.Min();
            long max = arr.Max();
            long sum = arr.Sum();

            return (sum - max, sum - min);
        }
    }
}
