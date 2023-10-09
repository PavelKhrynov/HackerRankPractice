using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class AppleAndOrange
    {
        public static (int, int) StartTask(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                int appleCoordinate = a + apples[i];
                if (appleCoordinate >= s && appleCoordinate <= t)
                {
                    applesCount++;
                }
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                int orangeCoordinate = b + oranges[i];
                if (orangeCoordinate >= s && orangeCoordinate <= t)
                {
                    orangesCount++;
                }
            }

            return (applesCount, orangesCount);
        }
    }
}
