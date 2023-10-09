using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class BirthdayCakeCandles
    {
        public static int StartTask(List<int> candles)
        {
            int max = candles.Max();
            return candles.Count(x => x == max);
        }
    }
}
