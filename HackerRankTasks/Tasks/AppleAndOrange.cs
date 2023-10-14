using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        There is no good way do describe this without diagram, so read the full description
        https://www.hackerrank.com/challenges/apple-and-orange/problem
     */
    internal class AppleAndOrange
    {
        /// <summary>
        /// Count number of apples and oranges that fall on Sam's house
        /// </summary>
        /// <param name="s">Start position of Sam's house</param>
        /// <param name="t">End position of Sam's house</param>
        /// <param name="a">Position of apple tree</param>
        /// <param name="b">Position of orange tree</param>
        /// <param name="apples">Distances at which each apple falls from the tree</param>
        /// <param name="oranges">Distances at which each orange falls from the tree</param>
        /// <returns>Number of apples and oranges that fall on Sam's house</returns>
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
