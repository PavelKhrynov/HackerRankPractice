using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        The distance between two array values is the number of indices between them.
        Given a, find the minimum distance between any pair of equal elements in the array. 
        If no such value exists, return -1.
    */
    internal class MinimumDistance
    {
        /// <summary>
        /// Calculate minimum distance in array
        /// </summary>
        /// <param name="a">Array to handle</param>
        /// <returns>Minimum distance</returns>
        public static int SolveProblem(List<int> a)
        {
            var positionsData = new Dictionary<int, List<int>>();
            int minimumDistance = int.MaxValue;

            for (int i = 0; i < a.Count; i++)
            {
                if (!positionsData.ContainsKey(a[i]))
                {
                    positionsData[a[i]] = new List<int>();
                }
                else
                {
                    for (int j = 0; j < positionsData[a[i]].Count; j++)
                    {
                        int distance = Math.Abs(positionsData[a[i]][j] - i);
                        if (distance < minimumDistance)
                        {
                            minimumDistance = distance;
                        }
                    }
                    
                }

                positionsData[a[i]].Add(i);
            }

            return minimumDistance < int.MaxValue ? minimumDistance : -1;
        }
    }
}
